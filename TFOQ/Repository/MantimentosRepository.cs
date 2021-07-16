using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TFOQ.Models;

namespace TFOQ.Repository
{
    public class MantimentosRepository
    {
        public List<Mantimentos> GetMantimentos()
        {
            Contexto banco = new Contexto();
            List<Mantimentos> lista = new List<Mantimentos>();
            lista = banco.mantimentos.ToList();
            return lista;

        }


    }
}