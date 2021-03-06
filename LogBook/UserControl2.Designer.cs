﻿namespace LogBook
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
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroRb1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRb2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRb3 = new MetroFramework.Controls.MetroRadioButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.metroCBClass = new MetroFramework.Controls.MetroComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.metroCBChecking = new MetroFramework.Controls.MetroComboBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pictureBComment = new System.Windows.Forms.PictureBox();
            this.pictureX = new System.Windows.Forms.PictureBox();
            this.pictureDiamond1 = new System.Windows.Forms.PictureBox();
            this.pictureDiamond2 = new System.Windows.Forms.PictureBox();
            this.pictureDiamond3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(200, 200);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(0, 20);
            this.textBoxComment.TabIndex = 26;
            // 
            // metroRb1
            // 
            this.metroRb1.Location = new System.Drawing.Point(477, 82);
            this.metroRb1.Name = "metroRb1";
            this.metroRb1.Size = new System.Drawing.Size(17, 24);
            this.metroRb1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroRb1.TabIndex = 22;
            this.metroRb1.TabStop = true;
            this.metroRb1.Text = "metroRadioButton3";
            this.metroRb1.UseStyleColors = true;
            this.metroRb1.UseVisualStyleBackColor = true;
            this.metroRb1.CheckedChanged += new System.EventHandler(this.metroRb1_CheckedChanged);
            // 
            // metroRb2
            // 
            this.metroRb2.Location = new System.Drawing.Point(513, 82);
            this.metroRb2.Name = "metroRb2";
            this.metroRb2.Size = new System.Drawing.Size(17, 24);
            this.metroRb2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroRb2.TabIndex = 21;
            this.metroRb2.TabStop = true;
            this.metroRb2.Text = "metroRadioButton3";
            this.metroRb2.UseStyleColors = true;
            this.metroRb2.UseVisualStyleBackColor = true;
            this.metroRb2.CheckedChanged += new System.EventHandler(this.metroRb1_CheckedChanged);
            // 
            // metroRb3
            // 
            this.metroRb3.Location = new System.Drawing.Point(549, 82);
            this.metroRb3.Name = "metroRb3";
            this.metroRb3.Size = new System.Drawing.Size(17, 24);
            this.metroRb3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroRb3.TabIndex = 20;
            this.metroRb3.TabStop = true;
            this.metroRb3.Text = "metroRadioButton3";
            this.metroRb3.UseVisualStyleBackColor = true;
            this.metroRb3.CheckedChanged += new System.EventHandler(this.metroRb3_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(277, 84);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "label1";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // metroCBClass
            // 
            this.metroCBClass.FormattingEnabled = true;
            this.metroCBClass.ItemHeight = 23;
            this.metroCBClass.Location = new System.Drawing.Point(914, 78);
            this.metroCBClass.Name = "metroCBClass";
            this.metroCBClass.Size = new System.Drawing.Size(78, 29);
            this.metroCBClass.TabIndex = 14;
            this.metroCBClass.SelectedIndexChanged += new System.EventHandler(this.metroCBClass_SelectedIndexChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(5, 83);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(15, 16);
            this.labelNumber.TabIndex = 25;
            this.labelNumber.Text = "1";
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // metroCBChecking
            // 
            this.metroCBChecking.FormattingEnabled = true;
            this.metroCBChecking.ItemHeight = 23;
            this.metroCBChecking.Location = new System.Drawing.Point(777, 78);
            this.metroCBChecking.Name = "metroCBChecking";
            this.metroCBChecking.Size = new System.Drawing.Size(78, 29);
            this.metroCBChecking.TabIndex = 15;
            this.metroCBChecking.SelectedIndexChanged += new System.EventHandler(this.metroCBChecking_SelectedIndexChanged);
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(34, 83);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(182, 29);
            this.labelFullName.TabIndex = 23;
            this.labelFullName.Click += new System.EventHandler(this.labelFullName_Click);
            // 
            // pictureBComment
            // 
            this.pictureBComment.Image = global::LogBook.Properties.Resources.comment1;
            this.pictureBComment.Location = new System.Drawing.Point(1274, 78);
            this.pictureBComment.Name = "pictureBComment";
            this.pictureBComment.Size = new System.Drawing.Size(32, 29);
            this.pictureBComment.TabIndex = 16;
            this.pictureBComment.TabStop = false;
            this.pictureBComment.Click += new System.EventHandler(this.pictureComment_Click);
            // 
            // pictureX
            // 
            this.pictureX.Image = global::LogBook.Properties.Resources.XimageGray;
            this.pictureX.Location = new System.Drawing.Point(1184, 78);
            this.pictureX.Name = "pictureX";
            this.pictureX.Size = new System.Drawing.Size(32, 29);
            this.pictureX.TabIndex = 16;
            this.pictureX.TabStop = false;
            this.pictureX.Click += new System.EventHandler(this.pictureX_Click);
            this.pictureX.MouseEnter += new System.EventHandler(this.pictureX_MouseEnter);
            this.pictureX.MouseLeave += new System.EventHandler(this.pictureX_MouseLeave);
            // 
            // pictureDiamond1
            // 
            this.pictureDiamond1.Image = global::LogBook.Properties.Resources.DiamondGray;
            this.pictureDiamond1.Location = new System.Drawing.Point(1065, 78);
            this.pictureDiamond1.Name = "pictureDiamond1";
            this.pictureDiamond1.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond1.TabIndex = 19;
            this.pictureDiamond1.TabStop = false;
            this.pictureDiamond1.Click += new System.EventHandler(this.pictureDiamond1_Click);
            // 
            // pictureDiamond2
            // 
            this.pictureDiamond2.Image = global::LogBook.Properties.Resources.diamond;
            this.pictureDiamond2.Location = new System.Drawing.Point(1105, 78);
            this.pictureDiamond2.Name = "pictureDiamond2";
            this.pictureDiamond2.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond2.TabIndex = 18;
            this.pictureDiamond2.TabStop = false;
            this.pictureDiamond2.Click += new System.EventHandler(this.pictureDiamond2_Click);
            // 
            // pictureDiamond3
            // 
            this.pictureDiamond3.Image = global::LogBook.Properties.Resources.diamond;
            this.pictureDiamond3.Location = new System.Drawing.Point(1146, 78);
            this.pictureDiamond3.Name = "pictureDiamond3";
            this.pictureDiamond3.Size = new System.Drawing.Size(32, 29);
            this.pictureDiamond3.TabIndex = 17;
            this.pictureDiamond3.TabStop = false;
            this.pictureDiamond3.Click += new System.EventHandler(this.pictureDiamond3_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.metroCBChecking);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.pictureBComment);
            this.Controls.Add(this.metroCBClass);
            this.Controls.Add(this.metroRb1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureX);
            this.Controls.Add(this.pictureDiamond1);
            this.Controls.Add(this.metroRb2);
            this.Controls.Add(this.pictureDiamond2);
            this.Controls.Add(this.pictureDiamond3);
            this.Controls.Add(this.metroRb3);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1349, 133);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiamond3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxComment;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBComment;
        private MetroFramework.Controls.MetroRadioButton metroRb1;
        private System.Windows.Forms.PictureBox pictureX;
        private MetroFramework.Controls.MetroRadioButton metroRb2;
        private System.Windows.Forms.PictureBox pictureDiamond3;
        private MetroFramework.Controls.MetroRadioButton metroRb3;
        private System.Windows.Forms.PictureBox pictureDiamond2;
        private System.Windows.Forms.PictureBox pictureDiamond1;
        private System.Windows.Forms.Label labelTime;
        private MetroFramework.Controls.MetroComboBox metroCBClass;
        private System.Windows.Forms.Label labelNumber;
        private MetroFramework.Controls.MetroComboBox metroCBChecking;
        private System.Windows.Forms.Label labelFullName;
    }
}
