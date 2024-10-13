using Microsoft.EntityFrameworkCore;
using ReyphillNunez_Ap1_P1.DAL;
using ReyphillNunez_Ap1_P1.Models;
using System.Linq.Expressions;

namespace ReyphillNunez_Ap1_P1.Services
{
	public class DeudorServices(Contexto contexto)
	{
		private readonly Contexto _contexto = contexto;

		public async Task<List<Deudores>> Listar(Expression<Func<Deudores,bool>> criterio)
		{
			return await _contexto.Deudores
				.AsNoTracking().Where(criterio)
				.ToListAsync();
		}
	}
}
