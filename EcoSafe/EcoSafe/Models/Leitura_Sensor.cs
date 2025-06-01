using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("LEITURA_SENSOR")]
    public class LEITURA_SENSOR
    {
        [Key]
        [Column("ID_LEITURA_SENSOR")]
        public int ID_LEITURA_SENSOR { get; set; }

        [Column("ID_SENSOR")]
        public int ID_SENSOR { get; set; }
        public SENSOR SENSOR { get; set; }

        [Column("VALOR")]
        public decimal VALOR { get; set; }

        [Column("DATA_LEITURA")]
        public DateTime DATA_LEITURA { get; set; }
    }
}
