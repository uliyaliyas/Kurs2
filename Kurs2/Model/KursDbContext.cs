using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kurs2.Model;

public partial class KursDbContext : DbContext
{
    public KursDbContext()
    {
    }

    public KursDbContext(DbContextOptions<KursDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Magazine> Magazines { get; set; }

    public virtual DbSet<Rubric> Rubrics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=KursDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("Article");

            entity.Property(e => e.ArticleId).HasColumnName("Article_Id");
            entity.Property(e => e.AuthorId).HasColumnName("Author_Id");
            entity.Property(e => e.MagazineId).HasColumnName("Magazine_Id");
            entity.Property(e => e.NameArticle).HasColumnName("Name_Article");
            entity.Property(e => e.RubricsId).HasColumnName("Rubrics_Id");

            entity.HasOne(d => d.Author).WithMany(p => p.Articles)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Magazine).WithMany(p => p.Articles)
                .HasForeignKey(d => d.MagazineId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Rubrics).WithMany(p => p.Articles)
                .HasForeignKey(d => d.RubricsId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.AuthorId);

            entity.ToTable("Autor");
        });

        modelBuilder.Entity<Magazine>(entity =>
        {
            entity.ToTable("Magazine");

            entity.Property(e => e.MagazineId).HasColumnName("Magazine_Id");
        });

        modelBuilder.Entity<Rubric>(entity =>
        {
            entity.HasKey(e => e.RubricsId);

            entity.ToTable("Rubric");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
