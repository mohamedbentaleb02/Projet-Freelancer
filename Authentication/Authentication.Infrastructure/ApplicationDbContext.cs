using Freelance.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Freelance.Infrastructure;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedRoles(modelBuilder);
        modelBuilder.Entity<Competence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Competen__3213E83F8016AE91");

            entity.ToTable("Competence");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<CompetenceOffre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Competen__3213E83F51A53AEB");

            entity.ToTable("CompetenceOffre");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdCompetence).HasColumnName("id_competence");
            entity.Property(e => e.IdOffre).HasColumnName("id_Offre");

            entity.HasOne(d => d.IdCompetenceNavigation).WithMany(p => p.CompetenceOffres)
                .HasForeignKey(d => d.IdCompetence)
                .HasConstraintName("FK__Competenc__id_co__619B8048");

            entity.HasOne(d => d.IdOffreNavigation).WithMany(p => p.CompetenceOffres)
                .HasForeignKey(d => d.IdOffre)
                .HasConstraintName("FK__Competenc__id_Of__628FA481");
        });

        modelBuilder.Entity<ComptenceDmExpertise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comptenc__3213E83F1B87D054");

            entity.ToTable("ComptenceDmExpertise");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdCompetence).HasColumnName("id_competence");
            entity.Property(e => e.IdDmexpertise).HasColumnName("id_dmexpertise");

            entity.HasOne(d => d.IdCompetenceNavigation).WithMany(p => p.ComptenceDmExpertises)
                .HasForeignKey(d => d.IdCompetence)
                .HasConstraintName("FK__Comptence__id_co__4222D4EF");

            entity.HasOne(d => d.IdDmexpertiseNavigation).WithMany(p => p.ComptenceDmExpertises)
                .HasForeignKey(d => d.IdDmexpertise)
                .HasConstraintName("FK__Comptence__id_dm__4316F928");
        });

        modelBuilder.Entity<Condidat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Condidat__3213E83F0E35DC80");

            entity.ToTable("Condidat");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.DateNaissance)
                .HasColumnType("date")
                .HasColumnName("date_naissance");
            entity.Property(e => e.Disponibilite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("disponibilite");
            entity.Property(e => e.IdVille).HasColumnName("id_ville");
            entity.Property(e => e.Mobilite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mobilite");
            entity.Property(e => e.Tele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tele");
            entity.Property(e => e.Titre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Condidats)
                .HasForeignKey(d => d.IdVille)
                .HasConstraintName("FK__Condidat__id_vil__38996AB5");
        });

        modelBuilder.Entity<CondidatComp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Condidat__3213E83FAF442B14");

            entity.ToTable("CondidatComp");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdComp).HasColumnName("id_comp");
            entity.Property(e => e.IdCond).HasColumnName("id_cond");
            entity.Property(e => e.Niveau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("niveau");

            entity.HasOne(d => d.IdCompNavigation).WithMany(p => p.CondidatComps)
                .HasForeignKey(d => d.IdComp)
                .HasConstraintName("FK__CondidatC__id_co__5070F446");

            entity.HasOne(d => d.IdCondNavigation).WithMany(p => p.CondidatComps)
                .HasForeignKey(d => d.IdCond)
                .HasConstraintName("FK__CondidatC__id_co__5165187F");
        });

        modelBuilder.Entity<ConsultaionProfil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consulta__3213E83F93C2C409");

            entity.ToTable("ConsultaionProfil");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateConsultation)
                .HasColumnType("date")
                .HasColumnName("date_consultation");
            entity.Property(e => e.IdCondidat).HasColumnName("id_condidat");
            entity.Property(e => e.IdEntreprise).HasColumnName("id_entreprise");

            entity.HasOne(d => d.IdCondidatNavigation).WithMany(p => p.ConsultaionProfils)
                .HasForeignKey(d => d.IdCondidat)
                .HasConstraintName("FK__Consultai__id_co__5441852A");

            entity.HasOne(d => d.IdEntrepriseNavigation).WithMany(p => p.ConsultaionProfils)
                .HasForeignKey(d => d.IdEntreprise)
                .HasConstraintName("FK__Consultai__id_en__5535A963");
        });

        modelBuilder.Entity<DomaineExpertise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DomaineE__3213E83FA948D570");

            entity.ToTable("DomaineExpertise");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Entreprise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entrepri__3213E83FBF39B25F");

            entity.ToTable("Entreprise");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("date_creation");
            entity.Property(e => e.IdVille).HasColumnName("id_ville");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("raison_sociale");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Entreprises)
                .HasForeignKey(d => d.IdVille)
                .HasConstraintName("FK__Entrepris__id_vi__3B75D760");
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Experien__3213E83FDFDF460E");

            entity.ToTable("Experience");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateDebut)
                .HasColumnType("date")
                .HasColumnName("date_debut");
            entity.Property(e => e.DateFin)
                .HasColumnType("date")
                .HasColumnName("date_fin");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description_");
            entity.Property(e => e.IdCondidat).HasColumnName("id_condidat");
            entity.Property(e => e.IdVille).HasColumnName("id_ville");
            entity.Property(e => e.Local)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("local_");
            entity.Property(e => e.Titre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdCondidatNavigation).WithMany(p => p.Experiences)
                .HasForeignKey(d => d.IdCondidat)
                .HasConstraintName("FK__Experienc__id_co__46E78A0C");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Experiences)
                .HasForeignKey(d => d.IdVille)
                .HasConstraintName("FK__Experienc__id_vi__45F365D3");
        });

        modelBuilder.Entity<Formation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formatio__3213E83F9AD22692");

            entity.ToTable("Formation");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateDebut)
                .HasColumnType("date")
                .HasColumnName("date_debut");
            entity.Property(e => e.DateFin)
                .HasColumnType("date")
                .HasColumnName("date_fin");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description_");
            entity.Property(e => e.Ecole)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ecole");
            entity.Property(e => e.IdCondidat).HasColumnName("id_condidat");
            entity.Property(e => e.IdVille).HasColumnName("id_ville");
            entity.Property(e => e.Niveau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("niveau");

            entity.HasOne(d => d.IdCondidatNavigation).WithMany(p => p.Formations)
                .HasForeignKey(d => d.IdCondidat)
                .HasConstraintName("FK__Formation__id_co__4AB81AF0");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Formations)
                .HasForeignKey(d => d.IdVille)
                .HasConstraintName("FK__Formation__id_vi__49C3F6B7");
        });

        modelBuilder.Entity<Messagerie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Messager__3213E83FB632B91A");

            entity.ToTable("Messagerie");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateMsg)
                .HasColumnType("date")
                .HasColumnName("date_msg");
            entity.Property(e => e.DestinataireId).HasColumnName("destinataire_id");
            entity.Property(e => e.ExpediteurId).HasColumnName("expediteur_id");
            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("msg");

            entity.HasOne(d => d.Expediteur).WithMany(p => p.Messageries)
                .HasForeignKey(d => d.ExpediteurId)
                .HasConstraintName("FK__Messageri__exped__5812160E");

            entity.HasOne(d => d.ExpediteurNavigation).WithMany(p => p.Messageries)
                .HasForeignKey(d => d.ExpediteurId)
                .HasConstraintName("FK__Messageri__exped__59063A47");
        });

        modelBuilder.Entity<ModeTravail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModeTrav__3213E83F9D7319CC");

            entity.ToTable("ModeTravail");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Offre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Offre__3213E83F208C604A");

            entity.ToTable("Offre");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DatePub)
                .HasColumnType("date")
                .HasColumnName("date_pub");
            entity.Property(e => e.Descrpition)
                .HasColumnType("text")
                .HasColumnName("descrpition");
            entity.Property(e => e.Dure)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dure");
            entity.Property(e => e.IdModetravail).HasColumnName("id_modetravail");
            entity.Property(e => e.IdVille).HasColumnName("id_ville");
            entity.Property(e => e.Titre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdModetravailNavigation).WithMany(p => p.Offres)
                .HasForeignKey(d => d.IdModetravail)
                .HasConstraintName("FK__Offre__id_modetr__5EBF139D");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Offres)
                .HasForeignKey(d => d.IdVille)
                .HasConstraintName("FK__Offre__id_ville__5DCAEF64");
        });

        modelBuilder.Entity<Projet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projet__3213E83FD52ABFF2");

            entity.ToTable("Projet");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description_");
            entity.Property(e => e.IdCondidat).HasColumnName("id_condidat");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");

            entity.HasOne(d => d.IdCondidatNavigation).WithMany(p => p.Projets)
                .HasForeignKey(d => d.IdCondidat)
                .HasConstraintName("FK__Projet__id_condi__4D94879B");
        });

        modelBuilder.Entity<Ville>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ville__3213E83FC203427C");

            entity.ToTable("Ville");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

    }

    public virtual DbSet<Competence> Competences { get; set; }

    public virtual DbSet<CompetenceOffre> CompetenceOffres { get; set; }

    public virtual DbSet<ComptenceDmExpertise> ComptenceDmExpertises { get; set; }

    public virtual DbSet<Condidat> Condidats { get; set; }

    public virtual DbSet<CondidatComp> CondidatComps { get; set; }

    public virtual DbSet<ConsultaionProfil> ConsultaionProfils { get; set; }

    public virtual DbSet<DomaineExpertise> DomaineExpertises { get; set; }

    public virtual DbSet<Entreprise> Entreprises { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Formation> Formations { get; set; }

    public virtual DbSet<Messagerie> Messageries { get; set; }

    public virtual DbSet<ModeTravail> ModeTravails { get; set; }

    public virtual DbSet<Offre> Offres { get; set; }

    public virtual DbSet<Projet> Projets { get; set; }

    public virtual DbSet<Ville> Villes { get; set; }

    private static void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData
            (
            new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
            new IdentityRole() { Name = "Candidat", ConcurrencyStamp = "2", NormalizedName = "CANDIDAT" },
            new IdentityRole() { Name = "Entreprise", ConcurrencyStamp = "3", NormalizedName = "ENTREPRISE" }
            );
    }
}
