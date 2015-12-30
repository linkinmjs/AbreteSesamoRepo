using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace AbreteSesamo
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            AccesoDatos accesoDatos = new AccesoDatos("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;");
            DataTable dt = accesoDatos.llenarListas();

            BindingList<Item> itemsCargados = new BindingList<Item>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = itemsCargados;


            // Con este For llena la lista lstActividades con los items 
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                DataRow row = dt.Rows[i];
                Item item = new Item();
                item.nombre = row.Field<String>("DES_Item");
                item.id = row.Field<int>("ID_Item");
                item.categoria = row.Field<int>("ID_Categoria");

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
                dataGridView1.Rows[1] = item.categoria;


                
                            
            }

        }

        private void btnVolverForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio.form1.Show();
            //MessageBox.Show(dataGridView1.Rows[0].Cells[1].Value.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
