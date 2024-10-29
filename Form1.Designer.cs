namespace MyGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAmpCalc = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHz = new System.Windows.Forms.NumericUpDown();
            this.copyButton = new System.Windows.Forms.Button();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.errorProviderHz = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZahnHz = new System.Windows.Forms.NumericUpDown();
            this.copyButtonZahn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResultZahn = new System.Windows.Forms.TextBox();
            this.btnAmpCalcZahn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHz)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxZahnHz)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAmpCalc
            // 
            this.btnAmpCalc.AutoSize = true;
            this.btnAmpCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAmpCalc.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpCalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAmpCalc.Location = new System.Drawing.Point(6, 44);
            this.btnAmpCalc.Name = "btnAmpCalc";
            this.btnAmpCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAmpCalc.Size = new System.Drawing.Size(162, 23);
            this.btnAmpCalc.TabIndex = 0;
            this.btnAmpCalc.Text = "Amplitude Berechnen ";
            this.btnAmpCalc.UseVisualStyleBackColor = false;
            this.btnAmpCalc.Click += new System.EventHandler(this.BtnAmpCalc_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(132, 23);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(20, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Hz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxHz);
            this.groupBox1.Controls.Add(this.copyButton);
            this.groupBox1.Controls.Add(this.textBoxresult);
            this.groupBox1.Controls.Add(this.btnAmpCalc);
            this.groupBox1.Controls.Add(this.labelInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechteckige Sinusschwingung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "dB";
            // 
            // textBoxHz
            // 
            this.textBoxHz.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxHz.Location = new System.Drawing.Point(6, 21);
            this.textBoxHz.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.textBoxHz.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxHz.Name = "textBoxHz";
            this.textBoxHz.Size = new System.Drawing.Size(120, 20);
            this.textBoxHz.TabIndex = 5;
            this.textBoxHz.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.copyButton.ForeColor = System.Drawing.Color.Black;
            this.copyButton.Location = new System.Drawing.Point(112, 93);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(40, 25);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(6, 73);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.ReadOnly = true;
            this.textBoxresult.Size = new System.Drawing.Size(100, 20);
            this.textBoxresult.TabIndex = 3;
            // 
            // errorProviderHz
            // 
            this.errorProviderHz.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 441);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxZahnHz);
            this.groupBox2.Controls.Add(this.copyButtonZahn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxResultZahn);
            this.groupBox2.Controls.Add(this.btnAmpCalcZahn);
            this.groupBox2.Location = new System.Drawing.Point(211, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sägezahn Sinusschwingung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "dB";
            // 
            // textBoxZahnHz
            // 
            this.textBoxZahnHz.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxZahnHz.Location = new System.Drawing.Point(6, 21);
            this.textBoxZahnHz.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.textBoxZahnHz.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxZahnHz.Name = "textBoxZahnHz";
            this.textBoxZahnHz.Size = new System.Drawing.Size(120, 20);
            this.textBoxZahnHz.TabIndex = 5;
            this.textBoxZahnHz.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // copyButtonZahn
            // 
            this.copyButtonZahn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.copyButtonZahn.ForeColor = System.Drawing.Color.Black;
            this.copyButtonZahn.Location = new System.Drawing.Point(112, 93);
            this.copyButtonZahn.Name = "copyButtonZahn";
            this.copyButtonZahn.Size = new System.Drawing.Size(40, 25);
            this.copyButtonZahn.TabIndex = 4;
            this.copyButtonZahn.Text = "copy";
            this.copyButtonZahn.UseVisualStyleBackColor = false;
            this.copyButtonZahn.Click += new System.EventHandler(this.CopyButtonZahn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hz";
            // 
            // textBoxResultZahn
            // 
            this.textBoxResultZahn.Location = new System.Drawing.Point(6, 76);
            this.textBoxResultZahn.Name = "textBoxResultZahn";
            this.textBoxResultZahn.ReadOnly = true;
            this.textBoxResultZahn.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultZahn.TabIndex = 3;
            // 
            // btnAmpCalcZahn
            // 
            this.btnAmpCalcZahn.AutoSize = true;
            this.btnAmpCalcZahn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAmpCalcZahn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpCalcZahn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAmpCalcZahn.Location = new System.Drawing.Point(6, 47);
            this.btnAmpCalcZahn.Name = "btnAmpCalcZahn";
            this.btnAmpCalcZahn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAmpCalcZahn.Size = new System.Drawing.Size(162, 23);
            this.btnAmpCalcZahn.TabIndex = 0;
            this.btnAmpCalcZahn.Text = "Amplitude Berechnen ";
            this.btnAmpCalcZahn.UseVisualStyleBackColor = false;
            this.btnAmpCalcZahn.Click += new System.EventHandler(this.BtnAmpCalcZahn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 473);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinus-Berechnung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hilfe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Willkommen zu meinem Programm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gemacht von Avram ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 473);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amplituden Rechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHz)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxZahnHz)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmpCalc;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.ErrorProvider errorProviderHz;
        private System.Windows.Forms.NumericUpDown textBoxHz;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown textBoxZahnHz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButtonZahn;
        private System.Windows.Forms.TextBox textBoxResultZahn;
        private System.Windows.Forms.Button btnAmpCalcZahn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

