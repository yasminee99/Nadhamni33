﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class SuccessPers2 : Form
    {
        public SuccessPers2()
        {
            InitializeComponent();
        }

        private void SuccessPers2_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
            Kids k = new Kids();
            k.Show();
            this.Hide();
            PersonalInformation ps = new PersonalInformation();
            ps.Hide();
            
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            btn_OK.Visible = true;

            icon.Enabled = false;
            icon_delay.Stop();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }
    }
}
