using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("Pacotes")]
    public class Pacotes
    {
        [Key]
        [Column ("Preco")]
        [Display (Name = "Preco")]
        public decimal Preco { get; set; }  

        [Column ("Descricao")]
        [Display (Name = "Descricao")]
        public string Descricao { get; set; }   
    }
}
