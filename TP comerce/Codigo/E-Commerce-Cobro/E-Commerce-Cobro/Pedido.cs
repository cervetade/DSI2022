﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro
{
    internal class Pedido
    {
        private decimal montoFinal;
        private DateTime fecha;
        private Usuario usuarios;
        private List<Producto> productos;
        private Pago pagos;

        public decimal MontoFinal { get => montoFinal; set => montoFinal = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Usuario Usuarios { get => usuarios; set => usuarios = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public Pago Pagos { get => pagos; set => pagos = value; }

        public Pedido(decimal montoFinal, DateTime fecha)
        {
            this.montoFinal = montoFinal;
            this.Fecha = fecha;
        }

        public void ToStringPedido(Usuario usuario, List<Producto> productos, Pago pago)
        {
            Console.WriteLine("\n\t---DETALLE DEL PEDIDO---\n");
            Console.WriteLine("\tProductos");
            for (int i = 0; i < productos.Count; i++)
            {
                productos[i].ToStringProducto();
            }

            usuarios = usuario;
            Console.WriteLine("\nCliente\n");
            usuario.ToStringUsuario();

            Console.WriteLine("\nMonto total: " + montoFinal);
            Console.WriteLine("Fecha: " + fecha);

            if (pago.Metodo == MetodoPago.Debito)
            {
                pago.ToStringPagoTarjetaDebito();
            }

            else
            {
                if (pago.Cuotas.Count == 1)
                {
                    pago.ToStringPagoTarjetaCredito(montoFinal);
                }
                else if (pago.Cuotas.Count == 3)
                {
                    pago.ToStringPagoTarjetaCredito(montoFinal * 1.05M);
                }
                else if (pago.Cuotas.Count == 6)
                {
                    pago.ToStringPagoTarjetaCredito(montoFinal * 1.10M);
                }
                else
                {
                    pago.ToStringPagoTarjetaCredito(montoFinal * 1.15M);
                }
            }
        }
    }
}
