﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redBoxInterface
{
    public partial class redBox : Form
    {
        public redBox()
        {
            InitializeComponent();
            TopMost = true;
            TopLevel = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void RedBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}