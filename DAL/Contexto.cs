using Microsoft.EntityFrameworkCore;
using ReyphillNunez_Ap1_P1.Models;

namespace ReyphillNunez_Ap1_P1.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Prestamos> Prestamos { get; set; }
	public DbSet<Deudores> Deudores { get; set; }
	public DbSet<Cobros> Cobros { get; set; }
	public DbSet<CobrosDetalles> CobrosDetalles { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Deudores>().HasData(new List<Deudores>()
		{
			new Deudores() { DeudoresId = 1, Nombres = "Juan perez" },
			new Deudores() { DeudoresId = 2, Nombres = "Alaina Garcia" },
			new Deudores() { DeudoresId = 3, Nombres = "Reyphill Nuñez" }

		});
	}
}

