﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Coffee_Shop_Management_System.Views
{
    public partial class WelcomeScreen : UserControl
    {
        public WelcomeScreen(string Name)
        {
            InitializeComponent();
            this.Name = Name;
        }
    }
}
