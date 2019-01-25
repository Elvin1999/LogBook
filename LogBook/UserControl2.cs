using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LogBook
{
    public partial class UserControl2 : UserControl
    {
        public string FullName { get { return labelFullName.Text; } set { labelFullName.Text = value; } }
        public string Accesstime { get { return labelTime.Text; } set { labelTime.Text = value; } }
        public bool IsTakePart { get => metroRb1.Checked; set { metroRb1.Checked = value; } }
        public bool IsLate { get => metroRb2.Checked; set { metroRb2.Checked = value; } }
        public bool IsAbsent { get => metroRb3.Checked; set { metroRb3.Checked = value; } }
        public string Number { get { return labelNumber.Text; } set { labelNumber.Text = value; } }
        public bool IsClickedDiamond1 { get; set; }
        public bool IsClickedDiamond2 { get; set; }
        public bool IsClickedDiamond3 { get; set; }
        public PictureBox Diamond1 { get { return pictureDiamond1; } set { pictureDiamond1 = value; } }
        public PictureBox Diamond2 { get { return pictureDiamond2; } set { pictureDiamond2 = value; } }
        public PictureBox Diamond3 { get { return pictureDiamond3; } set { pictureDiamond3 = value; } }
        public PictureBox PictureX { get { return pictureX; } set { pictureX = value; } }
        public PictureBox CommentPicture { get { return pictureBComment; } set { pictureBComment = value; } }
        private int DiamondCount;
        public UserControl2()
        {
            InitializeComponent();
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            object[] numbers = new object[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            metroCBSinif.Items.AddRange(numbers);
            metroCBYoxlama.Items.AddRange(numbers);
        }

        private void metroCBYoxlama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureDiamond1_Click(object sender, EventArgs e)
        {
            Diamond1.Image = Properties.Resources.DiamondBlue;
            Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
      
                IsClickedDiamond1 = true;
            
        }
        private void pictureDiamond3_Click(object sender, EventArgs e)
        {
            Diamond1.Image = Properties.Resources.DiamondBlue;
            Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond1 = true;
            Diamond2.Image = Properties.Resources.DiamondBlue;
            Diamond2.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond2 = true;
            Diamond3.Image = Properties.Resources.DiamondBlue;
            Diamond3.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond3 = true;
        }
        private void pictureDiamond2_Click(object sender, EventArgs e)
        {
            Diamond1.Image = Properties.Resources.DiamondBlue;
            Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond1 = true;
            Diamond2.Image = Properties.Resources.DiamondBlue;
            Diamond2.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond2 = true;
        }

        private void pictureX_Click(object sender, EventArgs e)
        {

            Diamond1.Image = Properties.Resources.DiamondGray;
            Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond1 = false;
            Diamond2.Image = Properties.Resources.DiamondGray;
            Diamond2.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond2 = false;
            Diamond3.Image = Properties.Resources.DiamondGray;
            Diamond3.SizeMode = PictureBoxSizeMode.StretchImage;
            IsClickedDiamond3 = false;

        }

        private void pictureX_MouseEnter(object sender, EventArgs e)
        {
            pictureX.Image = Properties.Resources.Ximage;
            pictureX.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureX_MouseLeave(object sender, EventArgs e)
        {
            pictureX.Image = Properties.Resources.XimageGray;
            pictureX.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureComment_Click(object sender, EventArgs e)
        {

        }
    }
}
