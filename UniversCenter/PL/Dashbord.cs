﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversCenter.PL
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Eleves_From frmEl = new Eleves_From();
            frmEl.TopLevel = false;
            pnL_Container.Controls.Add(frmEl);
            frmEl.BringToFront();
            frmEl.Show();
        }
    }
}
