using MTBE_u.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u
{
    public class Login
    {
        public static Usuario User;
        public static Modulo Modulo { get; set; }
        public int Id_Login { get; set; }
        public int Id_Usuario { get; set; }
        DateTime? Data_Login { get; set; }

        public Login() { }

        public Login(Usuario user)
        {
            if (user.Id_Pessoa > 0)
            {
                User = user;
                Insert_Login(User.Id_Pessoa);
               // Modulo = new Modulo();
            }
        }

        public void Insert_Login(int id_usuario)
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.tb_login (id_usuario, data_login) values (@id_usuario, @data_login)");
            cmd.Parameters.AddWithValue(@"id_usuario", id_usuario);
            cmd.Parameters.AddWithValue(@"data_login", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Access.ExecuteNonQuery(cmd);
        }
    }
}
