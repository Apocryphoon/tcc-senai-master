﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.Business
{
    public class LoginBusiness
    {
        public int Logar(string email, string senha)
        {
            LoginDataBase login = new LoginDataBase();

            if (email != "" && senha != "")
                return login.Login(email, senha);
            else
                return 0;


        }
    }
}
