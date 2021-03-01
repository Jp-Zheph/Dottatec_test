using pro_Dottatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro_Dottatec.Data
{
	public class SeedingServices
	{
		private pro_DottatecContext _ctx;
		public SeedingServices(pro_DottatecContext ctx)
		{
			_ctx = ctx;
		}


		public void Seed()
		{
			if(_ctx.usuario.Any())
			{
				return;
			}

			usuario s1 = new usuario ("Testes","admin@admin.com","12345", "05735747070");


			_ctx.usuario.Add(s1);
			_ctx.SaveChanges();
		}

	}
}
