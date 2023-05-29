using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domino
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo{ get; set; }
        [DisplayName("Nombre")]
        public string Nombre{ get; set; }
        [DisplayName("Descripción")]
        public string Descripcion{ get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string imagenUrl { get; set; }
        public decimal Precio{ get; set; }
    }
}
