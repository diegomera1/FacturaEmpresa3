using System;
using System.Collections.Generic;
using FacturaEmpresa3.Clases;

namespace FacturaEmpresa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Jose= new Cliente("Jose", "Mera", "1315729770", "Manta");
            Gasolina gasolina = new Gasolina("extra", 29);
            Factura compra = new Factura(Jose, gasolina);

            Console.WriteLine("Cliente: " +compra.Cliente.Nombre +" " + compra.Cliente.Apellido);
            Console.WriteLine("Identificación: " +compra.Cliente.Identificacion+"   Dirección: " +compra.Cliente.Direccion);
            Console.WriteLine("Tipo de gasolina: " +compra.Gasolina.Tipo+"   Precio por galon: " +compra.Gasolina.Precio+"   Cantidad: " +compra.Gasolina.Cantidad);
            Console.WriteLine("Subtotal:" +compra.Subtotal);
            Console.WriteLine("Iva: " +compra.SubtotalIva);
            Console.WriteLine("Total: " +compra.Total);
            Console.ReadLine();
        }
    }
}