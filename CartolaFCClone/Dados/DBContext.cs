using CartolaFCClone.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaFCClone.Dados
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=127.0.0.1;port=3306;database=cartola_fc;uid=root;password=";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        //Mepeamento das tabelas a serem usadas
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TimeCartoleiro> TimeCartoleiros { get; set; }
        public DbSet<Time> Times { get; set; }
    }
}
