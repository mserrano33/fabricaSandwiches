using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaSandwiches.BD.Data.Entidades
{
    public class Producto : EntityBase ///hereda de entityBase sierto campos
    {
        [Required]
        [MaxLength(8, ErrorMessage = "El DNI de la persona no debe superar los {1} caracteres")]
        public string DNI { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "El Nombre de la persona no debe superar los {1} caracteres")]
        public string Nombre { get; set; }
    }
}
