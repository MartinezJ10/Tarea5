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
                //MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateUser frmCreateUser = new frmCreateUser();
            this.Hide();
            frmCreateUser.Show();
        }

        private void btnCrearTablauUsuarios_Click(object sender, EventArgs e)
        {
            SQLManager SQLMng = new SQLManager();
           /* try
            {
                string deleteTable = "TRUNCATE TABLE TipoUsuario;";

                string deleteTable2 = "TRUNCATE TABLE Usuario;";
                
                SQLMng.operationQuery(deleteTable2);
                SQLMng.operationQuery(deleteTable);

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }*/

            try
            {
                string createTableTipo = "CREATE TABLE TipoUsuario(Id INTEGER IDENTITY(1,1) PRIMARY KEY,Tipo varchar(25));";
                SQLMng.operationQuery(createTableTipo);
                string createTableUsuario = "CREATE TABLE Usuarios(Id INTEGER IDENTITY(1,1) PRIMARY KEY,Nombre varchar(50),Contrasenia varchar(20), TipoUsuario INTEGER REFERENCES TipoUsuario(Id));";
                SQLMng.operationQuery(createTableUsuario);
                MessageBox.Show("TABLA CREADA EXITOSAMENTE");
                btnCrearTablauUsuarios.Enabled = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
