using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaEmpresa3.Clases
{
    public class Cliente
    {
        public Cliente(string nombre, string apellido, string identificacion, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Direccion = direccion;
        }
        public Cliente() { }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string direccion;
  
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}
