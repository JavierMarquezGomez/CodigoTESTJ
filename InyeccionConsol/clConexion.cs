using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConsol
{
    public class clConexion
    {
        internal string conectarSQL()
        {
            string redInterna = "";
            SqlConnection cnn = new SqlConnection(redInterna);

            SqlCommand cmd = new SqlCommand("StoreProcedure", cnn);

            SqlParameter pInput = new SqlParameter("Parametro_IN", System.Data.SqlDbType.Int);
            pInput.Value = "14";
            cmd.Parameters.Add(pInput);
            SqlParameter pOut = new SqlParameter("Parametro_OUT", System.Data.SqlDbType.VarChar, 200);
            pOut.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            string salidaStore = pOut.Value.ToString();


            return salidaStore;
           

        }

        internal DataSet conectarDataset(int x )
        {
            string server = "";
            DataSet dataset = new DataSet();

            SqlConnection cnn = new SqlConnection(server);
            SqlCommand cmd = new SqlCommand("StoreDataSet", cnn);
            cmd.Parameters.Add("Parametro1" , SqlDbType.Int).Value = x;

            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            cnn.Close();

            dataAdapter.Fill(dataset);


            return dataset;

        }


        internal Dictionary<string, object> result ( string query, List<SqlParameter> sParametrosInput , List<SqlParameter> sParametrosOutput)
        {
            Dictionary<string, object> parametrosSalida = new Dictionary<string, object>();
            string servidor = "";
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(servidor);
            SqlCommand cmd = new SqlCommand(query , cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (var pInp in sParametrosInput)
            {
                cmd.Parameters.Add( new SqlParameter( pInp.ParameterName, pInp.Value));
            }

            foreach (var pOut in sParametrosOutput)
            {
                SqlParameter pSalida = new SqlParameter(pOut.ParameterName, SqlDbType.VarChar,200);
                pSalida.Direction = ParameterDirection.Output;                
                cmd.Parameters.Add(pSalida);
            }             

            cnn.Open();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cnn.Close();

            // da.Fill(dt);
            //Obtener el Valor de salida;

            foreach (SqlParameter par in cmd.Parameters)
            {
                if (par.Direction == ParameterDirection.Output)
                {
                    parametrosSalida[par.ParameterName] = par.Value;
                }

            }
            return parametrosSalida;            
        }       

        public T Generico<T>(List<T> lista)
        {
            
            return lista[0] ;
        }


        public List<T> EjecutarConsulta<T>(string query) where T : new()
        {
            var resultados = new List<T>();
            string x ="" ;
            using (SqlConnection conexion = new SqlConnection(x))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    T instancia = new T();
                    foreach (PropertyInfo propiedad in typeof(T).GetProperties())
                    {
                        if (!lector.IsDBNull(lector.GetOrdinal(propiedad.Name)))
                        {
                            propiedad.SetValue(instancia, lector[propiedad.Name]);
                        }
                    }
                    resultados.Add(instancia);
                }
            }

            return resultados;
        }
    }

}
        
