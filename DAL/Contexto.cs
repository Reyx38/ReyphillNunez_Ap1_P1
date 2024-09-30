using Microsoft.EntityFrameworkCore;
using ReyphillNunez_Ap1_P1.Models;

namespace ReyphillNunez_Ap1_P1.DAL;

    public class Contexto : DbContext
    {
        DbSet<Prestamos> Prestamos { get; set; }

		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{
		}
	}

