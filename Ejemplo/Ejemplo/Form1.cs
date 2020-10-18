using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        frmEntrada clode;
        public Form1()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text != "") && (txtcontraseña.Text != ""))
            {
                if ((txtUsuario.Text == "admin") && (txtcontraseña.Text == "admin"))
                {
                    
                    clode = new frmEntrada();
                    clode.Show();
                    this.Hide();
                }
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir?", "salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
