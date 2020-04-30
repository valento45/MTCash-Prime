using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MTBE_u.Exceptions;
using System.Data;
using MTBE_u.Entities.Enums;
using MTBE_u.Entities;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace MTBE_u
{
    public class Usuario : Pessoa
    {
        string funcao;
        string modulos;
        bool? user_atv;
        string tipo;
        string usuario;
        string senha;

        public Permissao Permissao_ { get; set; }

        public string Endereco { get; set; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string Modulos { get => modulos; set => modulos = value; }
        public bool? User_atv { get => user_atv; set => user_atv = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string _Usuario { get => usuario != null ? usuario : throw new UsuarioException("Usuário não informado!"); set => usuario = value; }
        public string Senha { get => senha != null ? senha : throw new UsuarioException("Senha não informada!"); set => senha = value; }

        public Modulos[] ModulosArray = { MTBE_u.Entities.Enums.Modulos.Usuario, Entities.Enums.Modulos.Cliente, Entities.Enums.Modulos.Financeiro, Entities.Enums.Modulos.Investimento };

        public string GetParametros
        {
            get
            {
                return usuario.Skip(1).Take(1).Skip(8).Take(2).ToString();
            }
        }

        public Usuario()
        {
            Id_Pessoa = -1;
        }
        public Usuario(DataRow dr)
        {
            Id_Pessoa = Convert.ToInt32(dr["id_usuario"]);
            Nome = dr["nome"].ToString();
            Tipo_Documento = dr["tipo_documento"].ToString();
            Documento = dr["documento"].ToString();
            Cpf_Cnpj = dr["cpf"].ToString();
            Data_Nascimento = dr["data_nascimento"] != DBNull.Value ? (DateTime?)dr["data_nascimento"] : (DateTime?)null;
            Funcao = dr["funcao"].ToString();
            Modulos = dr["modulos"].ToString();
            User_atv = dr["user_atv"] != DBNull.Value ? (bool?)dr["user_atv"] : (bool?)null;
            Tipo = dr["tipo"].ToString();
            _Usuario = dr["usuario"].ToString();
            Senha = dr["senha"].ToString();

        }

        public int Insert_User(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.tb_usuario (nome, " +
               /* "tipo_documento, documento, cpf, data_nascimento, funcao, modulos, user_atv, tipo," +*/
                " usuario, senha) values (@nome, " +
                /*"@tipo_documento, @documento, @cpf, @data_nascimento, @funcao, @modulos, @user_atv, @tipo, " +*/
                "@usuario, @senha);SELECT SCOPE_IDENTITY();");
            cmd.Parameters.AddWithValue(@"nome", usuario.Nome);
            //cmd.Parameters.AddWithValue(@"tipo_documento", usuario.Tipo_Documento);
            //cmd.Parameters.AddWithValue(@"documento", usuario.Documento);
            //cmd.Parameters.AddWithValue(@"cpf", usuario.Cpf_Cnpj);
            //cmd.Parameters.AddWithValue(@"data_nascimento", usuario.Data_Nascimento);
            //cmd.Parameters.AddWithValue(@"funcao", usuario.Funcao);
            //cmd.Parameters.AddWithValue(@"modulos", usuario.Modulos);
            //cmd.Parameters.AddWithValue(@"user_atv", usuario.User_atv);
            //cmd.Parameters.AddWithValue(@"tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue(@"usuario", usuario._Usuario);
            cmd.Parameters.AddWithValue(@"senha", usuario.Senha);

            int chave = Access.ExecuteScalar(cmd);
            return chave;
        }

        public void Update_User(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("update mtcash.tb_usuario set nome = @nome," +
                "tipo_documento = @tipo_documento," +
                "documento = @documento," +
                "cpf = @cpf," +
                "data_nascimento = @data_nascimento," +
                "funcao = @funcao," +
                "modulos = @modulos," +
                "user_atv = @user_atv," +
                "tipo = @tipo," +
                "usuario = @usuario," +
                "senha = @senha where id_usuario = @id_usuario");
            cmd.Parameters.AddWithValue(@"id_usuario", usuario.Id_Pessoa);
            cmd.Parameters.AddWithValue(@"nome", usuario.Nome);
            cmd.Parameters.AddWithValue(@"tipo_documento", usuario.Tipo_Documento);
            cmd.Parameters.AddWithValue(@"documento", usuario.Documento);
            cmd.Parameters.AddWithValue(@"cpf", usuario.Cpf_Cnpj);
            cmd.Parameters.AddWithValue(@"data_nascimento", usuario.Data_Nascimento);
            cmd.Parameters.AddWithValue(@"funcao", usuario.Funcao);
            cmd.Parameters.AddWithValue(@"modulos", usuario.Modulos);
            cmd.Parameters.AddWithValue(@"user_atv", usuario.User_atv);
            cmd.Parameters.AddWithValue(@"tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue(@"usuario", usuario._Usuario);
            cmd.Parameters.AddWithValue(@"senha", usuario.Senha);

            Access.ExecuteNonQuery(cmd);
        }
        public void Delete_User(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand($"delete from mtcash.tb_usuario where id_usuario ={usuario.Id_Pessoa}; ");
            Access.ExecuteNonQuery(cmd);
        }
        public Usuario Logar(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_usuario where usuario = @usuario and senha = @senha");
            cmd.Parameters.AddWithValue(@"usuario", usuario._Usuario);
            cmd.Parameters.AddWithValue(@"senha", Access.Encrypt(usuario._Usuario ,usuario.Senha));
            
            DataTable dt = new DataTable();
            dt = Access.ExecuteReader(cmd)?.Tables[0];

            //conseguiu logar
            if (dt.Rows.Count > 0)
                usuario = new Usuario(dt.Rows[0]);
            return usuario;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> result = new List<Usuario>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_usuario");
            foreach (DataRow user in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Usuario(user));
            return result;
        }

        public static Usuario GetById(int id)
        {
            SqlCommand cmd = new SqlCommand($"select * from mtcash.tb_usuario where id_usuario={id};");
            DataTable dt = new DataTable();
            dt = Access.ExecuteReader(cmd).Tables[0];

            if (dt.Rows.Count > 0)
                return new Usuario(dt.Rows[0]);
            else
                return new Usuario();
        }
        public static List<Permissao_Modulo_Usuario> GetPermissoesByUser(Usuario user)
        {
            List<Permissao_Modulo_Usuario> result = new List<Permissao_Modulo_Usuario>();

            try
            {
                SqlCommand cmd = new SqlCommand($"select * from mtcash.tb_permissao_usuario where id_usuario = {user.Id_Pessoa};");
                foreach (DataRow row in Access.ExecuteReader(cmd).Tables[0].Rows)
                    result.Add(new Permissao_Modulo_Usuario(row));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!\n" + ex.Message);
            }
            return result;
        }
        public static void Update_Permissao(Permissao_Modulo_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand($"update mtcash.tb_permissao_usuario set permissao = '{usuario.Permissoes_}' where id_usuario ={usuario.Id_Usuario} and modulo ='{(Char)usuario.Modulos_}';");
            Access.ExecuteNonQuery(cmd);
        }
        
    }
}
