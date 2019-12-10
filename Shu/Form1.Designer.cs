namespace Shu
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Spaces = new System.Windows.Forms.CheckBox();
            this.FontSong = new System.Windows.Forms.CheckBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkBoxSBC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 171);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(621, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "竖排";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 227);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(678, 269);
            this.textBox2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 197);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Spaces
            // 
            this.Spaces.AutoSize = true;
            this.Spaces.Location = new System.Drawing.Point(138, 198);
            this.Spaces.Name = "Spaces";
            this.Spaces.Size = new System.Drawing.Size(78, 21);
            this.Spaces.TabIndex = 4;
            this.Spaces.Text = "添加分隔";
            this.Spaces.UseVisualStyleBackColor = true;
            // 
            // FontSong
            // 
            this.FontSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FontSong.AutoSize = true;
            this.FontSong.Font = new System.Drawing.Font("宋体", 7F);
            this.FontSong.Location = new System.Drawing.Point(565, 199);
            this.FontSong.Name = "FontSong";
            this.FontSong.Size = new System.Drawing.Size(51, 17);
            this.FontSong.TabIndex = 5;
            this.FontSong.Text = "宋体";
            this.FontSong.UseVisualStyleBackColor = true;
            this.FontSong.CheckedChanged += new System.EventHandler(this.FontSong_CheckedChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            " ",
            "|",
            " · ",
            " | ",
            "/",
            "\\",
            "、"});
            this.comboBox.Location = new System.Drawing.Point(222, 194);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(51, 25);
            this.comboBox.TabIndex = 6;
            this.comboBox.Text = " ";
            // 
            // checkBoxSBC
            // 
            this.checkBoxSBC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSBC.AutoSize = true;
            this.checkBoxSBC.Checked = true;
            this.checkBoxSBC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSBC.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.checkBoxSBC.Location = new System.Drawing.Point(481, 197);
            this.checkBoxSBC.Name = "checkBoxSBC";
            this.checkBoxSBC.Size = new System.Drawing.Size(78, 21);
            this.checkBoxSBC.TabIndex = 7;
            this.checkBoxSBC.Text = "转到全角";
            this.checkBoxSBC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.checkBoxSBC);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.FontSong);
            this.Controls.Add(this.Spaces);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Shu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox Spaces;
        private System.Windows.Forms.CheckBox FontSong;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckBox checkBoxSBC;
    }
}

