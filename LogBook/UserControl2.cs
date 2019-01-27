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
        public Label NameLabel { get { return labelFullName; } set { labelFullName = value; } }
        public Label TimeLabel { get { return labelTime; } set { labelTime = value; } }
        public MetroFramework.Controls.MetroRadioButton metroRadio1 { get { return metroRb1; } set { metroRb1 = value; } }
        public MetroFramework.Controls.MetroRadioButton metroRadio2 { get { return metroRb2; } set { metroRb2 = value; } }
        public MetroFramework.Controls.MetroRadioButton metroRadio3 { get { return metroRb3; } set { metroRb3 = value; } }
        public PictureBox Diamond1 { get { return pictureDiamond1; } set { pictureDiamond1 = value; } }
        public PictureBox Diamond2 { get { return pictureDiamond2; } set { pictureDiamond2 = value; } }
        public PictureBox Diamond3 { get { return pictureDiamond3; } set { pictureDiamond3 = value; } }
        public PictureBox PictureX { get { return pictureX; } set { pictureX = value; } }
        public MetroFramework.Controls.MetroComboBox _Combobox1 { get { return metroCBClass; } set { metroCBClass = value; } }
        public MetroFramework.Controls.MetroComboBox _Combobox2 { get { return metroCBChecking; } set { metroCBChecking = value; } }
        public PictureBox CommentPicture { get { return pictureBComment; } set { pictureBComment = value; } }
        public TextBox Comment { get { return textBoxComment; } set { textBoxComment = value; } }
        public int CountDiamond { get; set; }
        public int AllDiamondCount { get; set; }
        public UserControl2(int count)
        {
            InitializeComponent();
            CountDiamond = count;
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            object[] numbers = new object[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            metroCBClass.Items.AddRange(numbers);
            metroCBChecking.Items.AddRange(numbers);
        }
        private void metroCBYoxlama_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void pictureDiamond1_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount <= 5 && Form1.DiamondCount >= 1)
            {
                if (!IsClickedDiamond1)
                {
                    Form1.DiamondCount -= 1;
                }

                Diamond1.Image = Properties.Resources.DiamondBlue;
                Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
                IsClickedDiamond1 = true;
            }

        }
        private void pictureDiamond3_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount <= 5 && Form1.DiamondCount >= 1)
            {
                if (IsClickedDiamond1 && IsClickedDiamond2)
                {
                    Form1.DiamondCount -= 1;
                }
                else if (IsClickedDiamond1)
                {
                    Form1.DiamondCount -= 2;
                }
                else
                {
                    Form1.DiamondCount -= 3;
                }//userin diamond countuna yaz bu datani
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

        }
        private void pictureDiamond2_Click(object sender, EventArgs e)
        {
            if (Form1.DiamondCount <= 5 && Form1.DiamondCount >= 1)
            {
                if (IsClickedDiamond1)
                {
                    Form1.DiamondCount -= 1;
                }
                else
                {
                    Form1.DiamondCount -= 2;
                }
                Diamond1.Image = Properties.Resources.DiamondBlue;
                Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
                IsClickedDiamond1 = true;
                Diamond2.Image = Properties.Resources.DiamondBlue;
                Diamond2.SizeMode = PictureBoxSizeMode.StretchImage;
                IsClickedDiamond2 = true;
            }
        }

        private void pictureX_Click(object sender, EventArgs e)
        {
            if (IsClickedDiamond1 && IsClickedDiamond2 && IsClickedDiamond3)
            {
                Form1.DiamondCount += 3;
            }
            else if(IsClickedDiamond1 && IsClickedDiamond2)
            {
                Form1.DiamondCount += 2;
            }
            else if(IsClickedDiamond1)
            {
                Form1.DiamondCount += 1;
            }
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
            Point location = pictureBComment.Location;
            location.X -= 45;
            location.Y += 5;
            textBoxComment.Location = location;
            textBoxComment.Size = new Size(45, 30);
            textBoxComment.Leave += TextBoxComment_Leave;
            textBoxComment.BackColor = Color.FromArgb(227, 246, 255);
            this.Controls.Add(textBoxComment);
        }
        private void TextBoxComment_Leave(object sender, EventArgs e)
        {
            textBoxComment.Size = new Size(0, 0);
        }

        private void metroRb1_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as MetroFramework.Controls.MetroRadioButton;
            if (button.Checked)
            {
                _Combobox1.Enabled = true;
                _Combobox2.Enabled = true;
                Diamond1.Enabled = true;
                Diamond2.Enabled = true;
                Diamond3.Enabled = true;
                PictureX.Enabled = true;
                CommentPicture.Enabled = true;
            }

        }

        private void metroRb3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRb3.Checked)
            {
                _Combobox1.Enabled = false;
                _Combobox2.Enabled = false;
                _Combobox1.SelectedItem = null;
                _Combobox2.SelectedItem = null;
                Diamond1.Enabled = false;
                Diamond2.Enabled = false;
                Diamond3.Enabled = false;
                PictureX.Enabled = false;//you have to decrease diamonds counts
                CommentPicture.Enabled = false;
            }
        }
    }
}
