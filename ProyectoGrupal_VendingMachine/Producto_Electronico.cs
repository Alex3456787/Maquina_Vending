using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupal_VendingMachine
{
    internal class Producto_Electronico:Producto
    {
        public string Materiales {  get; set; }
        public bool Inclusion_Pilas {  get; set; }
        public bool Producto_Precargado { get; set; }

        public Producto_Electronico() { }
        public Producto_Electronico(int id ,string nombre, int unidades, double precio_Unitario, string descripcion,
            string materiales, bool inclusion_Pilas, bool producto_Precargado):base(id, nombre,  unidades,  precio_Unitario, descripcion)
        {
            Materiales = materiales;
            Inclusion_Pilas = inclusion_Pilas;
            Producto_Precargado = producto_Precargado;
        }
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $"{Materiales} " +
                $"{Inclusion_Pilas}" +
                $"{Producto_Precargado}";
        }
    }
}
