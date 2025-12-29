using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using sql;


namespace EvaluacionDiscos
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        List<disco> ListaDiscos = new List<disco>();
        private void Ventana1_Load(object sender, EventArgs e)
        {

            discoNegocio carga = new discoNegocio();
            ListaDiscos = carga.Listar();
            dgvdiscos.DataSource = ListaDiscos;
            dgvdiscos.Columns["imagen"].Visible = false;
            cargarimagen(ListaDiscos[0].imagen);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                picboxdiscos.Load(imagen);
            }
            catch(Exception) 
            {
                picboxdiscos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }

        private void dgvdiscos_SelectionChanged(object sender, EventArgs e)
        {
            disco seleccionado = (disco)dgvdiscos.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagen);
        }
    }
}
