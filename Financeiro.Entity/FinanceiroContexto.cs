using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Entity
{
    public class FinanceiroContexto : DbContext
    {
        public override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapReceita = modelBuilder.Entity<Receita>();
            mapReceita.Property(x => x.Receita_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapReceita.Property(x => x.Nome)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(150);
            mapReceita.Property(x => x.Valor)
                .IsRequired();
            mapReceita.Property(x => x.Categoria)
                .IsRequired();
            mapReceita.Property(x => x.Data)
                .IsRequired();
            mapReceita.Property(x => x.Observacao)
                .IsVariableLength()
                .HasMaxLength(250);
            mapReceita.HasKey(x => x.Receita_Id);
            mapReceita.ToTable("Receita");

            var mapDespesa = modelBuilder.Entity<Despesa>();
            mapDespesa.Property(x => x.Despesa_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapDespesa.Property(x => x.Nome)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(150);
            mapDespesa.Property(x => x.Valor)
                .IsRequired();
            mapDespesa.Property(x => x.Categoria)
                .IsRequired();
            mapDespesa.Property(x => x.Data)
                .IsRequired();
            mapDespesa.Property(x => x.Observacao)
                .IsVariableLength()
                .HasMaxLength(250);
            mapDespesa.HasKey(x => x.Despesa_Id);
            mapDespesa.ToTable("Despesa");
        }
    }
}
