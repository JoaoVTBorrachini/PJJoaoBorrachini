using PJJoaoBorrachini.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJJoaoBorrachini.Models
{
    public enum Race
    {
        Asiático,
        Branco,
        Índio,
        Negro,
        Pardo,
        Outros
    }

    public class Psicologo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento requerida.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Formação requerida.")]
        [Display(Name = "Formação")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Raça requerida.")]
        [Display(Name = "Raça")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}