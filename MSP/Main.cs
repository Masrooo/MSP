﻿using MSP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSP.Gui;
namespace MSP
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);

            // Load Home Page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #endregion
    }
}
