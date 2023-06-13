﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
         public int Id { get; set; }
         public string Nome { get; set; }
         public string Sigla { get; set; }

         public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();
            //cadeia 
            listaDeEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rondônia",
                Sigla = "RO"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC"
            });

            return listaDeEstados;
        }
          
    }
}