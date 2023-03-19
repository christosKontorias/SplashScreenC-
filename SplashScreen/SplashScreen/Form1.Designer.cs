namespace SplashScreen
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
            progressbar1 = new CircularProgressBar.CircularProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressbar1
            // 
            progressbar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progressbar1.AnimationSpeed = 500;
            progressbar1.BackColor = Color.FromArgb(42, 40, 60);
            progressbar1.Font = new Font("Comic Sans MS", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            progressbar1.ForeColor = Color.Aqua;
            progressbar1.InnerColor = Color.FromArgb(42, 40, 60);
            progressbar1.InnerMargin = 2;
            progressbar1.InnerWidth = -1;
            progressbar1.Location = new Point(50, 114);
            progressbar1.MarqueeAnimationSpeed = 2000;
            progressbar1.Name = "progressbar1";
            progressbar1.OuterColor = Color.FromArgb(26, 28, 43);
            progressbar1.OuterMargin = -25;
            progressbar1.OuterWidth = 26;
            progressbar1.ProgressColor = Color.FromArgb(85, 213, 219);
            progressbar1.ProgressWidth = 6;
            progressbar1.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            progressbar1.Size = new Size(150, 150);
            progressbar1.StartAngle = 270;
            progressbar1.Style = ProgressBarStyle.Continuous;
            progressbar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressbar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressbar1.SubscriptText = "";
            progressbar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressbar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressbar1.SuperscriptText = "";
            progressbar1.TabIndex = 0;
            progressbar1.TextMargin = new Padding(8, 8, 0, 0);
            progressbar1.Value = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(50, 26);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(75, 308);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 1;
            label2.Text = "Loading...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(13, 351);
            label3.Name = "label3";
            label3.Size = new Size(230, 18);
            label3.TabIndex = 1;
            label3.Text = "Copyright © 2023 Christos Kontorias";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 40, 60);
            ClientSize = new Size(255, 378);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressbar1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressbar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}