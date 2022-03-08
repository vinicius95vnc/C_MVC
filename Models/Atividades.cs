using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("Atividades")]
    public class Atividades
    {
        [Key]
        [Column ("CodAtv")]
        [Display (Name = "CodAtv")]
        public string CodAtv { get; set; }  

        [Column ("DescAtv")]
        [Display (Name = "DescAtv")]
        public string DescAtv { get; set; }

        [Column("Vagas")]
        [Display(Name = "Vagas")]
        public int Vagas { get; set; }

        [Column("Preco")]
        [Display(Name = "Preco")]
        public decimal Preco { get; set; }


    }
}
