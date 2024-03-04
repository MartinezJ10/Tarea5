using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5.Utilidades
{
    internal class SQLManager
    {
        public void operationQuery(String queryStr)
        {
            using (SqlConnection connection = new SqlConnection(this.SqlConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(queryStr, connection))
                {
                    try
                    {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        public DataTable retrieveData(String queryStr)
        {

            using (SqlConnection connection = new SqlConnection(this.SqlConnectionString()))
            {
                DataTable result = new DataTable();

                SqlCommand cmd = new SqlCommand(queryStr, connection);

                try
                {
                    cmd.Connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(result);
                    }

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return result;
            }

        }

        public String SqlConnectionString()
        {
            //Falta definir path del json
            string path = Config.jsonPath;

            StringConexionJSON StrConJson = new StringConexionJSON();
            string databaseConnectionParameters = StrConJson.getParametersJsonFromFile(path);


            return StrConJson.DeserializeJsonFile(databaseConnectionParameters);
            // return "Data Source=DESKTOP-CJP8CBD;Initial Catalog=Tarea5;Encrypt=false;Integrated Security=true";

        }
    }
}
