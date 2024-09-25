using System.ComponentModel.DataAnnotations;

namespace Proyecto_curriculo.Models
{
    public class perfil_egreso
    {
        [Key]
        [MaxLength(50)] 
        public string id { get; set; }

        [MaxLength(255)]
        public string id_programa { get; set; }

        [MaxLength(100)]
        public string nombre_programa { get; set; }

        [MaxLength(30)]
        public string nmodalidad { get; set; }

        [MaxLength(2500)]
        public string perfil_profesional { get; set; }

        [MaxLength(2500)]
        public string perfil_ocupacional { get; set; }

        public virtual Saber Saber { get; set; }
        public virtual ATProfesionales ATProfesionales { get; set; }
        public virtual AProfesional AProfesional { get; set; }
        public virtual PActuacion PActuacion { get; set; }
        public virtual VAgregado VAgregado { get; set; }
        public virtual Competencias Competencias { get; set; }
        public virtual Res_aprendizaje Res_aprendizaje { get; set; }

    }
}
