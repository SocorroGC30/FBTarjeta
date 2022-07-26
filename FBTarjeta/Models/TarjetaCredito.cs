using System.ComponentModel.DataAnnotations;

namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {
        [Required]
        public int Id { get; set; }// clave primaria de la aplicacion 
        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpiracion { get; set; }
        [Required]
        public string CVV { get; set; }
    }
}
