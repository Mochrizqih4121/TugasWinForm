﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPraktikumPBO
{
    public partial class LoadingScreen1 : Form
    {
        public LoadingScreen1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                new Form1().Show();
                this.Hide();
            }
        }
    }
}
