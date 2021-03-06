﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_solitaire.src
{
    public partial class Menu : Form
    {
        Game game;
        Help help;

        public Menu()
        {
            InitializeComponent();

            game = new Game(this);
            help = new Help(this);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help.Show();
            this.Hide();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }
    }
}
