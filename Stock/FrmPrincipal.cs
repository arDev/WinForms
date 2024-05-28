using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEstado.Text = "...........";
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //if (tbxNombre.Text == "")
            if (tbxNombre.Text.Equals(""))
            {
                txtEstado.Text = $"No se puede agregar un nombre vacio!";
            }
            else
            {
                lbxAlumnos.Items.Add(tbxNombre.Text);
                Limpiar();
                txtEstado.Text = $"El nombre {tbxNombre.Text} se agrego correctamente";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtEstado.Text = null;
            tbxNombre.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(tbxNombre2.Text, tbxApellido.Text);

            Procesos procesos = new Procesos();

            procesos.Guardar(persona);
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            lbxAlumnos.Items.Clear();
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {
            int seleccionado = lbxAlumnos.SelectedIndex;
            if (seleccionado > -1)
            {
                lbxAlumnos.Items.RemoveAt(seleccionado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // vale por un codigo
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
