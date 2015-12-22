using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace AbreteSesamo
{
    public partial class frmInicio : Form
    {
        private BindingList<Item> itemsCargados = new BindingList<Item>();
        private Factura factura;

        private void lstFactura_ListChanged(Object sender, EventArgs e)
        {
            if (this.factura.items.Count() > 0)
            {
                btnQuitar.Enabled = true;
                btnQuitarTodo.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
                btnQuitarTodo.Enabled = false;
            }

            txtMontoTotal.Text = factura.total.ToString();
        }

        public frmInicio()
        {
            InitializeComponent();
            this.factura = new Factura();
            this.factura.items.ListChanged += new ListChangedEventHandler(this.lstFactura_ListChanged);
            lstFactura.DataSource = this.factura.items;
            lstFactura.DisplayMember = "render";
            lstFactura.ValueMember = "id";
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;");
            DataTable dt = accesoDatos.llenarListas("0");

            lstActividades.DataSource = itemsCargados;
            lstActividades.DisplayMember = "nombre";
            lstActividades.ValueMember = "id";

            // Con este For llena la lista lstActividades con los items (categoria 0)
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                DataRow row = dt.Rows[i];
                Item item = new Item();
                item.nombre = row.Field<String>("DES_Item");
                item.precio = row.Field<int>("Precio");
                item.id = row.Field<int>("ID_Item");

                itemsCargados.Add(item);
            }
        }

        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Item item = (Item)lstActividades.SelectedItem;
            item.cantidad = txtCantidad.Text.Length > 0 ? Convert.ToInt32(txtCantidad.Text) : 1;
            txtCantidad.Text = "";
            factura.items.Add(item);
        }

        //BOTON QUITAR
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            factura.items.RemoveAt(lstFactura.SelectedIndex);
        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            factura.items.Clear();
        }
    }
}
