namespace Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSecond = new Label();
            lblDay = new Label();
            lblDate = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BorderStyle = BorderStyle.FixedSingle;
            lblTime.Font = new Font("DS-Digital", 90F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(256, 73);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(323, 120);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Font = new Font("DS-Digital", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecond.ForeColor = Color.White;
            lblSecond.Location = new Point(576, 141);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(70, 49);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "22";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BorderStyle = BorderStyle.FixedSingle;
            lblDay.Font = new Font("DS-Digital", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(485, 230);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(161, 38);
            lblDay.TabIndex = 2;
            lblDay.Text = "SATURDAY";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.FixedSingle;
            lblDate.Font = new Font("DS-Digital", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(128, 230);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(251, 38);
            lblDate.TabIndex = 3;
            lblDate.Text = "JANUARY 6 2024";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(329, 374);
            label1.Name = "label1";
            label1.Size = new Size(184, 18);
            label1.TabIndex = 4;
            label1.Text = "Developed By Nidurshan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(783, 412);
            Controls.Add(label1);
            Controls.Add(lblDate);
            Controls.Add(lblDay);
            Controls.Add(lblSecond);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSecond;
        private Label lblDay;
        private Label lblDate;
        private System.Windows.Forms.Timer timer;
        private Label label1;
    }
}
