using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace EdimarCM_Aplicada_1_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClientesD c = new ClientesD();
        Utilidades u = new Utilidades();
        private void Llenar(ClientesD c)
        {
            var clie = ClientesBLL.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = c.ClienteId.ToString();
            NombretextBox.Text = c.Nombre;
            dataGridView.DataSource = null;
            dataGridView.DataSource = c.ClienteId;

        }
        public void LlenarClase(Entidades.ClientesD cliente)
        {

            cliente.Nombre = NombretextBox.Text;
            cliente.LimiteCredito = LimitetextBox.Text;

        }
        private void LlenandoCombo()
        {
            //Es = new Estudiantes();
            ClientecomboBox.DataSource = ClientesBLL.GetLista();
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "EstudianteId";

        }
        private void RegistrarEstudiantes_Load(object sender, EventArgs e)
        {

            LlenandoCombo();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ClientesD cliente = new ClientesD();
            LlenarClase(cliente);
            ClientesBLL.Guardar(cliente);
            MessageBox.Show("Guardado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Text = "";
            LimitetextBox.Text = "";
            FechatextBox.Text = "";
            IdtextBox.Text = "";
        }
        private bool ValidarId(string message)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                errorProvider1.SetError(IdtextBox, "Ingresar Id!!");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }
        public int String(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }
        public void VaciarTexbox()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            
        
            if (ValidarId("Ingrese Id del Usuario") && ValidarBuscar())
            {


                VaciarTexbox();
                MessageBox.Show("Eliminacion con Exitosa");
            
        }
    }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarId("Ingresa el Id") && ValidarBuscar())
                LlenarClase(ClientesBLL.Buscar(String(IdtextBox.Text)));
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            //c.cliente.Add(new ClientesD ((int) ClientecomboBox.SelectedValue, ClientecomboBox.Text));
            dataGridView.DataSource = null;
            dataGridView.DataSource = c.ClienteId;
           ClientecomboBox.Text = "";
        }
    }
}
