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
            Start_bttn = new Button();
            Reset_bttn = new Button();
            Stop_bttn = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // Start_bttn
            // 
            Start_bttn.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Start_bttn.ForeColor = Color.Black;
            Start_bttn.Location = new Point(1, 378);
            Start_bttn.Margin = new Padding(3, 4, 3, 4);
            Start_bttn.Name = "Start_bttn";
            Start_bttn.Size = new Size(249, 85);
            Start_bttn.TabIndex = 0;
            Start_bttn.Text = "Start";
            Start_bttn.UseVisualStyleBackColor = true;
            Start_bttn.Click += Start_bttn_Click;
            // 
            // Reset_bttn
            // 
            Reset_bttn.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Reset_bttn.Location = new Point(551, 378);
            Reset_bttn.Margin = new Padding(3, 4, 3, 4);
            Reset_bttn.Name = "Reset_bttn";
            Reset_bttn.Size = new Size(258, 85);
            Reset_bttn.TabIndex = 1;
            Reset_bttn.Text = "Reset";
            Reset_bttn.UseVisualStyleBackColor = true;
            Reset_bttn.Click += Reset_bttn_Click;
            // 
            // Stop_bttn
            // 
            Stop_bttn.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Stop_bttn.Location = new Point(256, 378);
            Stop_bttn.Margin = new Padding(3, 4, 3, 4);
            Stop_bttn.Name = "Stop_bttn";
            Stop_bttn.Size = new Size(289, 85);
            Stop_bttn.TabIndex = 2;
            Stop_bttn.Text = "Stop";
            Stop_bttn.UseVisualStyleBackColor = true;
            Stop_bttn.Click += Stop_bttn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.SpringGreen;
            label1.Font = new Font("Felix Titling", 90F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(770, 164);
            label1.TabIndex = 3;
            label1.Text = "00:00.00";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Felix Titling", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 9);
            label2.Name = "label2";
            label2.Size = new Size(236, 58);
            label2.TabIndex = 4;
            label2.Text = "Stopwatch.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(811, 600);
            Controls.Add(label2);
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
        private Label label2;
    }
}