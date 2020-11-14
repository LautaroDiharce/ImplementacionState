using System;
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
    public partial class ConfirmarDetalles : Form
    {
        public ConfirmarDetalles()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarDetalles_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
