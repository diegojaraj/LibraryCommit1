using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Modelo
{
    class Producto
    {
         int codigo;
         string titulo;
         string autor;
         string editorial;
         double precio;
         string ubicacion;
         int cantidadEx;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int CantidadEx { get => cantidadEx; set => cantidadEx = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
