using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("Participantes")]
    public class Participantes
    {
        [Key]
        [Column("CodPar")]
        [Display(Name = "Identificação")]
        public string? CodPar { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("DataCriação")]
        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Column("DataAtualização")]
        [Display(Name = "Data Atualização")]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }
    }
}
