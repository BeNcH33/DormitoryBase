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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dormytory));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Reload = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AllInformation = new System.Windows.Forms.TabPage();
            this.panel_InfoStudent = new System.Windows.Forms.Panel();
            this.button_ClosePanel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_AddStudent = new System.Windows.Forms.TabPage();
            this.button_LoadPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAddStudent = new System.Windows.Forms.Panel();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подробнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_UpdateFirstName = new System.Windows.Forms.TextBox();
            this.textBox_UpdateName = new System.Windows.Forms.TextBox();
            this.textBox_UpdateLastName = new System.Windows.Forms.TextBox();
            this.textBox_UpdateSex = new System.Windows.Forms.TextBox();
            this.textBox_UpdateAge = new System.Windows.Forms.TextBox();
            this.textBox_UpdateTown = new System.Windows.Forms.TextBox();
            this.textBox_UpdatePasportSeries = new System.Windows.Forms.TextBox();
            this.textBox_UpdatePasportNumber = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_AllInformation.SuspendLayout();
            this.panel_InfoStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_AddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAddStudent.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Reload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Reload
            // 
            this.toolStripButton_Reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Reload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Reload.Image")));
            this.toolStripButton_Reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Reload.Name = "toolStripButton_Reload";
            this.toolStripButton_Reload.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton_Reload.Text = "Обновить";
            this.toolStripButton_Reload.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(1022, 573);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_AllInformation
            // 
            this.tabPage_AllInformation.Controls.Add(this.panel_InfoStudent);
            this.tabPage_AllInformation.Controls.Add(this.dataGridView1);
            this.tabPage_AllInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AllInformation.Name = "tabPage_AllInformation";
            this.tabPage_AllInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AllInformation.Size = new System.Drawing.Size(1014, 547);
            this.tabPage_AllInformation.TabIndex = 0;
            this.tabPage_AllInformation.Text = "Общие данные";
            this.tabPage_AllInformation.UseVisualStyleBackColor = true;
            // 
            // panel_InfoStudent
            // 
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdatePasportNumber);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdatePasportSeries);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateTown);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateAge);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateSex);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateLastName);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateName);
            this.panel_InfoStudent.Controls.Add(this.textBox_UpdateFirstName);
            this.panel_InfoStudent.Controls.Add(this.button_ClosePanel);
            this.panel_InfoStudent.Controls.Add(this.pictureBox2);
            this.panel_InfoStudent.Location = new System.Drawing.Point(665, 82);
            this.panel_InfoStudent.Name = "panel_InfoStudent";
            this.panel_InfoStudent.Size = new System.Drawing.Size(349, 465);
            this.panel_InfoStudent.TabIndex = 1;
            this.panel_InfoStudent.Visible = false;
            // 
            // button_ClosePanel
            // 
            this.button_ClosePanel.Image = ((System.Drawing.Image)(resources.GetObject("button_ClosePanel.Image")));
            this.button_ClosePanel.Location = new System.Drawing.Point(321, 3);
            this.button_ClosePanel.Name = "button_ClosePanel";
            this.button_ClosePanel.Size = new System.Drawing.Size(25, 25);
            this.button_ClosePanel.TabIndex = 9;
            this.button_ClosePanel.UseVisualStyleBackColor = true;
            this.button_ClosePanel.Click += new System.EventHandler(this.button_ClosePanel_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1039, 612);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // tabPage_AddStudent
            // 
            this.tabPage_AddStudent.Controls.Add(this.button_LoadPicture);
            this.tabPage_AddStudent.Controls.Add(this.pictureBox1);
            this.tabPage_AddStudent.Controls.Add(this.panelAddStudent);
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
            // panelAddStudent
            // 
            this.panelAddStudent.Controls.Add(this.textBox_AddTown);
            this.panelAddStudent.Controls.Add(this.label15);
            this.panelAddStudent.Controls.Add(this.button_Add);
            this.panelAddStudent.Controls.Add(this.textBox_AddPasportNumber);
            this.panelAddStudent.Controls.Add(this.label6);
            this.panelAddStudent.Controls.Add(this.label5);
            this.panelAddStudent.Controls.Add(this.textBox_AddPasportSeries);
            this.panelAddStudent.Controls.Add(this.textBox_AddAge);
            this.panelAddStudent.Controls.Add(this.label4);
            this.panelAddStudent.Controls.Add(this.label3);
            this.panelAddStudent.Controls.Add(this.label2);
            this.panelAddStudent.Controls.Add(this.label1);
            this.panelAddStudent.Controls.Add(this.textBox_AddLastName);
            this.panelAddStudent.Controls.Add(this.textBox_AddName);
            this.panelAddStudent.Controls.Add(this.textBox_AddFirstName);
            this.panelAddStudent.Location = new System.Drawing.Point(9, 17);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(522, 517);
            this.panelAddStudent.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подробнаяИнформацияToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 48);
            // 
            // подробнаяИнформацияToolStripMenuItem
            // 
            this.подробнаяИнформацияToolStripMenuItem.Name = "подробнаяИнформацияToolStripMenuItem";
            this.подробнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.подробнаяИнформацияToolStripMenuItem.Text = "Подробная информация";
            this.подробнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.подробнаяИнформацияToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // textBox_UpdateFirstName
            // 
            this.textBox_UpdateFirstName.Location = new System.Drawing.Point(111, 251);
            this.textBox_UpdateFirstName.Name = "textBox_UpdateFirstName";
            this.textBox_UpdateFirstName.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateFirstName.TabIndex = 10;
            this.textBox_UpdateFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdateName
            // 
            this.textBox_UpdateName.Location = new System.Drawing.Point(111, 277);
            this.textBox_UpdateName.Name = "textBox_UpdateName";
            this.textBox_UpdateName.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateName.TabIndex = 11;
            this.textBox_UpdateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdateLastName
            // 
            this.textBox_UpdateLastName.Location = new System.Drawing.Point(111, 303);
            this.textBox_UpdateLastName.Name = "textBox_UpdateLastName";
            this.textBox_UpdateLastName.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateLastName.TabIndex = 12;
            this.textBox_UpdateLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdateSex
            // 
            this.textBox_UpdateSex.Location = new System.Drawing.Point(111, 329);
            this.textBox_UpdateSex.Name = "textBox_UpdateSex";
            this.textBox_UpdateSex.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateSex.TabIndex = 12;
            this.textBox_UpdateSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdateAge
            // 
            this.textBox_UpdateAge.Location = new System.Drawing.Point(111, 355);
            this.textBox_UpdateAge.Name = "textBox_UpdateAge";
            this.textBox_UpdateAge.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateAge.TabIndex = 13;
            this.textBox_UpdateAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdateTown
            // 
            this.textBox_UpdateTown.Location = new System.Drawing.Point(111, 381);
            this.textBox_UpdateTown.Name = "textBox_UpdateTown";
            this.textBox_UpdateTown.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdateTown.TabIndex = 14;
            this.textBox_UpdateTown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdatePasportSeries
            // 
            this.textBox_UpdatePasportSeries.Location = new System.Drawing.Point(111, 407);
            this.textBox_UpdatePasportSeries.Name = "textBox_UpdatePasportSeries";
            this.textBox_UpdatePasportSeries.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdatePasportSeries.TabIndex = 15;
            this.textBox_UpdatePasportSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UpdatePasportNumber
            // 
            this.textBox_UpdatePasportNumber.Location = new System.Drawing.Point(111, 433);
            this.textBox_UpdatePasportNumber.Name = "textBox_UpdatePasportNumber";
            this.textBox_UpdatePasportNumber.Size = new System.Drawing.Size(158, 20);
            this.textBox_UpdatePasportNumber.TabIndex = 16;
            this.textBox_UpdatePasportNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dormytory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 598);
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
            this.panel_InfoStudent.ResumeLayout(false);
            this.panel_InfoStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_AddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAddStudent.ResumeLayout(false);
            this.panelAddStudent.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Reload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AllInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage_AddStudent;
        private System.Windows.Forms.TabPage tabPage_AddValiants;
        private System.Windows.Forms.Panel panelAddStudent;
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
        private System.Windows.Forms.Panel panel_InfoStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_AddTown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подробнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.Button button_ClosePanel;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_UpdateAge;
        private System.Windows.Forms.TextBox textBox_UpdateSex;
        private System.Windows.Forms.TextBox textBox_UpdateLastName;
        private System.Windows.Forms.TextBox textBox_UpdateName;
        private System.Windows.Forms.TextBox textBox_UpdateFirstName;
        private System.Windows.Forms.TextBox textBox_UpdatePasportSeries;
        private System.Windows.Forms.TextBox textBox_UpdateTown;
        private System.Windows.Forms.TextBox textBox_UpdatePasportNumber;
    }
}

