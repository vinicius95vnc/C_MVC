using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("Participantes")]
    public class Participantes
    {
        [Key]
        [Column("CodPar")]
        [DisplayName("Identificação")]
        public string? CodPar { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [Column("DataCriação")]
        [DisplayName("Data Criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Column("DataAtualização")]
        [DisplayName("Data Atualização")]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        [Column("Telefone")]
        [DisplayName("Telefone")]
        public string? Telefone { get; set; }

        [Column("Usuario")]
        [DisplayName("Usuário")]
        public string Usuario { get; set; }
    }
}
