namespace Dormitory
{
    partial class Dormytory
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dormytory));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AllInformation = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_AddStudent = new System.Windows.Forms.TabPage();
            this.button_LoadPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_AddTown = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_AddPasportNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_AddPasportSeries = new System.Windows.Forms.TextBox();
            this.textBox_AddAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AddLastName = new System.Windows.Forms.TextBox();
            this.textBox_AddName = new System.Windows.Forms.TextBox();
            this.textBox_AddFirstName = new System.Windows.Forms.TextBox();
            this.tabPage_AddValiants = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_AllInformation.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_AddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1290, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AllInformation);
            this.tabControl1.Controls.Add(this.tabPage_AddStudent);
            this.tabControl1.Controls.Add(this.tabPage_AddValiants);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 637);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_AllInformation
            // 
            this.tabPage_AllInformation.Controls.Add(this.panel2);
            this.tabPage_AllInformation.Controls.Add(this.dataGridView1);
            this.tabPage_AllInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AllInformation.Name = "tabPage_AllInformation";
            this.tabPage_AllInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AllInformation.Size = new System.Drawing.Size(1282, 611);
            this.tabPage_AllInformation.TabIndex = 0;
            this.tabPage_AllInformation.Text = "Общие данные";
            this.tabPage_AllInformation.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(693, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 436);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(86, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 242);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1170, 546);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage_AddStudent
            // 
            this.tabPage_AddStudent.Controls.Add(this.button_LoadPicture);
            this.tabPage_AddStudent.Controls.Add(this.pictureBox1);
            this.tabPage_AddStudent.Controls.Add(this.panel1);
            this.tabPage_AddStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AddStudent.Name = "tabPage_AddStudent";
            this.tabPage_AddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AddStudent.Size = new System.Drawing.Size(1282, 611);
            this.tabPage_AddStudent.TabIndex = 1;
            this.tabPage_AddStudent.Text = "Добавление студента";
            this.tabPage_AddStudent.UseVisualStyleBackColor = true;
            // 
            // button_LoadPicture
            // 
            this.button_LoadPicture.Location = new System.Drawing.Point(671, 385);
            this.button_LoadPicture.Name = "button_LoadPicture";
            this.button_LoadPicture.Size = new System.Drawing.Size(343, 56);
            this.button_LoadPicture.TabIndex = 2;
            this.button_LoadPicture.Text = "Загрузить фотографию";
            this.button_LoadPicture.UseVisualStyleBackColor = true;
            this.button_LoadPicture.Click += new System.EventHandler(this.button_LoadPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(671, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_AddTown);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_AddPasportNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_AddPasportSeries);
            this.panel1.Controls.Add(this.textBox_AddAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_AddLastName);
            this.panel1.Controls.Add(this.textBox_AddName);
            this.panel1.Controls.Add(this.textBox_AddFirstName);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 517);
            this.panel1.TabIndex = 0;
            // 
            // textBox_AddTown
            // 
            this.textBox_AddTown.Location = new System.Drawing.Point(197, 245);
            this.textBox_AddTown.Name = "textBox_AddTown";
            this.textBox_AddTown.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddTown.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Город";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(35, 290);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(439, 49);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // textBox_AddPasportNumber
            // 
            this.textBox_AddPasportNumber.Location = new System.Drawing.Point(197, 204);
            this.textBox_AddPasportNumber.Name = "textBox_AddPasportNumber";
            this.textBox_AddPasportNumber.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddPasportNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Серия паспорта";
            // 
            // textBox_AddPasportSeries
            // 
            this.textBox_AddPasportSeries.Location = new System.Drawing.Point(197, 162);
            this.textBox_AddPasportSeries.Name = "textBox_AddPasportSeries";
            this.textBox_AddPasportSeries.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddPasportSeries.TabIndex = 8;
            // 
            // textBox_AddAge
            // 
            this.textBox_AddAge.Location = new System.Drawing.Point(197, 124);
            this.textBox_AddAge.Name = "textBox_AddAge";
            this.textBox_AddAge.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // textBox_AddLastName
            // 
            this.textBox_AddLastName.Location = new System.Drawing.Point(197, 84);
            this.textBox_AddLastName.Name = "textBox_AddLastName";
            this.textBox_AddLastName.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddLastName.TabIndex = 2;
            // 
            // textBox_AddName
            // 
            this.textBox_AddName.Location = new System.Drawing.Point(197, 45);
            this.textBox_AddName.Name = "textBox_AddName";
            this.textBox_AddName.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddName.TabIndex = 1;
            // 
            // textBox_AddFirstName
            // 
            this.textBox_AddFirstName.Location = new System.Drawing.Point(197, 9);
            this.textBox_AddFirstName.Name = "textBox_AddFirstName";
            this.textBox_AddFirstName.Size = new System.Drawing.Size(192, 20);
            this.textBox_AddFirstName.TabIndex = 0;
            // 
            // tabPage_AddValiants
            // 
            this.tabPage_AddValiants.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AddValiants.Name = "tabPage_AddValiants";
            this.tabPage_AddValiants.Size = new System.Drawing.Size(1282, 611);
            this.tabPage_AddValiants.TabIndex = 2;
            this.tabPage_AddValiants.Text = "Добавление нарушений";
            this.tabPage_AddValiants.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Dormytory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 662);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Dormytory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AllInformation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_AddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AllInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage_AddStudent;
        private System.Windows.Forms.TabPage tabPage_AddValiants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_AddPasportSeries;
        private System.Windows.Forms.TextBox textBox_AddAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AddLastName;
        private System.Windows.Forms.TextBox textBox_AddName;
        private System.Windows.Forms.TextBox textBox_AddFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_LoadPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_AddPasportNumber;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_AddTown;
        private System.Windows.Forms.Label label15;
    }
}

