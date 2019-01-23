using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            object[] numbers = new object[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            metroCBSinif.Items.AddRange(numbers);
            metroCBYoxlama.Items.AddRange(numbers);
            ///diamond
            pictureDiamond1.Image = Properties.Resources.DiamondGray;            
            pictureDiamond1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDiamond2.Image = Properties.Resources.DiamondGray;
            pictureDiamond2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDiamond3.Image = Properties.Resources.DiamondGray;
            pictureDiamond3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureComment.Image = Properties.Resources.comment;
            pictureComment.SizeMode = PictureBoxSizeMode.StretchImage;
            metroRB4.Checked = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl2 userControl = new UserControl2();
            userControl.Name_ = "Elvinnnn shsdhs0";
            userControl.Top = 300;
            userControl.Left = 10;
            UserControl2 userControl2 = new UserControl2();
            userControl2.Name_ = "Elvrfrefers0";
            userControl2.Top = 340;
            userControl2.Left = 10;
            Controls.Add(userControl); Controls.Add(userControl2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Image = Properties.Resources.DiamondBlue;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void metroCBYoxlama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
