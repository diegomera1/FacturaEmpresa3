using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaEmpresa3.Clases
{
    public class Gasolina
    {
        public Gasolina(string tipo, float cantidad)
        {
            Tipo = tipo;
            Cantidad = cantidad;
        }
        public Gasolina(){}

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private float cantidad;

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
      
        public float Precio
        {
            get
            {
                if (this.Tipo == "extra") { return 1.5f; }
                else { return 2; }
            }
            
        }

    }
}
