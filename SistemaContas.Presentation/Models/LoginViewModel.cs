﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SistemaContas.Presentation.Models.Account
{
    /// <summary>
    /// Modelo de dados para o formulário de login de usuário
    /// </summary>
    public class LoginViewModel 
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe seu email de acesso.")]

        public string? Email { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso.")]
    public string? Senha { get; set; }
    }
}
