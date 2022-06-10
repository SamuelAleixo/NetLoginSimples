using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetLoginSimples.Areas.Identity.Data;

namespace NetLoginSimples.Areas.Identity.Data;

public class AplicacaoDbContext : IdentityDbContext<AplicacaoUser>
{
    public AplicacaoDbContext(DbContextOptions<AplicacaoDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.ApplyConfiguration(new AplicacaoUserEntityConfiguration());
     
    }
}


public class AplicacaoUserEntityConfiguration : IEntityTypeConfiguration<AplicacaoUser>
{
    public void Configure(EntityTypeBuilder<AplicacaoUser> builder)
    {
        
        builder.Property(u => u.Nome).HasMaxLength(255);
        builder.Property(u => u.Sobrenome).HasMaxLength(255);
    }
}