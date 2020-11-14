using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementacionState.Clases;



namespace ImplementacionState.UIs
{
    public partial class PantallaFinalizarPreparacionPedido : Form
    {
        Clases.GestorFinalizarPreparacionPedido gestorFinalizar = new Clases.GestorFinalizarPreparacionPedido();
        
        public PantallaFinalizarPreparacionPedido()
        {
            InitializeComponent();
        }



        private void PantallaFinalizarPreparacionPedido_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            gestorFinalizar.finalizarPedido(this);

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void cargar(List<List<string>> infoDetalles)
        {
            
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "seleccionar";
            dgvCmb.HeaderText = "Seleccionar";
            dgvDetalles.Columns.Add("ID","ID"); 
            dgvDetalles.Columns.Add("Prod/Menu", "Prod/Menu"); 
            dgvDetalles.Columns.Add("Cantidad", "Cantidad"); 
            dgvDetalles.Columns.Add("Mesa", "Mesa");
            dgvDetalles.Columns.Add("Mozo", "Mozo");
            dgvDetalles.Columns.Add(dgvCmb);
            int max = infoDetalles.Count();
            for (int i = 0; i < max; i++)
            {
                dgvDetalles.Rows.Add(new object[] { infoDetalles[i][0], infoDetalles[i][1], infoDetalles[i][2], infoDetalles[i][3], infoDetalles[i][4] });
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ConfirmarDetalles c = new ConfirmarDetalles();
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                List<int> listaIds = new List<int>();
                var checkedRows = from DataGridViewRow r in dgvDetalles.Rows
                                  where Convert.ToBoolean(r.Cells[5].Value) == true
                                  select r;
                if (checkedRows.Count() != 0)
                {
                    foreach (var row in checkedRows)
                    {
                        listaIds.Add(int.Parse(row.Cells["ID"].Value.ToString()));
                        
                    }
                    gestorFinalizar.finalizarPreparacion(listaIds);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos un item de la lista", "Error de Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
