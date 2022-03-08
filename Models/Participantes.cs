using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("Participantes")]
    public class Participantes
    {
        [Key]
        [Column ("CodPar")]
        [Display(Name = "CodPar")]
        public string CodPar { get; set; }

        [Column ("Nome")]
        [Display (Name = "Nome")]
        public string Nome { get; set; } 
        
        [Column ("DataNascimento")]
        [Display(Name = "DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Column ("Telefone")]
        [Display (Name = "Telefone")]
        public string Telefone {  get; set; }
    }
}
