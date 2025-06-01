using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("SENSOR")]
    public class SENSOR
    {
        [Key]
        [Column("ID_SENSOR")]
        public int ID_SENSOR { get; set; }

        [Required]
        [Column("TIPO")]
        public string TIPO { get; set; }

        [Column("ID_ABRIGO")]
        public int ID_ABRIGO { get; set; }
        public ABRIGO ABRIGO { get; set; }

        public ICollection<LEITURA_SENSOR> LEITURAS { get; set; }
    }
}
