using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea5.Utilidades;

namespace Tarea5
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text;
            string nuevaContrasenia = txtNuevaContrasenia.Text;

            string crearUsuarioQry = $"INSERT INTO Usuarios (Nombre, Contrasenia)" +
                $" VALUES ('{nuevoUsuario}','{nuevaContrasenia}')";

            SQLManager SQLMng = new SQLManager();

            try
            {
                SQLMng.operationQuery(crearUsuarioQry);
                MessageBox.Show("Usuario Creado Exitosamente");
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                              

        }
    }
}
