﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiddyLock.UI.Logic;

namespace KiddyLock.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var osUsers = UserLogic.GetOsUsers();
            var users = await UserLogic.GetUsers();
            // do stuff
            foreach (var user in osUsers)
            {
                
            }
        }
    }
}
