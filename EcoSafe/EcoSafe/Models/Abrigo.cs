using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("ABRIGO")]
    public class ABRIGO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_ABRIGO")]
        public int ID_ABRIGO { get; set; }

        [Required]
        [Column("NOME")]
        public string NOME { get; set; } = string.Empty;

        [Required]
        [Column("ENDERECO")]
        public string ENDERECO { get; set; } = string.Empty;

        [Required]
        [Column("CAPACIDADE")]
        public int CAPACIDADE { get; set; }

        [Required]
        [Column("OCUPACAO_ATUAL")]
        public int OCUPACAO_ATUAL { get; set; }

        
        public ICollection<SENSOR> SENSORES { get; set; } = new List<SENSOR>();
        public ICollection<ALERTA> ALERTAS { get; set; } = new List<ALERTA>();
    }
}


