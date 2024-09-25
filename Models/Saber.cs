using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_curriculo.Models
{
    public class Saber
    {
        [MaxLength(255)]
        public string id_programa { get; set; }

        [Key]
        [MaxLength(50)]
        public string id { get; set; }

        [MaxLength(300)]
        public string saber { get; set; }

        [MaxLength(300)]
        public string saber_hacer { get; set; }

        [MaxLength(300)]
        public string saber_ser { get; set; }

        [ForeignKey("id")]
        public virtual ICollection<perfil_egreso> perfil_egreso { get; set; }




    }
}
