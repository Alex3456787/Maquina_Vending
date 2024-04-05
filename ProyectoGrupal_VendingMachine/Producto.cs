using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupal_VendingMachine
{
    internal class Producto
    {
        List<Producto> ListaProductos;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public double Precio_Unitario { get; set; }
        public string Descripcion { get; set; }
        public Producto() { }
        public Producto(int id, string nombre, int unidades, double precio_Unitario, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Unidades = unidades;
            Precio_Unitario = precio_Unitario;
            Descripcion = descripcion;
        }

        public virtual string MostrarInformacion()
        {
            Console.Clear();
            return $"{Id} \n " +
                   $" {Nombre} \n " +
                   $" {Unidades} unidades \n" +
                   $" {Precio_Unitario} euros \n" +
                   $"{Descripcion} ";
        }
    }
}

