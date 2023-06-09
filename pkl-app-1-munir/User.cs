﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app_1_munir
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            AcceptButton = this.button;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            output.Text = $"Welcome {nama}!";
        }

        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button.PerformClick();
            }
        }
    }
}
