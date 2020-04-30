using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTBE_u.Entities.Enums
{
    public class Modulo
    {
        private static Modulos[] modulos_ = { Modulos.Usuario, Modulos.Cliente, Modulos.Financeiro, Modulos.Investimento };
        private static Permissoes[] permissoes_ = { Permissoes.Incluir, Permissoes.Alterar, Permissoes.Excluir, Permissoes.Relatorio };


        public static List<Permissao_Modulo_Usuario> Get_Permissoes
        {
            get
            {
                return GetPermition(Login.User);
            }
        }

        public static Modulos[] GetModulos
        {
            get
            {
                return modulos_;
            }
        }
        public static Permissoes[] GetPermissoesArray
        {
            get
            {
                return permissoes_;
            }
        }

        private static List<Permissao_Modulo_Usuario> GetPermissoes(Usuario user)
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

        private static string GetPermissaoByModulo(Usuario user, Modulos modulo)
        {
            string detalhes = "";
            foreach (var perm in GetPermissoes(user).Where(x => x.Modulos_ == modulo))
                detalhes += perm.Permissoes_;
            return detalhes;
        }

        private static List<Permissao_Modulo_Usuario> GetPermition(Usuario user)
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

        public static bool CanAccess(Modulos modulos)
        {
            bool result = false;
            foreach(var perm in Get_Permissoes.Where(x => x.Modulos_ == modulos))
            {
                if (perm.Permissoes_.Length > 0)
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        public static bool CanInclude(Usuario user, Modulos modulo)
        {
            if (GetPermissaoByModulo(user, modulo).Contains((Char)Permissoes.Incluir))
                return true;
            else
                return false;
        }

        public static bool CanExclude(Usuario user, Modulos modulo)
        {
            if (GetPermissaoByModulo(user, modulo).Contains((Char)Permissoes.Excluir))
                return true;
            else
                return false;
        }

        public static bool CanUpdate(Usuario user, Modulos modulo)
        {
            if (GetPermissaoByModulo(user, modulo).Contains((Char)Permissoes.Alterar))
                return true;
            else
                return false;
        }

        public static bool CanRelatorio(Usuario user, Modulos modulo)
        {
            if (GetPermissaoByModulo(user, modulo).Contains((Char)Permissoes.Relatorio))
                return true;
            else
                return false;
        }
    }

    public class Permissao_Modulo_Usuario
    {
        public int Id_Permissao { get; set; }
        public int Id_Usuario { get; set; }
        public Modulos Modulos_ { get; set; }
        public string Permissoes_ { get; set; }
        public Permissao_Modulo_Usuario() { }
        public Permissao_Modulo_Usuario(DataRow dr)
        {
            Id_Permissao = Convert.ToInt32(dr["id_permissao"]);
            Modulos_ = (Modulos)(Convert.ToChar(dr["modulo"]))/*Enum.Parse(typeof(Modulos), dr["modulo"].ToString())*/;
            Permissoes_ = dr["permissao"].ToString();
            Id_Usuario = Convert.ToInt32(dr["id_usuario"]);
        }

        public static void Insert_Permissao_Usuario(int id)
        {
            for (int i = 0; i < Modulo.GetModulos.Length; i++)
            {
                SqlCommand cmd = new SqlCommand($"insert into mtcash.tb_permissao_usuario (modulo, id_usuario) values ('{(Char)Modulo.GetModulos[i]}', {id});");
                Access.ExecuteReader(cmd);
            }
        }



    }

    public enum Modulos
    {
        Usuario = 'u',
        Cliente = 'c',
        Financeiro = 'f',
        Investimento = 'i',
        vazio = ' '
    }

    public enum Permissoes
    {
        Incluir = 'a',
        Alterar = 'p',
        Excluir = 'x',
        Relatorio = 'r'
    }
}
