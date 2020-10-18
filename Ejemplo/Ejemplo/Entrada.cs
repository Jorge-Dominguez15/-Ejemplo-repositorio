using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace Ejemplo
{
    public partial class frmEntrada : Form
    {
        string servidorIP = "localhost";
        int puerto = 8080;
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninicio_Click(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir?", "salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            TcpClient client = new TcpClient(servidorIP, puerto);

            int byteCount = Encoding.ASCII.GetByteCount(txtMensaje.Text);
            byte[] EnviarDatos = new byte[byteCount];

            EnviarDatos = Encoding.ASCII.GetBytes(txtMensaje.Text);
            NetworkStream stream = client.GetStream();

            stream.Write(EnviarDatos, 0, EnviarDatos.Length);

            stream.Close();
            client.Close();


        }
    }
}
