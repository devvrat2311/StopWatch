namespace StopWatch
{
    partial class StopWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            Start_bttn = new Button();
            Reset_bttn = new Button();
            Stop_bttn = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Start_bttn
            // 
            Start_bttn.BackgroundImage = (Image)resources.GetObject("Start_bttn.BackgroundImage");
            Start_bttn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Start_bttn.ForeColor = Color.Cyan;
            Start_bttn.Location = new Point(12, 378);
            Start_bttn.Margin = new Padding(3, 4, 3, 4);
            Start_bttn.Name = "Start_bttn";
            Start_bttn.Size = new Size(202, 85);
            Start_bttn.TabIndex = 0;
            Start_bttn.Text = "Start";
            Start_bttn.UseVisualStyleBackColor = true;
            Start_bttn.Click += Start_bttn_Click;
            // 
            // Reset_bttn
            // 
            Reset_bttn.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Reset_bttn.Location = new Point(549, 378);
            Reset_bttn.Margin = new Padding(3, 4, 3, 4);
            Reset_bttn.Name = "Reset_bttn";
            Reset_bttn.Size = new Size(198, 85);
            Reset_bttn.TabIndex = 1;
            Reset_bttn.Text = "Reset";
            Reset_bttn.UseVisualStyleBackColor = true;
            Reset_bttn.Click += Reset_bttn_Click;
            // 
            // Stop_bttn
            // 
            Stop_bttn.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Stop_bttn.Location = new Point(267, 378);
            Stop_bttn.Margin = new Padding(3, 4, 3, 4);
            Stop_bttn.Name = "Stop_bttn";
            Stop_bttn.Size = new Size(232, 85);
            Stop_bttn.TabIndex = 2;
            Stop_bttn.Text = "Stop";
            Stop_bttn.UseVisualStyleBackColor = true;
            Stop_bttn.Click += Stop_bttn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 90F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(770, 199);
            label1.TabIndex = 3;
            label1.Text = "00:00.00";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(811, 600);
            Controls.Add(label1);
            Controls.Add(Stop_bttn);
            Controls.Add(Reset_bttn);
            Controls.Add(Start_bttn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StopWatch";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void Stop_bttn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button Start_bttn;
        private Button Reset_bttn;
        private Button Stop_bttn;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}