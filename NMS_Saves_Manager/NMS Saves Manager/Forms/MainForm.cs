﻿using NMS_Saves_Manager.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Saves_Manager.Forms
{
    public partial class MainForm : Form
    {
        private NMSSMManager _NMSSMManager;

        public MainForm()
        {
            InitializeComponent();
            _NMSSMManager = NMSSMManager.Instance;
        }


    }
}
