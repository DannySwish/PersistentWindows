﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninjacrab.PersistentWindows.Common
{
    public partial class LayoutProfile : Form
    {
        public char snapshot_name;

        public LayoutProfile()
        {
            InitializeComponent();
        }

        private void ProfileName_TextChanged(object sender, EventArgs e)
        {
            var str = ((TextBox)sender).Text;
            snapshot_name = Char.ToLower(str[0]); 
            Close();
        }


        private void LayoutProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
