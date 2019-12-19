namespace MazeGame
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
            this.finalLevelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finalLevelBtn
            // 
            this.finalLevelBtn.Location = new System.Drawing.Point(357, 224);
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
            this.label1.Location = new System.Drawing.Point(203, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you ready for the final challenge?";
            // 
            // FinalLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}