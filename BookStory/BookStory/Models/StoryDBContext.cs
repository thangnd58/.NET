using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BookStory.Models
{
    public partial class StoryDBContext : DbContext
    {
        public StoryDBContext()
        {
        }

        public StoryDBContext(DbContextOptions<StoryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Reading> Readings { get; set; }
        public virtual DbSet<StoriesAuthor> StoriesAuthors { get; set; }
        public virtual DbSet<StoriesCategory> StoriesCategories { get; set; }
        public virtual DbSet<Story> Stories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=StoryDB;user=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.Aid);

                entity.Property(e => e.Aid)
                    .ValueGeneratedNever()
                    .HasColumnName("aid");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .HasColumnName("keyword");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasKey(e => e.Ctid)
                    .HasName("PK_Chapter");

                entity.Property(e => e.Ctid).HasColumnName("ctid");

                entity.Property(e => e.Chapnumber)
                    .HasMaxLength(255)
                    .HasColumnName("chapnumber");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Subname)
                    .HasMaxLength(255)
                    .HasColumnName("subname");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.Chapters)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chapter_Stories");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Rating");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Rating1).HasColumnName("Rating");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_Rating_Chapters");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK_Rating_Stories");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK_Rating_Users");
            });

            modelBuilder.Entity<Reading>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Reading");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("rid");

                entity.Property(e => e.Ctid).HasColumnName("ctid");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.Readings)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_Reading_Chapters");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.Readings)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK_Reading_User");
            });

            modelBuilder.Entity<StoriesAuthor>(entity =>
            {
                entity.HasKey(e => e.Said);

                entity.ToTable("Stories_Authors");

                entity.Property(e => e.Said)
                    .ValueGeneratedNever()
                    .HasColumnName("said");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.StoriesAuthors)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stories_Authors_Authors");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.StoriesAuthors)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stories_Authors_Stories");
            });

            modelBuilder.Entity<StoriesCategory>(entity =>
            {
                entity.HasKey(e => e.Scid);

                entity.ToTable("Stories_Categories");

                entity.Property(e => e.Scid)
                    .ValueGeneratedNever()
                    .HasColumnName("scid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.StoriesCategories)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stories_Categories_Categories");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.StoriesCategories)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stories_Categories_Stories");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.View).HasColumnName("view");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK_User");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
