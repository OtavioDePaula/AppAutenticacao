using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppAutenticacao.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int UsuarioID { get; set; }

        [Display(Name = "Nome")]
        [Required]
        [MaxLength(100)]
        public string UsuNome { get; set; }

        [Display(Name = "Login")]
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }
    }
}