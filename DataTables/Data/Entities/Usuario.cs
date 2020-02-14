using System.ComponentModel.DataAnnotations;

namespace DataTables.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(15)]
        public string Apellido { get; set; }
        [Required]
        [MaxLength(3)]
        public int Edad { get; set; }
        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }
        [Required]
        [MaxLength(15)]
        public string Profesion { get; set; }
        [Required]
        [MaxLength(10)]
        public double Salario { get; set; }
    }
}
