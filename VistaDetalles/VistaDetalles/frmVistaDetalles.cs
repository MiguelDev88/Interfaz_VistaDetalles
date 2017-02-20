using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaDetalles
{
    public partial class frmVistaDetalles : Form
    {
        public frmVistaDetalles()
        {
            InitializeComponent();
            leerDatos();

        }

        public void leerDatos()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Cliente));
            System.IO.StreamReader file = new System.IO.StreamReader("clientes.xml");

            Cliente cliente = (Cliente)reader.Deserialize(file);
            file.Close();

            ListViewItem item = new ListViewItem();
            item.Text = cliente.nombre;
            item.Tag = cliente;
            listaClientes.Items.Add(item);
            
        }

        private void listaClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)((ListBox)sender).SelectedItem;
            txtDni.Text = cliente.dni;
            txtNombre.Text = cliente.nombre;
        }

        private void listaClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            Cliente cliente = (Cliente)e.Item.Tag;
            txtDni.Text = cliente.dni;
            txtNombre.Text = cliente.nombre;
            txtTelefono.Text = cliente.telefono;
            txtContacto.Text = cliente.contacto;
            txtMail.Text = cliente.mail;
        }
    }
}
