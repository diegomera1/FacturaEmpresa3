using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaEmpresa3.Clases
{
    public class Factura
    {
        public Factura(Cliente cliente, Gasolina gasolina)
        {
            Cliente = cliente;
            Gasolina = gasolina;
        }
        public Factura() { }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Gasolina gasolina;

        

        public Gasolina Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }
        }

        public float Subtotal
        {
            get { return this.Gasolina.Precio*this.Gasolina.Cantidad; }
        }

        public float SubtotalIva
        {
            get { return Subtotal*0.12f; }
        }
   
        public float Total
        {
            get { return Subtotal+SubtotalIva; }
        }

    }
}
