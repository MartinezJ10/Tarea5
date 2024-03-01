using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea5.Utilidades;

namespace Tarea5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.cargarDatosTabla();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cargarDatosTabla()
        {
            string qrySelect = $"SELECT * FROM Peliculas";
            SQLManager SQLMng = new SQLManager();

            try
            {
                dgvData.DataSource = SQLMng.retrieveData(qrySelect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearTabla_Click(object sender, EventArgs e)
        {
            SQLManager SQLMng = new SQLManager();
            try
            {
                string deleteTable = "DROP TABLE Peliculas;";
                SQLMng.operationQuery(deleteTable);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                string createTable = "CREATE TABLE Peliculas(Id INTEGER IDENTITY(1,1) PRIMARY KEY,Nombre varchar(50),Director varchar(50),Genero char(20),Pais char(25),Lanzamiento datetime);";
                SQLMng.operationQuery(createTable);
                MessageBox.Show("TABLA CREADA EXITOSAMENTE");
                this.cargarDatosTabla(); //CARGAR LOS DATOS EN LA TABLA NUEVAMENTE PARA REFLEJAR EL NUEVO INGRESO
                this.limpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string director = txtDirector.Text;
            string pais = txtPais.Text;
            string genero = txtGenero.Text;
            DateTime lanzamiento = dtpFechaLanzamiento.Value;

            SQLManager sqlMng = new SQLManager();
            Pelicula pelicula = new Pelicula(nombre, director, genero, pais, lanzamiento);

            string insertQry = $"INSERT INTO PELICULAS (Nombre,Director,Genero,Pais,Lanzamiento) " +
                               $"VALUES ('{pelicula.Nombre}','{pelicula.Director}','{pelicula.Genero}','{pelicula.Pais}','{pelicula.Lanzamiento}')";

            //Debug.WriteLine(insertQry);
            try
            {
                sqlMng.operationQuery(insertQry);
                MessageBox.Show("VALOR AGREGADO EXITOSAMENTE");
                this.cargarDatosTabla(); //CARGAR LOS DATOS EN LA TABLA NUEVAMENTE PARA REFLEJAR EL NUEVO INGRESO
                this.limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void limpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDirector.Text = "";
            txtPais.Text = "";
            txtGenero.Text = "";
            dtpFechaLanzamiento.ResetText();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex]; // OBTIENE LA FILA EN LA QUE SE DA CLICK
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtNombre.Text = selectedRow.Cells[1].Value.ToString();
                txtDirector.Text = selectedRow.Cells[2].Value.ToString();
                txtGenero.Text = selectedRow.Cells[3].Value.ToString();
                txtPais.Text = selectedRow.Cells[4].Value.ToString();
                dtpFechaLanzamiento.Value = (DateTime)selectedRow.Cells[5].Value;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IdRegistro = txtId.Text;
            if (IdRegistro == "")
            {
                MessageBox.Show("Selecciona la pelicula a eliminar");
            }
            else
            {
                string eliminarQry = $"DELETE FROM Peliculas WHERE Id = {IdRegistro}";
                SQLManager SQLMng = new SQLManager();
                try
                {
                    SQLMng.operationQuery(eliminarQry);
                    MessageBox.Show($"Película {txtNombre.Text} Eliminada correctamente");
                    this.cargarDatosTabla(); //CARGAR LOS DATOS EN LA TABLA NUEVAMENTE PARA REFLEJAR LA ELIMINACION
                    this.limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string IdRegistro = txtId.Text;
            if (IdRegistro == "")
            {
                MessageBox.Show("Selecciona la pelicula a Actualizar");
            }
            else
            {
                string nombre = txtNombre.Text;
                string director = txtDirector.Text;
                string pais = txtPais.Text;
                string genero = txtGenero.Text;
                DateTime lanzamiento = dtpFechaLanzamiento.Value;

                SQLManager sqlMng = new SQLManager();
                Pelicula pelicula = new Pelicula(nombre, director, genero, pais, lanzamiento);

                string insertQry = $"UPDATE Peliculas " +
                               $"SET Nombre ='{pelicula.Nombre}',Director ='{pelicula.Director}',Genero ='{pelicula.Genero}',Pais ='{pelicula.Pais}',Lanzamiento ='{pelicula.Lanzamiento}'" +
                               $"WHERE Id={IdRegistro};";

                //Debug.WriteLine(insertQry);
                try
                {
                    sqlMng.operationQuery(insertQry);
                    MessageBox.Show("VALOR ACTUALIZADO EXITOSAMENTE");
                    this.cargarDatosTabla(); //CARGAR LOS DATOS EN LA TABLA NUEVAMENTE PARA REFLEJAR EL NUEVO INGRESO
                    this.limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
