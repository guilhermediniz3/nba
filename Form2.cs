﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            this.Hide(); 
            newForm3.ShowDialog();
        }

        

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos newjogos = new Jogos();
            this.Hide(); 
            newjogos.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Usuariocs newUsuariocs = new Usuariocs();
           // this.Hide(); // use dessa maneira.
           // newUsuariocs.ShowDialog();



            Usuariocs newMDIChild = new Usuariocs();
            // form filho
            newMDIChild.MdiParent = this;
            
            newMDIChild.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

           System.Threading.Thread.CurrentThread.Abort();

        this.Close();
          
        }
    }
}
