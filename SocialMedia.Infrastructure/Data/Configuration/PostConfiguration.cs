using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Domain.Entities;

namespace SocialMedia.Infrastructure.Data.Configuration
{
  public class PostConfiguration : IEntityTypeConfiguration<Post>
  {
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(e => e.PostId);

        builder.ToTable("Publicacion");

        builder.Property(e => e.PostId)
            .HasColumnName("IdPublicacion");
        
        builder.Property(e => e.UserId)
            .HasColumnName("IdUsuario")
            .ValueGeneratedNever();

        builder.Property(e => e.Description)
            .IsRequired()
            .HasColumnName("Descripcion")
            .HasMaxLength(1000)
            .IsUnicode(false);

        builder.Property(e => e.Date)
            .HasColumnName("Fecha")
            .HasColumnType("datetime");

        builder.Property(e => e.Image)
            .HasColumnName("Imagen")
            .HasMaxLength(500)
            .IsUnicode(false);

        builder.HasOne(d => d.User)
            .WithMany(p => p.Posts)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Publicacion_Usuario");
    }
  }
}