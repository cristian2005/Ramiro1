﻿using Bunifu.Framework.UI;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramiro
{
    public partial class PermisosModulos : Form
    {
        public PermisosModulos()
        {
            InitializeComponent();
        }

        private void PermisosModulos_Load(object sender, EventArgs e)
        {
            Add_check_modulos();
        }

        private void Add_check_modulos()
        {
            BunifuCheckbox check;
            BunifuCustomLabel label;
            var index = 0;
            foreach (string item in Enum.GetNames(typeof(GlobalS.Modulos)))
            {
                index++;
                check = new BunifuCheckbox();
                check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
                check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
                check.Size = new Size(20, 20);
                check.Name = "ck"+index;
                label = new BunifuCustomLabel();
                label.Size = new Size(160, 20);
                
                label.Text = item;
                label.Font = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                this.flowLayoutPanel1.Controls.AddRange(new Control[] { check, label });
            } 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}