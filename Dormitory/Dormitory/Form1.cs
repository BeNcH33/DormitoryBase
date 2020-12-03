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
            //this.WindowState = FormWindowState.Maximized;
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
            Bitmap bmp;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = (Image)bmp;
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
            textBox_UpdateSex.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_UpdateAge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_UpdateTown.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_UpdatePasportSeries.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_UpdatePasportNumber.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            

            panel_InfoStudent.Visible = true;
        }

        private void button_ClosePanel_Click(object sender, EventArgs e)
        {
            panel_InfoStudent.Visible = false;
        }

        private void button_Add_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_Student (FirstName, Name, LastName, Sex, Age, Town,PasportSeries, PasportNumber) VALUES (@FirstName, @Name, @LastName, @Sex, @Age, @Town, @PasportSeries, @PasportNumber)", sqlConnection);
            cmd.Parameters.AddWithValue("FirstName", textBox_AddFirstName.Text);
            cmd.Parameters.AddWithValue("Name", textBox_AddName.Text);
            cmd.Parameters.AddWithValue("LastName", textBox_AddLastName.Text);
            cmd.Parameters.AddWithValue("Sex", textBox_AddSex.Text);
            cmd.Parameters.AddWithValue("Age", textBox_AddAge.Text);
            cmd.Parameters.AddWithValue("Town", textBox_AddTown.Text);
            cmd.Parameters.AddWithValue("PasportSeries", textBox_AddPasportSeries.Text);
            cmd.Parameters.AddWithValue("PasportNumber", textBox_AddPasportNumber.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ReloadDate();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Table_Student WHERE ID_student=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)+";",sqlConnection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ReloadDate();
        }

        private void LoadViolationDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Table_Violation", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table_Violation");
                dataGridView_InfoViolation.DataSource = dataSet.Tables["Table_Violation"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_LoadViolation_Click(object sender, EventArgs e)
        {
            LoadViolationDate();
        }

        private void button_AddViolation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_InfViolation (InfoViolation, TakeAction) VALUES (@)", sqlConnection);
        }
    }
}
