using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace SillasGil.Models
{
    public class Evento
    {
        public int Id { get ; set; }

        [Required]
        public required string Nombre { get; set; }

        [Required]
        public required DateTime Fecha { get; set; }

        public required string Ubicacion { get; set; }

        public required string Observaciones { get; set; }
    }
}
