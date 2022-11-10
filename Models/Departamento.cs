using System.ComponentModel.DataAnnotations;

namespace DeptosES.AdministradorBlazor.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La zona es requerida")]
        public int Zona { get; set; }
    }
}
