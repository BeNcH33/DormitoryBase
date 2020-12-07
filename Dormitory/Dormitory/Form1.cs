using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
        }
        private void LoadDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Student", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(dataSet, "Table_Student");
                dataGridView1.DataSource = dataSet.Tables["Table_Student"];
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
                dataSet.Tables["Table_Student"].Clear();
                sqlDataAdapter.Fill(dataSet, "Table_Student");
                dataGridView1.DataSource = dataSet.Tables["Table_Student"];
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

        private void toolStripButton_Reload_Click(object sender, EventArgs e)
        {
            ReloadDate();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void подробнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_UpdateFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_UpdateName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_UpdateLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox_UpdateSex.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_UpdateAge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_UpdateTown.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_UpdatePasportSeries.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_UpdatePasportNumber.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_Student WHERE ID_student=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + ";", sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_InfViolation (InfoViolation, TakeAction) VALUES (@InfoViolation, @TakeAction)", sqlConnection);
            cmd.Parameters.AddWithValue("InfoViolation", richTextBox_AddInfo.Text);
            cmd.Parameters.AddWithValue("TakeAction", richTextBox_AddTakeAction.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ReloadDateViolation();
            richTextBox_AddInfo.Clear();
            richTextBox_AddTakeAction.Clear();
        }
        private void ReloadDateViolation ()
        {
            try
            {
                dataSet.Tables["Table_InfViolation"].Clear();
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
                cmd.Parameters.AddWithValue("id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
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

        private void tabControl1_Click(object sender, EventArgs e)
        {
            LoadViolationDate();
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
    }
}
