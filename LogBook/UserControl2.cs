﻿using System;
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
        public bool IsTakePart { get =>metroRb1.Checked; set { metroRb1.Checked = value; } }
        public bool IsLate { get => metroRb2.Checked; set { metroRb2.Checked = value; } }
        public bool IsAbsent { get => metroRb3.Checked; set { metroRb3.Checked = value; } }
        public string Number { get { return labelNumber.Text; } set { labelNumber.Text = value; } }
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
    }
}
