﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr13_sakharov.DBCon;

namespace pr13_sakharov
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (int i in MainForm.JuriList)
            {
                User user = DBConst.model.User.Find(i);
                UserControlJuri userControlJuri = new UserControlJuri();
                userControlJuri.Fill(user, number);
                flowLayoutPanel1.Controls.Add(userControlJuri);
                number++;
            }
        }
    }
}
