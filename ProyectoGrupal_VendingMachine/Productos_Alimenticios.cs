using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupal_VendingMachine
{
    internal class Productos_Alimenticios:Producto
    {
        public string[] Informacion_Nutricional {  get; set; }

        public Productos_Alimenticios() { }
        public Productos_Alimenticios(int id, string nombre, int unidades, double precio_Unitario,
            string descripcion, string[] informacion_Nutricional):base(id,nombre,unidades,precio_Unitario,descripcion)
        {
            Informacion_Nutricional = informacion_Nutricional;
        }
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion()+ $"{Informacion_Nutricional}";
        }
    }
}
