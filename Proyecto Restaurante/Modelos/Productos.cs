﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Productos
    {
        [Required(ErrorMessage = "El código es obligatorio")]
        public string CodigoMenu { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria")]
        public string Categoria { get; set; }


        [Required(ErrorMessage = "La Cantidad es obligatorio")]

        public int Cantidad { get; set; }

    }
}
