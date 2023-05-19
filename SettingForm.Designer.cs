namespace 久坐提醒
{
    partial class SettingForm
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
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            trackBar1 = new TrackBar();
            button2 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 221, 221);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(514, 176);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 51);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(376, 119);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 5;
            button1.Text = "恢复默认设置";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(23, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 23);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Windows 启动时启动";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 1;
            label1.Text = "在此时间提示";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(126, 23);
            trackBar1.Maximum = 6;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(365, 45);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(346, 268);
            button2.Name = "button2";
            button2.Size = new Size(115, 36);
            button2.TabIndex = 6;
            button2.Text = "确定";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 207, 207);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 44);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(249, 15);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 0;
            label2.Text = "设置";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 276);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(542, 326);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingForm";
            FormClosed += SettingForm_FormClosed;
            Load += SettingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TrackBar trackBar1;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}