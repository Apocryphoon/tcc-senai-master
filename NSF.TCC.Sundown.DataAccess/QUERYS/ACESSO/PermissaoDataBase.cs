﻿using MySql.Data.MySqlClient;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.DataAccess
{
    public class PermissaoDataBase
    {
        public DTOPermission Permin(int id)
        {
            string query = "select tb_usuario.id_usuario, tb_permissao.bt_adm, tb_permissao.bt_rh, tb_permissao.bt_fin, tb_permissao.bt_cont, tb_permissao.bt_comp, tb_permissao.bt_vend from tb_usuario inner join tb_permissao on tb_usuario.id_usuario = tb_permissao.id_usuario WHERE tb_usuario.id_usuario = @id";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("id", id));

            ProjetoDataBase sql = new ProjetoDataBase();

            MySqlDataReader reader = sql.ExecuteSelectParamters(query, parameters);

            DTOPermission var = new DTOPermission();
            if (reader.Read() == true)
                {
                var.IdUser = reader.GetInt32("id_usuario");
                var.Administrator = reader.GetBoolean("bt_adm");
                var.Rh = reader.GetBoolean("bt_rh");
                var.Fin = reader.GetBoolean("bt_fin");
                var.Cont = reader.GetBoolean("bt_cont");
                var.Comp = reader.GetBoolean("bt_comp");
                var.Vend = reader.GetBoolean("bt_vend");
            }
            reader.Close();

            return var;
        }
    }
}
