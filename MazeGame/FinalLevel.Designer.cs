﻿namespace MazeGame
{
    partial class FinalLevel
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
            this.finalLevelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // finalLevelBtn
            // 
            this.finalLevelBtn.Location = new System.Drawing.Point(552, 327);
            this.finalLevelBtn.Name = "finalLevelBtn";
            this.finalLevelBtn.Size = new System.Drawing.Size(97, 23);
            this.finalLevelBtn.TabIndex = 0;
            this.finalLevelBtn.Text = "Play Final Level";
            this.finalLevelBtn.UseVisualStyleBackColor = true;
            this.finalLevelBtn.Click += new System.EventHandler(this.FinalLevelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "The more of this there is, the less you see. What is it?";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FinalLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalLevelBtn);
            this.Name = "FinalLevel";
            this.Text = "Final Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finalLevelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}