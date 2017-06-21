namespace HelloWorld
{
    partial class SecondForm
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.GroupBox();
            this.cal = new System.Windows.Forms.Button();
            this.equality = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.FactGroup = new System.Windows.Forms.GroupBox();
            this.FactCalc = new System.Windows.Forms.Button();
            this.ResFact = new System.Windows.Forms.TextBox();
            this.equalSighn = new System.Windows.Forms.Label();
            this.factoriel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CCB = new System.Windows.Forms.Button();
            this.CCBFact = new System.Windows.Forms.Button();
            this.CCBMultiply = new System.Windows.Forms.Button();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbUser.SuspendLayout();
            this.calc.SuspendLayout();
            this.FactGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.textBox3);
            this.gbUser.Controls.Add(this.textBox2);
            this.gbUser.Controls.Add(this.textBox1);
            this.gbUser.Controls.Add(this.txtName3);
            this.gbUser.Controls.Add(this.txtName2);
            this.gbUser.Controls.Add(this.txtName);
            this.gbUser.Controls.Add(this.lblName);
            this.gbUser.Location = new System.Drawing.Point(12, 12);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(658, 81);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Потребител";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име:";
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(278, 99);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 4;
            this.btnHello.Text = "Здрасти ! ";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // calc
            // 
            this.calc.Controls.Add(this.CCBMultiply);
            this.calc.Controls.Add(this.cal);
            this.calc.Controls.Add(this.equality);
            this.calc.Controls.Add(this.equal);
            this.calc.Controls.Add(this.multiply);
            this.calc.Controls.Add(this.Y);
            this.calc.Controls.Add(this.X);
            this.calc.Location = new System.Drawing.Point(12, 115);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(260, 100);
            this.calc.TabIndex = 5;
            this.calc.TabStop = false;
            this.calc.Text = "Калкулатор";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(30, 53);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 9;
            this.cal.Text = "Изчисли";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // equality
            // 
            this.equality.Location = new System.Drawing.Point(190, 27);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(30, 20);
            this.equality.TabIndex = 6;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(162, 28);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(21, 21);
            this.equal.TabIndex = 7;
            this.equal.Text = "=";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(79, 26);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(19, 21);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "x";
            this.multiply.Click += new System.EventHandler(this.label3_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(107, 27);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(51, 20);
            this.Y.TabIndex = 1;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(17, 27);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(51, 20);
            this.X.TabIndex = 0;
            // 
            // FactGroup
            // 
            this.FactGroup.Controls.Add(this.CCBFact);
            this.FactGroup.Controls.Add(this.FactCalc);
            this.FactGroup.Controls.Add(this.ResFact);
            this.FactGroup.Controls.Add(this.equalSighn);
            this.FactGroup.Controls.Add(this.factoriel);
            this.FactGroup.Controls.Add(this.label1);
            this.FactGroup.Location = new System.Drawing.Point(12, 231);
            this.FactGroup.Name = "FactGroup";
            this.FactGroup.Size = new System.Drawing.Size(260, 82);
            this.FactGroup.TabIndex = 10;
            this.FactGroup.TabStop = false;
            this.FactGroup.Text = "Факториел";
            // 
            // FactCalc
            // 
            this.FactCalc.Location = new System.Drawing.Point(30, 47);
            this.FactCalc.Name = "FactCalc";
            this.FactCalc.Size = new System.Drawing.Size(72, 23);
            this.FactCalc.TabIndex = 11;
            this.FactCalc.Text = "Изчисли ";
            this.FactCalc.UseVisualStyleBackColor = true;
            this.FactCalc.Click += new System.EventHandler(this.FactCalc_Click);
            // 
            // ResFact
            // 
            this.ResFact.Location = new System.Drawing.Point(134, 22);
            this.ResFact.Name = "ResFact";
            this.ResFact.Size = new System.Drawing.Size(39, 20);
            this.ResFact.TabIndex = 13;
            // 
            // equalSighn
            // 
            this.equalSighn.AutoSize = true;
            this.equalSighn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalSighn.Location = new System.Drawing.Point(106, 21);
            this.equalSighn.Name = "equalSighn";
            this.equalSighn.Size = new System.Drawing.Size(21, 21);
            this.equalSighn.TabIndex = 12;
            this.equalSighn.Text = "=";
            // 
            // factoriel
            // 
            this.factoriel.Location = new System.Drawing.Point(62, 21);
            this.factoriel.Name = "factoriel";
            this.factoriel.Size = new System.Drawing.Size(36, 20);
            this.factoriel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CCB
            // 
            this.CCB.Location = new System.Drawing.Point(74, 328);
            this.CCB.Name = "CCB";
            this.CCB.Size = new System.Drawing.Size(130, 23);
            this.CCB.TabIndex = 11;
            this.CCB.Text = "Color Change Button";
            this.CCB.UseVisualStyleBackColor = true;
            this.CCB.Click += new System.EventHandler(this.CCB_Click);
            // 
            // CCBFact
            // 
            this.CCBFact.Location = new System.Drawing.Point(134, 48);
            this.CCBFact.Name = "CCBFact";
            this.CCBFact.Size = new System.Drawing.Size(75, 23);
            this.CCBFact.TabIndex = 14;
            this.CCBFact.Text = "CCB";
            this.CCBFact.UseVisualStyleBackColor = true;
            this.CCBFact.Click += new System.EventHandler(this.CCBFact_Click);
            // 
            // CCBMultiply
            // 
            this.CCBMultiply.Location = new System.Drawing.Point(134, 53);
            this.CCBMultiply.Name = "CCBMultiply";
            this.CCBMultiply.Size = new System.Drawing.Size(75, 23);
            this.CCBMultiply.TabIndex = 10;
            this.CCBMultiply.Text = "CCB";
            this.CCBMultiply.UseVisualStyleBackColor = true;
            this.CCBMultiply.Click += new System.EventHandler(this.CCBMultiply_Click);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(244, 29);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(169, 20);
            this.txtName2.TabIndex = 4;
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(419, 29);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(157, 20);
            this.txtName3.TabIndex = 5;
            this.txtName3.TextChanged += new System.EventHandler(this.txtName3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(419, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 8;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 373);
            this.Controls.Add(this.CCB);
            this.Controls.Add(this.FactGroup);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.gbUser);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.calc.ResumeLayout(false);
            this.calc.PerformLayout();
            this.FactGroup.ResumeLayout(false);
            this.FactGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.GroupBox calc;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.TextBox equality;
        private System.Windows.Forms.GroupBox FactGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FactCalc;
        private System.Windows.Forms.TextBox ResFact;
        private System.Windows.Forms.Label equalSighn;
        private System.Windows.Forms.TextBox factoriel;
        private System.Windows.Forms.Button CCB;
        private System.Windows.Forms.Button CCBMultiply;
        private System.Windows.Forms.Button CCBFact;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}