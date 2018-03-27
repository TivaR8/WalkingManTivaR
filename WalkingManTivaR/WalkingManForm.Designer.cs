namespace WalkingManTivaR
{
    partial class frmWalkingMan
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
            this.btnWalk = new System.Windows.Forms.Button();
            this.picWalkMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(109, 17);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 0;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picWalkMan
            // 
            this.picWalkMan.Image = global::WalkingManTivaR.Properties.Resources.walk9;
            this.picWalkMan.Location = new System.Drawing.Point(49, 46);
            this.picWalkMan.Name = "picWalkMan";
            this.picWalkMan.Size = new System.Drawing.Size(205, 221);
            this.picWalkMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWalkMan.TabIndex = 1;
            this.picWalkMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 298);
            this.Controls.Add(this.picWalkMan);
            this.Controls.Add(this.btnWalk);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.picWalkMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.PictureBox picWalkMan;
    }
}

