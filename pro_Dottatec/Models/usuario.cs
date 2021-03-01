using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro_Dottatec.Models
{
	public class usuario
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Informe um Nome ")]
		public string Nome { get; set; }

		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		[Required(ErrorMessage = "Informe um e-mail válido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Informe uma senha válida")]
		public string Senha { get; set; }

		[Required(ErrorMessage = "Informe um CPF Válido ")]
		
		public string CPF { get; set; }

		public usuario()
		{

		}

		public usuario(string nome, string email, string senha, string cPF)
		{
			Nome = nome;
			Email = email;
			Senha = senha;
			CPF = cPF;
		}
	}
}
