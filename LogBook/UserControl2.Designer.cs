namespace LogBook
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroCBYoxlama = new MetroFramework.Controls.MetroComboBox();
            this.metroCBSinif = new MetroFramework.Controls.MetroComboBox();
            this.metroRb3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRb1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRb2 = new MetroFramework.Controls.MetroRadioButton();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.pictureX = new System.Windows.Forms.PictureBox();
            this.pictureDiamond3 = new System.Windows.Forms.PictureBox();
            this.pictureDiamond2 = new System.Windows.Forms.PictureBox();
            this.pictureDiamond1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCBYoxlama
            // 
            this.metroCBYoxlama.FormattingEnabled = true;
            this.metroCBYoxlama.ItemHeight = 23;
            this.metroCBYoxlama.Location = new System.Drawing.Point(797, 81);
            this.metroCBYoxlama.Name = "metroCBYoxlama";
            this.metroCBYoxlama.Size = new System.Drawing.Size(78, 29);
            this.metroCBYoxlama.TabIndex = 15;
            this.metroCBYoxlama.SelectedIndexChanged += new System.EventHandler(this.metroCBYoxlama_SelectedIndexChanged);
            // 
            // metroCBSinif
            // 
            this.metroCBSinif.FormattingEnabled = true;
            this.metroCBSinif.ItemHeight = 23;
            this.metroCBSinif.Location = new System.Drawing.Point(934, 81);
            this.metroCBSinif.Name = "metroCBSinif";
            this.metroCBSinif.Size = new System.Drawing.Size(78, 29);
            this.metroCBSinif.TabIndex = 14;
            // 
            // metroRb3
            // 
            this.metroRb3.Location = new System.Drawing.Point(547, 86);
            this.metroRb3.Name = "metroRb3";
            this.metroRb3.Size = new System.Drawing.Size(17, 24);
            this.metroRb3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroRb3.TabIndex = 20;
            this.metroRb3.TabStop = true;
            this.metroRb3.Text = "metroRadioButton3";
            this.metroRb3.UseVisualStyleBackColor = true;
            // 
            // metroRb1
            // 
            this.metroRb1.Location = new System.Drawing.Point(475, 86);
            this.metroRb1.Name = "metroRb1";
            this.metroRb1.Size = new System.Drawing.Size(17, 24);
            this.metroRb1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroRb1.TabIndex = 22;
            this.metroRb1.TabStop = true;
            this.metroRb1.Text = "metroRadioButton3";
            this.metroRb1.UseStyleColors = true;
            this.metroRb1.UseVisualStyleBackColor = true;
            // 
            // metroRb2
            // 
            this.metroRb2.Location = new System.Drawing.Point(511, 86);
            this.metroRb2.Name = "metroRb2";
            this.metroRb2.Size = new System.Drawing.Size(17, 24);
            this.metroRb2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroRb2.TabIndex = 21;
            this.metroRb2.TabStop = true;
            this.metroRb2.Text = "metroRadioButton3";
            this.metroRb2.UseStyleColors = true;
            this.metroRb2.UseVisualStyleBackColor = true;
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(32, 87);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(182, 29);
            this.labelFullName.TabIndex = 23;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(275, 88);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "label1";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(3, 87);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(15, 16);
            this.labelNumber.TabIndex = 25;
            this.labelNumber.Text = "1";
            // 
            // pictureX
            // 
            this.pictureX.Image = global::LogBook.Properties.Resources.XimageGray;
            this.pictureX.Location = new System.Drawing.Point(1210, 81);
            this.pictureX.Name = "pictureX";
            this.pictureX.Size = new System.Drawing.Size(32, 29);
            this.pictureX.TabIndex = 16;
            this.pictureX.TabStop = false;
            this.pictureX.Click += new System.EventHandler(this.pictureX_Click);
            this.pictureX.MouseEnter += new System.EventHandler(this.pictureX_MouseEnter);
            this.pictureX.MouseLeave += new System.EventHandler(this.pictureX_MouseLeave);
            // 
            // pictureDiamond3
            // 
            this.pictureDiamond3.Image = global::LogBook.Properties.Resources.diamond;
            this.pictureDiamond3.Location = new System.Drawing.Point(1172, 81);
            this.pictureDiamond3.Name = "pictureDiamond3";
            this.pictureDiamond3.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond3.TabIndex = 17;
            this.pictureDiamond3.TabStop = false;
            this.pictureDiamond3.Click += new System.EventHandler(this.pictureDiamond3_Click);
            // 
            // pictureDiamond2
            // 
            this.pictureDiamond2.Image = global::LogBook.Properties.Resources.diamond;
            this.pictureDiamond2.Location = new System.Drawing.Point(1131, 81);
            this.pictureDiamond2.Name = "pictureDiamond2";
            this.pictureDiamond2.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond2.TabIndex = 18;
            this.pictureDiamond2.TabStop = false;
            this.pictureDiamond2.Click += new System.EventHandler(this.pictureDiamond2_Click);
            // 
            // pictureDiamond1
            // 
            this.pictureDiamond1.Image = global::LogBook.Properties.Resources.DiamondGray;
            this.pictureDiamond1.Location = new System.Drawing.Point(1091, 81);
            this.pictureDiamond1.Name = "pictureDiamond1";
            this.pictureDiamond1.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond1.TabIndex = 19;
            this.pictureDiamond1.TabStop = false;
            this.pictureDiamond1.Click += new System.EventHandler(this.pictureDiamond1_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.metroRb3);
            this.Controls.Add(this.metroRb2);
            this.Controls.Add(this.metroRb1);
            this.Controls.Add(this.pictureX);
            this.Controls.Add(this.pictureDiamond3);
            this.Controls.Add(this.pictureDiamond2);
            this.Controls.Add(this.pictureDiamond1);
            this.Controls.Add(this.metroCBSinif);
            this.Controls.Add(this.metroCBYoxlama);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1349, 133);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDiamond3;
        private MetroFramework.Controls.MetroComboBox metroCBYoxlama;
        private MetroFramework.Controls.MetroComboBox metroCBSinif;
        private System.Windows.Forms.PictureBox pictureDiamond1;
        private System.Windows.Forms.PictureBox pictureDiamond2;
        private MetroFramework.Controls.MetroRadioButton metroRb3;
        private System.Windows.Forms.PictureBox pictureX;
        private MetroFramework.Controls.MetroRadioButton metroRb1;
        private MetroFramework.Controls.MetroRadioButton metroRb2;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNumber;
    }
}
