﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionState.UIs
{
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {
            this.TopMost = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.WindowState = FormWindowState.Maximized;
            PantallaFinalizarPreparacionPedido pantalla = new PantallaFinalizarPreparacionPedido();
            pantalla.Show();
            this.SendToBack();


        }
    }
}
