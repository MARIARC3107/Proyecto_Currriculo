using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_curriculo.Models
{
    public class AProfesional
    {
        [MaxLength(255)] 
        public string id_programa { get; set; }

        [Key]
        [MaxLength(50)] 
        public string id { get; set; }

        [MaxLength(300)] 
        public string a_profesional { get; set; }

        public virtual ICollection<perfil_egreso> perfil_egreso { get; set; }

    }
}
