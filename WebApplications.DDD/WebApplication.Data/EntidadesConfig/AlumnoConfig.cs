using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Dominio.Entidades;

namespace WebApplication.Data.EntidadesConfig
{
    public class AlumnoConfig : EntityTypeConfiguration<Alumno>
    {
        public AlumnoConfig()
        {
            HasKey(c => c.ID_Alumno);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
