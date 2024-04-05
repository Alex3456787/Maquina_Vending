using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupal_VendingMachine
{
    internal class Materiales_Preciosos : Producto
    {
        public string Tipo_Material { get; set; }
        public int Peso { get; set; }
        public Materiales_Preciosos() { }
        public Materiales_Preciosos(int id, string nombre, int unidades, double precio_Unitario,
            string descripcion, string tipo_Material, int peso) : base(id, nombre, unidades, precio_Unitario, descripcion)
        {
            Tipo_Material = tipo_Material;
            Peso = peso;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $" {Tipo_Material}" +
                 $"{Peso} gr.";
        }
    }
}
