﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MTBE_u.Entities.Enums;

namespace MTBE_u.Entities
{
    public class Permissao
    {
        public int Id_Permissao { get; set; }
        public string Permissoes { get; set; }
        public Modulos Modulo { get; set; }
        public int Id_Usuario { get; set; }
        public List<Permissao> ListPermissoes_ { get; set; } 

        public Permissao(DataRow dr)
        {
            Id_Permissao = Convert.ToInt32(dr["id_permissao"]);
            Permissoes = dr["permissao"].ToString();
            Modulo = (Modulos)((Char)dr["modulo"]);
            Id_Usuario = Convert.ToInt32(dr["id_usuario"]);
        }

    }
}
