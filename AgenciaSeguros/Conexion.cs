using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgenciaSeguros
{
    class Conexion
    {
        private static String pass = "marisma";
        private static String bd = "agencia_seguros";
        public static MySqlConnection conexion = new MySqlConnection($"server=localhost;user id=root;password={pass};persistsecurityinfo=True;database={bd}");
        public static MySqlCommand comando;

        public static void Abrir()
        {
            conexion.Open();
        }

        public static void SetComando(String sql)
        {
            comando = new MySqlCommand(sql, Conexion.conexion);
        }
    }
}
