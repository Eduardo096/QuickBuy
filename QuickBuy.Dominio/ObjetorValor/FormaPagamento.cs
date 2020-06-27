using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetorValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrcao { get; set; }

        public bool EhBoleto 
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }

        }
        public bool EhCartaodeCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaodeCredito; }

        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito;}

        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamento.naoDefinido; }

        }
    }
}
