using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Operadores
    {
        [Required(ErrorMessage = "El primer campo no puede estar vacía.")]
        public decimal PrimerNumero { get; set; }
        [Required(ErrorMessage = "El segundo campo no puede estar vacía.")]
        public decimal SegundoNumero { get; set; }
        public decimal resultado { get; set; }

        public Operadores()
        {
            PrimerNumero = 0;
            SegundoNumero = 0;
            resultado = 0;
        }
    }
}
