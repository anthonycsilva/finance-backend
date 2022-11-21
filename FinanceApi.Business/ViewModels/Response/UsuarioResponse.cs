using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApi.Business.ViewModels.Response
{
    public class UsuarioResponse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }
    }
}