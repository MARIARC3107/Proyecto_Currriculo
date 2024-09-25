using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_curriculo.Models
{
    public class Competencias
    {
        [MaxLength(255)] 
        public string id_programa { get; set; }

        [Key]
        [MaxLength(50)] 
        public string id { get; set; }

        [MaxLength(25)] 
        public string verbo { get; set; }

        [MaxLength(255)] 
        public string objeto_conceptual { get; set; }

        [MaxLength(255)] 
        public string finalidad { get; set; }

        [MaxLength(255)] 
        public string condicion_contexto { get; set; }

        [MaxLength(600)] 
        public string competencia { get; set; }
        public virtual ICollection<perfil_egreso> perfil_egreso { get; set; }


    }
}
