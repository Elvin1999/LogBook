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
            //metroCBSinif.Items.AddRange(numbers);
            //metroCBYoxlama.Items.AddRange(numbers);
            /////diamond
            //pictureDiamond1.Image = Properties.Resources.DiamondGray;            
            //pictureDiamond1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureDiamond2.Image = Properties.Resources.DiamondGray;
            //pictureDiamond2.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureDiamond3.Image = Properties.Resources.DiamondGray;
            //pictureDiamond3.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureComment.Image = Properties.Resources.comment;
            //pictureComment.SizeMode = PictureBoxSizeMode.StretchImage;
            //metroRB4.Checked = true;

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
            userControl.Location = new Point(30, 75);
            userControl.FullName = "Camalzade Elvin";
            userControl.Accesstime = "10.10.2018";
            UserControl2 userControl2 = new UserControl2();
            userControl2.Location = new Point(30, 130);
            userControl2.FullName = "Samir Hemzeyev";
            userControl2.Accesstime = "10.10.2018";
            UserControl2 userControl3 = new UserControl2();
            userControl3.Location = new Point(30, 185);
            userControl3.FullName = "Mustafayev Nurullah";
            userControl3.Accesstime = "10.10.2018";
            UserControl2 userControl4 = new UserControl2();
            userControl4.Location = new Point(30, 240);
            userControl4.FullName = "Abdullabayli Saleh";
            userControl4.Accesstime = "10.10.2018";
            UserControl2 userControl5 = new UserControl2();
            userControl5.Location = new Point(30, 295);
            userControl5.FullName = "Mustafayev Tural";
            userControl5.Accesstime = "10.10.2018";
            UserControl2 userControl6 = new UserControl2();
            userControl6.Location = new Point(30, 350);
            userControl6.FullName = "Omarov Islam";
            userControl6.Accesstime = "10.10.2018";
            UserControl2 userControl7 = new UserControl2();
            userControl7.Location = new Point(30, 405);
            userControl7.FullName = "Ahmadov Anar";
            userControl7.Accesstime = "10.10.2018";
            List<UserControl2> userlist = new List<UserControl2>();
            userlist.Add(userControl); userlist.Add(userControl2); userlist.Add(userControl3);
            userlist.Add(userControl4); userlist.Add(userControl5); userlist.Add(userControl6);
            userlist.Add(userControl7);
            int i = 0;
            foreach (var item in userlist)
            {
                item.IsAbsent = true;
                item.Number = (++i).ToString();
            }
            Controls.AddRange(userlist.ToArray());
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
