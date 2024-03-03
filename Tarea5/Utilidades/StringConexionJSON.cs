/*using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5.Utilidades
{
    internal class StringConexionJSON
    {
        public StringConexionJSON()
        {

        }

        //Metodo para obtener el contenido del archivo JSON en un String
        public string getParametersJsonFromFile(string path)
        {
            string parametersJsonFromFile;
            using (var reader = new StreamReader(path))
            {
                parametersJsonFromFile = reader.ReadToEnd();
            }
            return parametersJsonFromFile;
        }

        //Metodo para convertir el objeto del Json en un objeto de la clase ConexionBDParam
        public string DeserializeJsonFile(string parametersJsonFromFile)
        {
            var StringConexion = JsonConvert.DeserializeObject<ConexionBDParam>(parametersJsonFromFile);

            return StringConexion.toString();
            //  return string.Format("Data Source={0};Initial Catalog={1};Encrypt={2};Integrated Security={3}", StringConexion.dataSource, StringConexion.initialCatalog, StringConexion.encrypt, StringConexion.integratedSecurity);
        }
    }
}*/