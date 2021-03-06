﻿using System;
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
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
                btnQuitarTodo.Enabled = false;
                btnConfirmar.Enabled = false;
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
            DataTable dt = accesoDatos.llenarListas();

            this.FormClosing += new FormClosingEventHandler(Form1_OnClosing);


            lstActividades.DataSource = itemsCargados;
            lstActividades.DisplayMember = "nombre";
            lstActividades.ValueMember = "id";

            // Con este For llena la lista lstActividades con los items 
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                DataRow row = dt.Rows[i];
                Item item = new Item();
                item.nombre = row.Field<String>("DES_Item");
                item.id = row.Field<int>("ID_Item");
                item.categoria = row.Field<Categoria>("ID_Categoria");

                if (Convert.IsDBNull(row[2]))
                {
                    item.precio = 0;
                    //MessageBox.Show(row[1].ToString());
                }
                else
                {
                    item.precio = Convert.ToInt32(row[2]);
                }
                itemsCargados.Add(item);
            }
        }

        //EVENTO CERRAR PROGRAMA
        private void Form1_OnClosing(object sender, CancelEventArgs e)
        {
            Boolean cancelar = false;

            if (Application.OpenForms.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Salir de la aplicación?", "Cerrando aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                cancelar = result == DialogResult.No;
            }
            else
            {
                cancelar = true;
            }

            e.Cancel = cancelar;
        }



        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtMonto.ReadOnly == true)
            {
                Item item = (Item)lstActividades.SelectedItem;
                item.cantidad = txtCantidad.Text.Length > 0 ? Convert.ToInt32(txtCantidad.Text) : 1;
                txtCantidad.Text = "";
                factura.items.Add(item);
                itemsCargados.RemoveAt(lstActividades.SelectedIndex);
            }
            else
            {
                if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Complete el campo Monto");
                }
                else
                {
                    Item item = (Item)lstActividades.SelectedItem;
                    item.cantidad = txtCantidad.Text.Length > 0 ? Convert.ToInt32(txtCantidad.Text) : 1;
                    item.precio = Convert.ToInt32(txtMonto.Text);
                    txtCantidad.Text = "";
                    factura.items.Add(item);
                    itemsCargados.RemoveAt(lstActividades.SelectedIndex);
                }
            }
        }

        //BOTON QUITAR
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            itemsCargados.Add((Item)lstFactura.SelectedItem);
            factura.items.RemoveAt(lstFactura.SelectedIndex);

        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            factura.items.Clear();
        }

        private void lstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = (Item)lstActividades.SelectedItem;
            txtMonto.Text = null;
            if (item.precio == 0)
            {
                txtMonto.ReadOnly = false;
            }
            else
            {
                txtMonto.ReadOnly = true;
            }
        }

        //BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }


        //metodo moveTo
        //private void moveTo(List<Item> origen, List<Item> destino, Item item)
        //{
        //    destino.Add(item);
        //    origen.Remove(item);
        //}
    }
}
