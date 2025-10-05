﻿using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Product : IEntidad
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(30)]
        public string Codigo { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int MarcaId { get; set; }
        public virtual Brand Marca { get; set; }

        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }

        public bool Activo { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        public Product()
        {
            Stocks = new HashSet<Stock>();
            Activo = true;
        }
    }
}
