using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbreteSesamo
{
    public partial class frmInicio : Form
    {
        private List<Item> itemsCargados = new List<Item>();
        private Factura factura = null;

        public frmInicio()
        {
            InitializeComponent();
            this.factura = new Factura();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;");
            DataTable dt = accesoDatos.llenarListas("0");

            // Con este For llena la lista lstActividades con los items (categoria 0)
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                DataRow row = dt.Rows[i];
                Item item = new Item();
                item.precio = row.Field<int>("Precio");
                item.id = row.Field<int>("ID_Item");
                item.nombre = row.Field<string>("");

                itemsCargados.Add(item);




            }

            eventoVerificarListas(sender, e);

        }

        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstFactura.Items.Add(lstActividades.SelectedItem + " x" + (txtCantidad.Text));
            eventoVerificarListas(sender, e);
        }

        //BOTON QUITAR
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            lstFactura.Items.Remove(lstFactura.SelectedItem);
            eventoVerificarListas(sender, e);
        }

        //EVENTO VERIFICAR LISTAS
        // segundear este evento en los event_click
        private void eventoVerificarListas(object sender, EventArgs e)
        {
            txtCantidad.Text = "1";
            lstActividades.SelectedIndex = 0;

            if (lstFactura.Items != null)
            {
                btnQuitar.Enabled = true;
                btnQuitarTodo.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
                btnQuitarTodo.Enabled = false;
            }


        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            lstFactura.Items.Clear();
        }
    }
}
