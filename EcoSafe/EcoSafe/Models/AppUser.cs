using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSafe.Models
{
    [Table("APPUSER")]
    public class APPUSER
    {
        [Key]
        [Column("ID_USUARIO")]
        public int ID_USUARIO { get; set; }

        [Required]
        [Column("NOME")]
        public string NOME { get; set; }

        [Required]
        [Column("EMAIL")]
        public string EMAIL { get; set; }

        [Required]
        [Column("CPF")]
        public string CPF { get; set; }

        [Required]
        [Column("LOCALIZACAO")]
        public string LOCALIZACAO { get; set; }
    }
}


