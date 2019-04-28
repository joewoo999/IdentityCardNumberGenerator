namespace 身份证号码生成器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.region = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.proBox = new System.Windows.Forms.ComboBox();
            this.rebox = new System.Windows.Forms.GroupBox();
            this.listResult = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.IDNo = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkResult = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.region.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rebox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.info.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // region
            // 
            this.region.Controls.Add(this.panel3);
            this.region.Controls.Add(this.panel2);
            this.region.Controls.Add(this.panel1);
            this.region.Location = new System.Drawing.Point(12, 12);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(161, 128);
            this.region.TabIndex = 0;
            this.region.TabStop = false;
            this.region.Text = "所在地";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.districtBox);
            this.panel3.Location = new System.Drawing.Point(7, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 20);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "区";
            // 
            // districtBox
            // 
            this.districtBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.districtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.districtBox.FormattingEnabled = true;
            this.districtBox.ItemHeight = 12;
            this.districtBox.Location = new System.Drawing.Point(43, 0);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(101, 20);
            this.districtBox.TabIndex = 1;
            this.districtBox.TextChanged += new System.EventHandler(this.district_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cityBox);
            this.panel2.Location = new System.Drawing.Point(7, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 20);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "市";
            // 
            // cityBox
            // 
            this.cityBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.ItemHeight = 12;
            this.cityBox.Location = new System.Drawing.Point(43, 0);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(101, 20);
            this.cityBox.TabIndex = 1;
            this.cityBox.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.proBox);
            this.panel1.Location = new System.Drawing.Point(7, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 20);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "省";
            // 
            // proBox
            // 
            this.proBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.proBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proBox.FormattingEnabled = true;
            this.proBox.ItemHeight = 12;
            this.proBox.Location = new System.Drawing.Point(43, 0);
            this.proBox.Name = "proBox";
            this.proBox.Size = new System.Drawing.Size(101, 20);
            this.proBox.TabIndex = 1;
            this.proBox.TextChanged += new System.EventHandler(this.pro_TextChanged);
            // 
            // rebox
            // 
            this.rebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rebox.Controls.Add(this.listResult);
            this.rebox.Location = new System.Drawing.Point(194, 12);
            this.rebox.Name = "rebox";
            this.rebox.Size = new System.Drawing.Size(162, 263);
            this.rebox.TabIndex = 2;
            this.rebox.TabStop = false;
            this.rebox.Text = "结果";
            // 
            // listResult
            // 
            this.listResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listResult.Location = new System.Drawing.Point(3, 17);
            this.listResult.Name = "listResult";
            this.listResult.ReadOnly = true;
            this.listResult.Size = new System.Drawing.Size(153, 259);
            this.listResult.TabIndex = 0;
            this.listResult.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.birthdayPicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 21);
            this.panel4.TabIndex = 3;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "yyyy-MM-dd";
            this.birthdayPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(62, 0);
            this.birthdayPicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.birthdayPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.ShowUpDown = true;
            this.birthdayPicker.Size = new System.Drawing.Size(82, 21);
            this.birthdayPicker.TabIndex = 2;
            this.birthdayPicker.Value = new System.DateTime(2018, 8, 24, 0, 0, 0, 0);
            this.birthdayPicker.ValueChanged += new System.EventHandler(this.birthdayPicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "出生日期";
            // 
            // info
            // 
            this.info.Controls.Add(this.panel6);
            this.info.Controls.Add(this.panel5);
            this.info.Controls.Add(this.panel4);
            this.info.Location = new System.Drawing.Point(12, 146);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(161, 102);
            this.info.TabIndex = 4;
            this.info.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ageBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(7, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(144, 23);
            this.panel6.TabIndex = 6;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageBox.Location = new System.Drawing.Point(62, 1);
            this.ageBox.Maximum = new decimal(new int[] {
            115,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(82, 21);
            this.ageBox.TabIndex = 2;
            this.ageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ageBox.ValueChanged += new System.EventHandler(this.ageBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "年龄";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.female);
            this.panel5.Controls.Add(this.male);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(7, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 21);
            this.panel5.TabIndex = 5;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(105, 3);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(35, 16);
            this.female.TabIndex = 7;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(62, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(35, 16);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "性别";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(19, 254);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(153, 34);
            this.generate.TabIndex = 5;
            this.generate.Text = "生成号码";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // IDNo
            // 
            this.IDNo.ForeColor = System.Drawing.Color.Gray;
            this.IDNo.Location = new System.Drawing.Point(7, 19);
            this.IDNo.Name = "IDNo";
            this.IDNo.Size = new System.Drawing.Size(153, 21);
            this.IDNo.TabIndex = 0;
            this.IDNo.Text = "输入18位身份证号码";
            this.IDNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDNo.Click += new System.EventHandler(this.IDNo_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(185, 19);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(72, 23);
            this.check.TabIndex = 2;
            this.check.Text = "验证";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkResult);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.IDNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "号码验证";
            // 
            // checkResult
            // 
            this.checkResult.ForeColor = System.Drawing.Color.Red;
            this.checkResult.Location = new System.Drawing.Point(7, 51);
            this.checkResult.Multiline = true;
            this.checkResult.Name = "checkResult";
            this.checkResult.ReadOnly = true;
            this.checkResult.Size = new System.Drawing.Size(331, 31);
            this.checkResult.TabIndex = 4;
            this.checkResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(263, 19);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(368, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rebox);
            this.Controls.Add(this.region);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 430);
            this.MinimumSize = new System.Drawing.Size(384, 430);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "身份证号码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.region.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rebox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.info.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox region;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox districtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox proBox;
        private System.Windows.Forms.GroupBox rebox;
        private System.Windows.Forms.RichTextBox listResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox IDNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox checkResult;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ageBox;
    }
}

