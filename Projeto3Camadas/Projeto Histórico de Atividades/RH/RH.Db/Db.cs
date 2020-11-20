using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Models;

namespace RH.Db
{
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=Localhost;Initial Catalog=RhDb;Uid=root;Password=;Integrated Security=false;Pooling=False";                
            }
        }
    }
}
