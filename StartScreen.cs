﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlopyBirdFRB
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            FlopyBirdSetup GameWindow = new FlopyBirdSetup();
            GameWindow.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
