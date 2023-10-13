using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.Models
{
    /// <summary>
    /// Contexte de la base de données
    /// </summary>
    public class GarageContext : DbContext
    {
        /// <summary>
        /// Liste des marques
        /// </summary>
        public DbSet<Brand> Brands { get; set; }

        /// <summary>
        /// Liste des modèles
        /// </summary>
        public DbSet<Model> Models { get; set; }

        /// <summary>
        /// Liste des voitures
        /// </summary>
        public DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Configure le contexte Garage
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Garage;Trusted_Connexion=True;TrustServerCertificate=True;");
        }
    }
}
