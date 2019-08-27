using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controllers.Map
{
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {


            this.ToTable("Usuario");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("ID_USUARIO");
            this.Property(p => p.User).HasColumnName("NOME_USUARIO");
            this.Property(p => p.Senha).HasColumnName("SENHA_USUARIO");
        }
    }
}
