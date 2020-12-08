using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dormitory
{
    public partial class Dormytory : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommandBuilder sqlBuilder;
        DataSet dataSet=new DataSet();
        public Dormytory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=BENCH-LAPTOP\SQLEXPRESS;Initial Catalog=Dormitory;Integrated Security=True");
            sqlConnection.Open();
            LoadDate();
            LoadViolationDate();
            LoadRoomDate();
            LoadSpace();
        }
        private void LoadDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Student", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(dataSet, "Table_Student");
                dataGridView_AllStudents.DataSource = dataSet.Tables["Table_Student"];
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadDate()   
        {
            try
            {
                //dataSet.Tables["Table_Student"].Clear();
                sqlDataAdapter.Fill(dataSet, "Table_Student");
                dataGridView_AllStudents.DataSource = dataSet.Tables["Table_Student"];
            }
               catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_LoadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bmp = new Bitmap(openFileDialog1.FileName);
                    pictureBox_AddPhotoStudent.Image = (Image)bmp;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView_AllStudents, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void подробнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_UpdateFirstName.Text = dataGridView_AllStudents.CurrentRow.Cells[1].Value.ToString();
            textBox_UpdateName.Text = dataGridView_AllStudents.CurrentRow.Cells[2].Value.ToString();
            textBox_UpdateLastName.Text = dataGridView_AllStudents.CurrentRow.Cells[3].Value.ToString();
            comboBox_UpdateSex.Text = dataGridView_AllStudents.CurrentRow.Cells[4].Value.ToString();
            textBox_UpdateAge.Text = dataGridView_AllStudents.CurrentRow.Cells[5].Value.ToString();
            textBox_UpdateTown.Text = dataGridView_AllStudents.CurrentRow.Cells[6].Value.ToString();
            textBox_UpdatePasportSeries.Text = dataGridView_AllStudents.CurrentRow.Cells[7].Value.ToString();
            textBox_UpdatePasportNumber.Text = dataGridView_AllStudents.CurrentRow.Cells[8].Value.ToString();
            //pictureBox_Photo.Image = Image.FromFile("@"+dataGridView1.CurrentRow.Cells[9].Value.ToString()+"");
            panel_InfoStudent.Visible = true;
        }

        private void button_ClosePanel_Click(object sender, EventArgs e)
        {
            panel_InfoStudent.Visible = false;
        }

        private void button_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string LocationPhoto = pictureBox_AddPhotoStudent.ImageLocation;
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Student (FirstName, Name, LastName, Sex, Age, Town,PasportSeries, PasportNumber) VALUES (@FirstName, @Name, @LastName, @Sex, @Age, @Town, @PasportSeries, @PasportNumber)", sqlConnection);
                cmd.Parameters.AddWithValue("FirstName", textBox_AddFirstName.Text);
                cmd.Parameters.AddWithValue("Name", textBox_AddName.Text);
                cmd.Parameters.AddWithValue("LastName", textBox_AddLastName.Text);
                cmd.Parameters.AddWithValue("Sex", comboBox_AddSex.Text);
                cmd.Parameters.AddWithValue("Age", textBox_AddAge.Text);
                cmd.Parameters.AddWithValue("Town", textBox_AddTown.Text);
                cmd.Parameters.AddWithValue("PasportSeries", textBox_AddPasportSeries.Text);
                cmd.Parameters.AddWithValue("PasportNumber", textBox_AddPasportNumber.Text);
                //label10.Text = LocationPhoto;
                //cmd.Parameters.AddWithValue("PhotoStudent", LocationPhoto);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ReloadDate();

                textBox_AddFirstName.Clear();
                textBox_AddName.Clear();
                textBox_AddLastName.Clear();
                textBox_AddAge.Clear();
                textBox_AddTown.Clear();
                textBox_AddPasportSeries.Clear();
                textBox_AddPasportNumber.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_Student WHERE ID_student=" + Convert.ToInt32(dataGridView_AllStudents.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Table_Violation WHERE ID_student=" + Convert.ToInt32(dataGridView_AllStudents.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                ReloadDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }           

        private void LoadViolationDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_InfViolation", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table_InfViolation");
                dataGridView_InfoViolation.DataSource = dataSet.Tables["Table_InfViolation"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AddViolation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_InfViolation (InfoViolation, TakeAction, CategioryViolation) VALUES (@InfoViolation, @TakeAction, @CategioryViolation)", sqlConnection);
            cmd.Parameters.AddWithValue("InfoViolation", richTextBox_AddInfo.Text);
            cmd.Parameters.AddWithValue("TakeAction", richTextBox_AddTakeAction.Text);
            cmd.Parameters.AddWithValue("CategioryViolation", textBox_AddCategory.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ReloadDateViolation();
            textBox_AddCategory.Clear();
            richTextBox_AddInfo.Clear();
            richTextBox_AddTakeAction.Clear();
        }
        private void ReloadDateViolation ()
        {
            try
            {
                sqlDataAdapter.Fill(dataSet, "Table_InfViolation");
                dataGridView_InfoViolation.DataSource = dataSet.Tables["Table_InfViolation"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ReloadDate_Click(object sender, EventArgs e)
        {
            try
            {
                //string LocationPhoto = pictureBox_AddPhotoStudent.ImageLocation;
                SqlCommand cmd = new SqlCommand("UPDATE Table_Student SET FirstName=@FirstName, Name=@Name, LastName=@LastName, Sex=@Sex, Age=@Age, Town=@Town,PasportSeries=@PasportSeries, PasportNumber=@PasportNumber  WHERE ID_student=@id", sqlConnection);
                cmd.Parameters.AddWithValue("FirstName", textBox_UpdateFirstName.Text);
                cmd.Parameters.AddWithValue("Name", textBox_UpdateName.Text);
                cmd.Parameters.AddWithValue("LastName", textBox_UpdateLastName.Text);
                cmd.Parameters.AddWithValue("Sex", comboBox_UpdateSex.Text);
                cmd.Parameters.AddWithValue("Age", textBox_UpdateAge.Text);
                cmd.Parameters.AddWithValue("Town", textBox_UpdateTown.Text);
                cmd.Parameters.AddWithValue("PasportSeries", textBox_UpdatePasportSeries.Text);
                cmd.Parameters.AddWithValue("PasportNumber", textBox_UpdatePasportNumber.Text);
                cmd.Parameters.AddWithValue("id", dataGridView_AllStudents.CurrentRow.Cells[0].Value.ToString());
                //label10.Text = LocationPhoto;
                //cmd.Parameters.AddWithValue("PhotoStudent", LocationPhoto);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ReloadDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_InfViolation WHERE ID_Violation=" + Convert.ToInt32(dataGridView_InfoViolation.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ReloadDateViolation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_InfoViolation_MouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip_Violation.Show(this.dataGridView_InfoViolation, e.Location);
                this.contextMenuStrip_Violation.Show(Cursor.Position);
            }
        }

        private void button_NewViolation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CategioryViolation FROM Table_InfViolation", sqlConnection);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listBox = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox.Add(reader.GetValue(0).ToString());
                }
            }
            for(int i = 0; i < listBox.Count; i++)
            {
                comboBox_CategoryViolation.Items.Add(listBox[i]);
            }
            panel_AddViolation.Visible = true;
            reader.Close();
        }

        private void button_AddNewViolation_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Violation (ID_Student, CategoryViolation) VALUES (@ID_Student, @CategoryViolation)", sqlConnection);
                cmd.Parameters.AddWithValue("ID_Student", Convert.ToInt32(dataGridView_AllStudents.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("CategoryViolation", comboBox_CategoryViolation.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                panel_AddViolation.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRoomDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Room", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table_Room");
                dataGridView_InfoRoom.DataSource = dataSet.Tables["Table_Room"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Room (NumberRoom, Floor, NumberSeats , Cost) VALUES (@NumberRoom, @Floor, @NumberSeats, @Cost)", sqlConnection);
                cmd.Parameters.AddWithValue("NumberRoom", textBox_AddNumberRoom.Text);
                cmd.Parameters.AddWithValue("Floor", textBox_AddNumberFloor.Text);
                cmd.Parameters.AddWithValue("NumberSeats", textBox_AddNumberSeats.Text);
                cmd.Parameters.AddWithValue("Cost", textBox_AddCost.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                panel_AddViolation.Visible = false;

                textBox_AddNumberRoom.Clear();
                textBox_AddNumberFloor.Clear();
                textBox_AddNumberSeats.Clear();
                textBox_AddCost.Clear();
                ReloadInfoRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadViolation()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Violation", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table_Violation");
                dataGridView_Violation.DataSource = dataSet.Tables["Table_Violation"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_InfoValiant_Click(object sender, EventArgs e)
        {
            LoadViolation();
            panel_Violation.Visible = true;
            button_Hide.Visible = true;
            button_Clear.Visible = false;
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            panel_Violation.Visible = false;
            button_Clear.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox_UpdadeStudentViolation.Text = dataGridView_Violation.CurrentRow.Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CategioryViolation FROM Table_InfViolation", sqlConnection);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listBox = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox.Add(reader.GetValue(0).ToString());
                }
            }
            for (int i = 0; i < listBox.Count; i++)
            {
                comboBox_ViolationUpdate.Items.Add(listBox[i]);
            }
            listBox.Clear();
            panel_AddViolation.Visible = true;
            reader.Close();



            panel_UpdateViolation.Visible = true;
        }

        private void dataGridView_Violation_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip_AllViolation.Show(this.dataGridView_AllStudents, e.Location);
                this.contextMenuStrip_AllViolation.Show(Cursor.Position);
            }
        }

        private void button_UpdateViolation_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_Violation SET ID_Student=@ID_Student, CategoryViolation=@CategoryViolation  WHERE ID_student=@id", sqlConnection);
                cmd.Parameters.AddWithValue("ID_Student", textBox_UpdadeStudentViolation.Text);
                cmd.Parameters.AddWithValue("CategoryViolation", comboBox_ViolationUpdate.Text);
                cmd.Parameters.AddWithValue("id", dataGridView_Violation.CurrentRow.Cells[0].Value.ToString());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                ReloadViolationStudent(); 
                panel_UpdateViolation.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadViolationStudent()
        {
            try
            {
                sqlDataAdapter.Fill(dataSet, "Table_Violation");
                dataGridView_Violation.DataSource = dataSet.Tables["Table_Violation"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_Violation WHERE ID_Student=" + Convert.ToInt32(dataGridView_Violation.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ReloadViolationStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadInfoRoom()
        {
            try
            {
                sqlDataAdapter.Fill(dataSet, "Table_Room");
                dataGridView_InfoRoom.DataSource = dataSet.Tables["Table_Room"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_Room WHERE NumberRoom=" + Convert.ToInt32(dataGridView_InfoRoom.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ReloadInfoRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSpace()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Space", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table_Space");
                dataGridView_Space.DataSource = dataSet.Tables["Table_Space"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AddSpace_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Space (NameSpace, FloorSpace) VALUES (@NameSpace, @FloorSpace)", sqlConnection);
                cmd.Parameters.AddWithValue("NameSpace", textBox_AddSpaceName.Text);
                cmd.Parameters.AddWithValue("FloorSpace", textBox_AddSpaceFloor.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                panel_AddViolation.Visible = false;

                textBox_AddSpaceName.Clear();
                textBox_AddSpaceFloor.Clear();
                ReloadInfoSpace();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadInfoSpace()
        {
            try
            {
                sqlDataAdapter.Fill(dataSet, "Table_Space");
                dataGridView_InfoRoom.DataSource = dataSet.Tables["Table_Space"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            panel_clear.Visible = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            panel_clear.Visible = true;
        }
    }
}
