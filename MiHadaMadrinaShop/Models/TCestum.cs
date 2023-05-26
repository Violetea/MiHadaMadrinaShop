﻿using System;
using System.Collections.Generic;

namespace MiHadaMadrinaShop.Models
{
    public partial class TCestum
    {
        public long IdCesta { get; set; }
        public int Cantidad { get; set; }
        public long IdProducto { get; set; }
        public decimal Iva { get; set; }
        public byte? PorcentajeDeDescuento { get; set; }
        public decimal Total { get; set; }
        public decimal TotalSinIva { get; set; }
        public long IdDatosUsuario { get; set; }

        public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
