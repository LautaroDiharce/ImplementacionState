using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ImplementacionState.UIs
{
    public partial class VisualListoParaSevir : Form
    {
        public VisualListoParaSevir()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void visualizarNotificacion(List<List<string>> datosVisuaizacionNotificado)
        {
            dgvNotificacion.Columns.Add("Mesa", "Mesa");
            dgvNotificacion.Columns.Add("Producto/Menu", "Producto/Menu");
            dgvNotificacion.Columns.Add("Cantidad", "Cantidad");
            int max = datosVisuaizacionNotificado.Count();
            for (int i = 0; i < max; i++)
            {
                dgvNotificacion.Rows.Add(new object[] { datosVisuaizacionNotificado[i][0], datosVisuaizacionNotificado[i][1], datosVisuaizacionNotificado[i][2]});
            }
        }

        private void VisualListoParaSevir_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            playSimpleSound();
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\lauta\OneDrive\Desktop\UTN\DSI\2020\PPAI\VS-implementacion\ImplementacionState\ImplementacionState\ImplementacionState\Resources\OOF.wav");
            simpleSound.Play();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
