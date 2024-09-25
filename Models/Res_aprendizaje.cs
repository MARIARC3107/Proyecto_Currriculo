using System.ComponentModel.DataAnnotations;

namespace Proyecto_curriculo.Models
{
    public class Res_aprendizaje
    {
        [Key]
        [MaxLength(50)] 
        public string id_resultado { get; set; }

        [MaxLength(600)] 
        public string competencia { get; set; }

        [MaxLength(10)] 
        public string tipo_saber { get; set; }

        [MaxLength(255)] 
        public string saber_asociado { get; set; }

        [MaxLength(10)] 
        public string taxonomia { get; set; }

        [MaxLength(20)] 
        public string dominio_tratar { get; set; }

        [MaxLength(20)] 
        public string nivel_dominio { get; set; }

        [MaxLength(20)] 
        public string verbo { get; set; }

        [MaxLength(600)] 
        public string resultado_ap { get; set; }
        public virtual ICollection<perfil_egreso> perfil_egreso { get; set; }
    }
}
