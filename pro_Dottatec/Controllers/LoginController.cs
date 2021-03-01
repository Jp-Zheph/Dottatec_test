using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pro_Dottatec.Data;
using pro_Dottatec.Helpers;
using pro_Dottatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro_Dottatec.Controllers
{
	public class LoginController : Controller
	{
		private readonly pro_DottatecContext _context;
		private readonly IHttpContextAccessor _httpContext;

		public LoginController(pro_DottatecContext context , IHttpContextAccessor httpContext)
		{
			_context = context;
			_httpContext = httpContext;
		}


		public IActionResult Index(int? id)
		{
			if(id != null)
			{
				if(id == 0)
				{
					_httpContext.HttpContext.Session.Clear();
				}
			}
			return View();
		}

		[HttpPost]
		public IActionResult Index(Login model)
		{
			ViewData["ErrorLogin"] = string.Empty;
			if(ModelState.IsValid)
			{
				var senha = Criptografia.GetMd5Hash(model.Senha);
				var usuario = _context.usuario.Where(x => x.Email == model.Email && x.Senha == model.Senha).FirstOrDefault(); 
				if(usuario == null)
				{
					ViewData["ErrorLogin"] = "O Email ou senha informado não existe no sistema";
					
					return View(model);
				}
				else
				{
					_httpContext.HttpContext.Session.SetString(sessao.Nome_Usuario, usuario.Nome);
					_httpContext.HttpContext.Session.SetString(sessao.Nome_Email_Usuario, usuario.Email);
					_httpContext.HttpContext.Session.SetInt32(sessao.Logado,1);
					
					return RedirectToAction("Index", "usuarios");
				}
			}
			else
			{
				return View(model);
			}			
		}		
	}
}
