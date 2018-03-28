namespace Tutorial_5_8
{
    partial class CoinToss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinToss));
            this.headsPicturebox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsPicturebox
            // 
            this.headsPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("headsPicturebox.Image")));
            this.headsPicturebox.Location = new System.Drawing.Point(94, 30);
            this.headsPicturebox.Name = "headsPicturebox";
            this.headsPicturebox.Size = new System.Drawing.Size(170, 170);
            this.headsPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPicturebox.TabIndex = 0;
            this.headsPicturebox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
            this.tailsPictureBox.Location = new System.Drawing.Point(94, 30);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(51, 206);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(102, 46);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "Toss";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(196, 206);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 274);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPicturebox);
            this.Name = "CoinToss";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPicturebox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}

