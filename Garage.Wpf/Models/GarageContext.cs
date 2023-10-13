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




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Garage;Trusted_Connexion=True;TrustServerCertificate=True;");
        }


    }
}
