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
    public partial class Game : Form
    {
        Form prevForm;

        public Game(Form prevForm)
        {
            InitializeComponent();

            this.prevForm = prevForm;
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}
