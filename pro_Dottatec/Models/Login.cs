using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro_Dottatec.Models
{
	public class Login
	{
		[Key]
		public int Id { get; set; }
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		[Required(ErrorMessage = "Informe o seu email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Informe a senha ")]
		public string Senha { get; set; }


		public Login()
		{

		}

		public Login(string email, string senha)
		{
			Email = email;
			Senha = senha;
		}
	}

}
