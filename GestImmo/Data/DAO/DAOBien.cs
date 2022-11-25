using System;
using GestImmo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestImmo.Data.DAL;

namespace GestImmo.Data.DAO
{
    internal class DAOBien
    {
        public List<Bien> getBienPret()
        {
            List<Bien> biens;

            ImmoContext ctx = ImmoContext.getInstance();
            var rows = from b in ctx.Bien
                       where b.Pret != null
                       select b;
            biens = rows.ToList();

            return biens;
        }
    }
}
