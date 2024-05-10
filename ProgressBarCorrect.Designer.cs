namespace GradingSystem
{
    partial class ProgressBarCorrect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBarCorrect));
            this.ProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblLogging = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ProgressBar1.AnimationFunction")));
            this.ProgressBar1.AnimationSpeed = 100;
            this.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ProgressBar1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ProgressBar1.InnerMargin = 2;
            this.ProgressBar1.InnerWidth = -1;
            this.ProgressBar1.Location = new System.Drawing.Point(52, 134);
            this.ProgressBar1.MarqueeAnimationSpeed = 2000;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ProgressBar1.OuterMargin = -25;
            this.ProgressBar1.OuterWidth = 26;
            this.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBar1.ProgressWidth = 6;
            this.ProgressBar1.SecondaryFont = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.ProgressBar1.StartAngle = 270;
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar1.SubscriptText = "";
            this.ProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar1.SuperscriptText = "";
            this.ProgressBar1.TabIndex = 1;
            this.ProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar1.Value = 68;
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.BackColor = System.Drawing.Color.Transparent;
            this.lblLogging.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblLogging.Location = new System.Drawing.Point(81, 97);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(97, 19);
            this.lblLogging.TabIndex = 2;
            this.lblLogging.Text = "Logging in...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblSL.Location = new System.Drawing.Point(41, 303);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(0, 22);
            this.lblSL.TabIndex = 5;
            // 
            // ProgressBarCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblLogging);
            this.Controls.Add(this.ProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarCorrect";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProgressBar1;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSL;
    }
}