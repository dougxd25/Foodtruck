﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public String CPF { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }

        public String Descrever()
        {
            return String.Format($"{this.Id} - {this.CPF} - {this.Nome} - {this.Email}");
        }
    }
}
