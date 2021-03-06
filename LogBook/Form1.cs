﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class Form1 : Form
    {
        public List<UserControl2> userlist { get; set; }
        Controller controller = new Controller();

        static public int DiamondCount { get; set; }
        static public bool IsCreated { get; set; }
        public Form1()
        {
            DiamondCount = 5;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl2 userControl = new UserControl2();
            userControl.Location = new Point(30, 75);
            userControl.FullName = "Camalzade_Elvin";
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
            userlist = new List<UserControl2>();
            userlist.Add(userControl); userlist.Add(userControl2); userlist.Add(userControl3);
            userlist.Add(userControl4); userlist.Add(userControl5); userlist.Add(userControl6);
            userlist.Add(userControl7);
            int i = 0;
            foreach (var item in userlist)
            {
                item.DiamondClicked += Okay;
                item.IsAbsent = true;
                item.Number = (++i).ToString();
                item.Diamond1.Image = Properties.Resources.DiamondGray;
                item.Diamond1.SizeMode = PictureBoxSizeMode.StretchImage;
                item.Diamond2.Image = Properties.Resources.DiamondGray;
                item.Diamond2.SizeMode = PictureBoxSizeMode.StretchImage;
                item.Diamond3.Image = Properties.Resources.DiamondGray;
                item.Diamond3.SizeMode = PictureBoxSizeMode.StretchImage;
                item.PictureX.Image = Properties.Resources.XimageGray;
                item.PictureX.SizeMode = PictureBoxSizeMode.StretchImage;
                item.CommentPicture.Image = Properties.Resources.comment;
                item.CommentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                item.Enabled = false;
            }
            metroNoteAll.Enabled = false;
            textBContent.Enabled = false;
            pictureResetContent.Enabled = false;
            metroRBSubTeacher.Enabled = true;
            metroRBTeacher.Enabled = true;
            pictureResetContent.Image = Properties.Resources.pen;
            pictureResetContent.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebCountDiamond.Image = Properties.Resources.BackBlueDiamond;//I have to replace by another png icon
            picturebCountDiamond.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.AddRange(userlist.ToArray());
        }

        private void Okay(object sender, EventArgs e)
        {
            labelCountDiamond.Text = Form1.DiamondCount.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Image = Properties.Resources.DiamondBlue;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void metroNoteAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in userlist)
            {
                item.IsTakePart = true;
            }
        }
        public bool CheckAccess { get; set; }
        private void metroRBTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAccess)
            {
                metroNoteAll.Enabled = true;
                textBContent.Enabled = true;
                pictureResetContent.Enabled = true;
                foreach (var item in userlist)
                {
                    item.Enabled = true;
                    item._Combobox1.Enabled = false;
                    item._Combobox2.Enabled = false;
                    item.PictureX.Enabled = false;
                    item.CommentPicture.Enabled = false;
                    item.Diamond1.Enabled = false;
                    item.Diamond2.Enabled = false;
                    item.Diamond3.Enabled = false;
                }
            }
            CheckAccess = true;
        }
        public bool IsWritedToContent { get; set; }
        private void pictureResetContent_Click(object sender, EventArgs e)
        {

            if (IsWritedToContent)
            {
                textBContent.Enabled = false;
                IsWritedToContent = false;
            }
            else
            {
                textBContent.Enabled = true;
            }

        }

        private void textBContent_Enter(object sender, EventArgs e)
        {
            IsWritedToContent = true;
        }

        private void picturebCountDiamond_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //controller.LessonContent = textBContent.Text;//to write file must take place in X button . . .
            //controller.UserList = new List<User>();
            //picturebCountDiamond.Enabled = false;//temporary
            //for (int i = 0; i < userlist.Count; i++)
            //{
            //    var item = new User();
            //    controller.UserList.Add(item);
            //    controller.UserList[i].FullName = userlist[i].FullName;
            //    controller.UserList[i].AccessDate = DateTime.Now;
            //    controller.UserList[i].IsTakePartIn = userlist[i].IsTakePart;
            //    controller.UserList[i].IsLate = userlist[i].IsLate;
            //    controller.UserList[i].IsAbsent = userlist[i].IsAbsent;
            //    controller.UserList[i].CheckPoint = userlist[i]._Combobox1.SelectedIndex + 1;
            //    controller.UserList[i].ClassPoint = userlist[i]._Combobox2.SelectedIndex + 1;
            //    controller.UserList[i].DiamondCount = userlist[i].UserDiamondCount;
            //    controller.UserList[i].Comment = userlist[i].Comment.Text;
            //}
            //Guid guid = Guid.NewGuid();
            //var result = JsonConvert.SerializeObject(controller);
            //File.WriteAllText(guid.ToString() + ".json", result);
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelCountDiamond.Text = Form1.DiamondCount.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            labelCountDiamond.Text = Form1.DiamondCount.ToString();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
