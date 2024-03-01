using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Tarea5.Utilidades;

namespace Tarea5
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            string qryExiste = $"SELECT * FROM Usuarios WHERE Nombre='{usuario}' AND Contrasenia='{contrasenia}';";
            SQLManager SQLMng = new SQLManager();
            try
            {
                DataTable dt = SQLMng.retrieveData(qryExiste);
                if (dt.Rows.Count != 0) // VERIFICAR SI SE ENCONTRO ALGUN REGISTRO CON LAS CREDENCIALES PROVISTAS
                {
                    DataRow dr = dt.Rows[0];
                    string tipoUsuario = dr["TipoUsuario"].ToString();
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
