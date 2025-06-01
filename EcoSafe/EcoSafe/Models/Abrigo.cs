using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("ABRIGO")]
    public class ABRIGO
    {
        [Key]
        [Column("ID_ABRIGO")]
        public int ID_ABRIGO { get; set; }

        [Required]
        [Column("NOME")]
        public string NOME { get; set; }

        [Required]
        [Column("ENDERECO")]
        public string ENDERECO { get; set; }

        [Column("CAPACIDADE")]
        public int CAPACIDADE { get; set; }

        [Column("OCUPACAO_ATUAL")]
        public int OCUPACAO_ATUAL { get; set; }

        public ICollection<SENSOR> SENSORES { get; set; }
        public ICollection<ALERTA> ALERTAS { get; set; }
    }
}

