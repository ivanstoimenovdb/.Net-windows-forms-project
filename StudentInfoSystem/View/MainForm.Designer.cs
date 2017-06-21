namespace StudentInfoSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uploadPic = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.StudentInfo = new System.Windows.Forms.GroupBox();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.groupLbl = new System.Windows.Forms.Label();
            this.textFlow = new System.Windows.Forms.TextBox();
            this.flowlbl = new System.Windows.Forms.Label();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFacNum = new System.Windows.Forms.TextBox();
            this.FacNumlbl = new System.Windows.Forms.Label();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.comboOKS = new System.Windows.Forms.ComboBox();
            this.OKS = new System.Windows.Forms.Label();
            this.textSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textFac = new System.Windows.Forms.TextBox();
            this.Fac = new System.Windows.Forms.Label();
            this.groupPrivate = new System.Windows.Forms.GroupBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1.SuspendLayout();
            this.StudentInfo.SuspendLayout();
            this.groupPrivate.SuspendLayout();
            this.imageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uploadPic);
            this.tabPage1.Controls.Add(this.btnHello);
            this.tabPage1.Controls.Add(this.StudentInfo);
            this.tabPage1.Controls.Add(this.groupPrivate);
            this.tabPage1.Controls.Add(this.imageGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студент";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(32, 175);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(87, 23);
            this.uploadPic.TabIndex = 2;
            this.uploadPic.Text = "Качи снимка";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(32, 208);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(88, 23);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Здрасти ! ";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // StudentInfo
            // 
            this.StudentInfo.Controls.Add(this.textGroup);
            this.StudentInfo.Controls.Add(this.groupLbl);
            this.StudentInfo.Controls.Add(this.textFlow);
            this.StudentInfo.Controls.Add(this.flowlbl);
            this.StudentInfo.Controls.Add(this.comboCourse);
            this.StudentInfo.Controls.Add(this.label3);
            this.StudentInfo.Controls.Add(this.textFacNum);
            this.StudentInfo.Controls.Add(this.FacNumlbl);
            this.StudentInfo.Controls.Add(this.StatusCombo);
            this.StudentInfo.Controls.Add(this.Status);
            this.StudentInfo.Controls.Add(this.comboOKS);
            this.StudentInfo.Controls.Add(this.OKS);
            this.StudentInfo.Controls.Add(this.textSpec);
            this.StudentInfo.Controls.Add(this.label2);
            this.StudentInfo.Controls.Add(this.textFac);
            this.StudentInfo.Controls.Add(this.Fac);
            this.StudentInfo.Location = new System.Drawing.Point(181, 126);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(362, 174);
            this.StudentInfo.TabIndex = 2;
            this.StudentInfo.TabStop = false;
            this.StudentInfo.Text = "Студентска информация";
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(297, 80);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(46, 20);
            this.textGroup.TabIndex = 15;
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(252, 82);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(39, 13);
            this.groupLbl.TabIndex = 14;
            this.groupLbl.Text = "Група:";
            // 
            // textFlow
            // 
            this.textFlow.Location = new System.Drawing.Point(297, 53);
            this.textFlow.Name = "textFlow";
            this.textFlow.Size = new System.Drawing.Size(46, 20);
            this.textFlow.TabIndex = 13;
            // 
            // flowlbl
            // 
            this.flowlbl.AutoSize = true;
            this.flowlbl.Location = new System.Drawing.Point(250, 56);
            this.flowlbl.Name = "flowlbl";
            this.flowlbl.Size = new System.Drawing.Size(41, 13);
            this.flowlbl.TabIndex = 12;
            this.flowlbl.Text = "Поток:";
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboCourse.Location = new System.Drawing.Point(297, 26);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(46, 21);
            this.comboCourse.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Курс:";
            // 
            // textFacNum
            // 
            this.textFacNum.Location = new System.Drawing.Point(103, 135);
            this.textFacNum.Name = "textFacNum";
            this.textFacNum.Size = new System.Drawing.Size(131, 20);
            this.textFacNum.TabIndex = 4;
            // 
            // FacNumlbl
            // 
            this.FacNumlbl.AutoSize = true;
            this.FacNumlbl.Location = new System.Drawing.Point(19, 138);
            this.FacNumlbl.Name = "FacNumlbl";
            this.FacNumlbl.Size = new System.Drawing.Size(70, 13);
            this.FacNumlbl.TabIndex = 4;
            this.FacNumlbl.Text = "Фак.Номер:";
            // 
            // StatusCombo
            // 
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Items.AddRange(new object[] {
            "Учещ",
            "Прекъснал",
            "Семестриално Завършил",
            "Дипломиран"});
            this.StatusCombo.Location = new System.Drawing.Point(103, 108);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(131, 21);
            this.StatusCombo.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(43, 108);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 13);
            this.Status.TabIndex = 9;
            this.Status.Text = "Статус:";
            // 
            // comboOKS
            // 
            this.comboOKS.FormattingEnabled = true;
            this.comboOKS.Items.AddRange(new object[] {
            "Бакалавър",
            "Магистър–изравнително",
            "Магистър "});
            this.comboOKS.Location = new System.Drawing.Point(103, 79);
            this.comboOKS.Name = "comboOKS";
            this.comboOKS.Size = new System.Drawing.Size(131, 21);
            this.comboOKS.TabIndex = 8;
            // 
            // OKS
            // 
            this.OKS.AutoSize = true;
            this.OKS.Location = new System.Drawing.Point(55, 79);
            this.OKS.Name = "OKS";
            this.OKS.Size = new System.Drawing.Size(32, 13);
            this.OKS.TabIndex = 7;
            this.OKS.Text = "ОКС:";
            this.OKS.Click += new System.EventHandler(this.label3_Click);
            // 
            // textSpec
            // 
            this.textSpec.Location = new System.Drawing.Point(103, 49);
            this.textSpec.Name = "textSpec";
            this.textSpec.Size = new System.Drawing.Size(131, 20);
            this.textSpec.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Специалност:";
            // 
            // textFac
            // 
            this.textFac.Location = new System.Drawing.Point(103, 23);
            this.textFac.Name = "textFac";
            this.textFac.Size = new System.Drawing.Size(131, 20);
            this.textFac.TabIndex = 4;
            // 
            // Fac
            // 
            this.Fac.AutoSize = true;
            this.Fac.Location = new System.Drawing.Point(27, 26);
            this.Fac.Name = "Fac";
            this.Fac.Size = new System.Drawing.Size(60, 13);
            this.Fac.TabIndex = 4;
            this.Fac.Text = "Факултет:";
            // 
            // groupPrivate
            // 
            this.groupPrivate.Controls.Add(this.LastName);
            this.groupPrivate.Controls.Add(this.label1);
            this.groupPrivate.Controls.Add(this.SecondName);
            this.groupPrivate.Controls.Add(this.lblName2);
            this.groupPrivate.Controls.Add(this.FirstName);
            this.groupPrivate.Controls.Add(this.lblName);
            this.groupPrivate.Location = new System.Drawing.Point(181, 11);
            this.groupPrivate.Name = "groupPrivate";
            this.groupPrivate.Size = new System.Drawing.Size(359, 109);
            this.groupPrivate.TabIndex = 3;
            this.groupPrivate.TabStop = false;
            this.groupPrivate.Text = "Лични данни";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(79, 79);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(244, 20);
            this.LastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия:";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(79, 54);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(244, 20);
            this.SecondName.TabIndex = 2;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(17, 56);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(56, 13);
            this.lblName2.TabIndex = 6;
            this.lblName2.Text = "Презиме:";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(79, 28);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(244, 20);
            this.FirstName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Име:";
            // 
            // imageGroup
            // 
            this.imageGroup.Controls.Add(this.picture);
            this.imageGroup.Location = new System.Drawing.Point(3, 6);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Size = new System.Drawing.Size(166, 156);
            this.imageGroup.TabIndex = 2;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Снимка";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(28, 19);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 125);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // loginLogoutToolStripMenuItem
            // 
            this.loginLogoutToolStripMenuItem.Name = "loginLogoutToolStripMenuItem";
            this.loginLogoutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginLogoutToolStripMenuItem.Text = "Login";
            this.loginLogoutToolStripMenuItem.Click += new System.EventHandler(this.loginLogoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "About";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginLogoutToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.StudentInfo.ResumeLayout(false);
            this.StudentInfo.PerformLayout();
            this.groupPrivate.ResumeLayout(false);
            this.groupPrivate.PerformLayout();
            this.imageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox StudentInfo;
        private System.Windows.Forms.Label OKS;
        private System.Windows.Forms.TextBox textSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFac;
        private System.Windows.Forms.Label Fac;
        private System.Windows.Forms.GroupBox groupPrivate;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox comboOKS;
        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.TextBox textFlow;
        private System.Windows.Forms.Label flowlbl;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFacNum;
        private System.Windows.Forms.Label FacNumlbl;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button uploadPic;
    }
}