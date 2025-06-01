using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("ALERTA")]
    public class ALERTA
    {
        [Key]
        [Column("ID_ALERTA")]
        public int ID_ALERTA { get; set; }

        [Required]
        [Column("TIPO")]
        public string TIPO { get; set; }

        [Required]
        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

        [Column("ID_ABRIGO")]
        public int ID_ABRIGO { get; set; }
        public ABRIGO ABRIGO { get; set; }
    }
}

