namespace Lab001
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblRemainingTime2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Cyan;
            this.btnClick.Location = new System.Drawing.Point(295, 76);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(141, 94);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.Location = new System.Drawing.Point(198, 279);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(188, 25);
            this.lblRemainingTime.TabIndex = 1;
            this.lblRemainingTime.Text = "RemainingTime :";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Location = new System.Drawing.Point(-8, 410);
            this.progressBarTimer.Name = "progressBarTimer";
            this.progressBarTimer.Size = new System.Drawing.Size(815, 49);
            this.progressBarTimer.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblRemainingTime2
            // 
            this.lblRemainingTime2.AutoSize = true;
            this.lblRemainingTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime2.ForeColor = System.Drawing.Color.Red;
            this.lblRemainingTime2.Location = new System.Drawing.Point(431, 279);
            this.lblRemainingTime2.Name = "lblRemainingTime2";
            this.lblRemainingTime2.Size = new System.Drawing.Size(38, 25);
            this.lblRemainingTime2.TabIndex = 3;
            this.lblRemainingTime2.Text = "60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRemainingTime2);
            this.Controls.Add(this.progressBarTimer);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.ProgressBar progressBarTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblRemainingTime2;
    }
}

