using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("AxParticipanteAtividade")]  
    public class AxParticipanteAtividade
    {
        [Key]
        [Column ("Atividade")]
        [Display (Name = "Atividade")]
      
        public string Atividade { get; set; }   
    }
}
