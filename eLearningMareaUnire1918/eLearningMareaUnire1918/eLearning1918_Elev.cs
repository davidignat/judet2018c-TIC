﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLearningMareaUnire1918
{
    public partial class eLearning1918_Elev : Form
    {
        public eLearning1918_Elev(string email)
        {
            InitializeComponent();
            label1.Text = email;
        }
    }
}
