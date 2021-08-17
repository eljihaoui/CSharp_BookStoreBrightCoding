using System.Configuration;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookStore.ModelsDB
{
    public partial class bcBookStoreContext : DbContext
    {
        public bcBookStoreContext()
        {
        }

        public bcBookStoreContext(DbContextOptions<bcBookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["bookStoreDB"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.IdAuthor)
                    .HasName("PK_AUTHOR");

                entity.ToTable("Author");

                entity.Property(e => e.IdAuthor).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IdBook)
                    .HasName("PK_BOOK");

                entity.ToTable("Book");

                entity.Property(e => e.IdBook).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DescBook)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NbPages).HasColumnName("nbPages");

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdAuthor)
                    .HasConstraintName("FK_BOOK_ECRIT_PAR_AUTHOR");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdCateg)
                    .HasConstraintName("FK_BOOK_AVOIR_CATEGORY");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCateg)
                    .HasName("PK_CATEGORY");

                entity.ToTable("Category");

                entity.Property(e => e.IdCateg).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Categ)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
