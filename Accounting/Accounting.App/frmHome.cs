﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.Mobiles;

namespace Accounting.App
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMobile_Click(object sender, EventArgs e)
        {
            frmMobile frm = new frmMobile();
            frm.ShowDialog();
        }
    }
}
