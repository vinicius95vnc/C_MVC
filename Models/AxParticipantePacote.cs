using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    [Table("AxParticipantePacote")]
    public class AxParticipantePacote
    {
        [Key]
        [Column ("Pacote")]
        [Display (Name = "Pacote")]
        public string Pacote { get; set; }  
    }
}
