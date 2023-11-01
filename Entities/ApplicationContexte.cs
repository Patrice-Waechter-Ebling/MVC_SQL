using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_SQL.Entities;

public partial class ApplicationContexte : DbContext
{
    public ApplicationContexte()
    {
    }

    public ApplicationContexte(DbContextOptions<ApplicationContexte> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleclaim> AspNetRoleclaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUsersclaim> AspNetUsersclaims { get; set; }

    public virtual DbSet<AspNetUserslogin> AspNetUserslogins { get; set; }

    public virtual DbSet<AspNetUsersrole> AspNetUsersroles { get; set; }

    public virtual DbSet<AspNetUserstoken> AspNetUserstokens { get; set; }

    public virtual DbSet<ContactGrb> ContactGrbs { get; set; }

    public virtual DbSet<ContactPermaRoute> ContactPermaRoutes { get; set; }

    public virtual DbSet<GrbAchat> GrbAchats { get; set; }

    public virtual DbSet<GrbAchatPiece> GrbAchatPieces { get; set; }

    public virtual DbSet<GrbAchatPiecesTampon> GrbAchatPiecesTampons { get; set; }

    public virtual DbSet<GrbAlarme> GrbAlarmes { get; set; }

    public virtual DbSet<GrbAutorisationPunch> GrbAutorisationPunches { get; set; }

    public virtual DbSet<GrbBavardSuppression> GrbBavardSuppressions { get; set; }

    public virtual DbSet<GrbBonsCommande> GrbBonsCommandes { get; set; }

    public virtual DbSet<GrbBonsCommandesPiece> GrbBonsCommandesPieces { get; set; }

    public virtual DbSet<GrbCatalogueElec> GrbCatalogueElecs { get; set; }

    public virtual DbSet<GrbCatalogueMec> GrbCatalogueMecs { get; set; }

    public virtual DbSet<GrbCedule> GrbCedules { get; set; }

    public virtual DbSet<GrbClient> GrbClients { get; set; }

    public virtual DbSet<GrbCommentaire> GrbCommentaires { get; set; }

    public virtual DbSet<GrbConfig> GrbConfigs { get; set; }

    public virtual DbSet<GrbContact> GrbContacts { get; set; }

    public virtual DbSet<GrbContactClient> GrbContactClients { get; set; }

    public virtual DbSet<GrbContactFr> GrbContactFrs { get; set; }

    public virtual DbSet<GrbDessin> GrbDessins { get; set; }

    public virtual DbSet<GrbDoublon> GrbDoublons { get; set; }

    public virtual DbSet<GrbEmploye> GrbEmployes { get; set; }

    public virtual DbSet<GrbErreur> GrbErreurs { get; set; }

    public virtual DbSet<GrbExceptionsDl> GrbExceptionsDls { get; set; }

    public virtual DbSet<GrbFamille> GrbFamilles { get; set; }

    public virtual DbSet<GrbFournisseur> GrbFournisseurs { get; set; }

    public virtual DbSet<GrbGroupe> GrbGroupes { get; set; }

    public virtual DbSet<GrbImpressionBonlivraison> GrbImpressionBonlivraisons { get; set; }

    public virtual DbSet<GrbImpressionDemandePrixElec> GrbImpressionDemandePrixElecs { get; set; }

    public virtual DbSet<GrbImpressionDemandePrixMec> GrbImpressionDemandePrixMecs { get; set; }

    public virtual DbSet<GrbImpressionDetailTemp> GrbImpressionDetailTemps { get; set; }

    public virtual DbSet<GrbImpressionListePiece> GrbImpressionListePieces { get; set; }

    public virtual DbSet<GrbImpressionPoste> GrbImpressionPostes { get; set; }

    public virtual DbSet<GrbImpressionPunch> GrbImpressionPunches { get; set; }

    public virtual DbSet<GrbImpressionSommairePunchGeneral> GrbImpressionSommairePunchGenerals { get; set; }

    public virtual DbSet<GrbImpressionSommairePunchGrb> GrbImpressionSommairePunchGrbs { get; set; }

    public virtual DbSet<GrbImpressionSoumission> GrbImpressionSoumissions { get; set; }

    public virtual DbSet<GrbInventaireElec> GrbInventaireElecs { get; set; }

    public virtual DbSet<GrbInventaireElecModif> GrbInventaireElecModifs { get; set; }

    public virtual DbSet<GrbInventaireMec> GrbInventaireMecs { get; set; }

    public virtual DbSet<GrbInventaireMecModif> GrbInventaireMecModifs { get; set; }

    public virtual DbSet<GrbNombreMeat> GrbNombreMeats { get; set; }

    public virtual DbSet<GrbOutil> GrbOutils { get; set; }

    public virtual DbSet<GrbOutilsInOut> GrbOutilsInOuts { get; set; }

    public virtual DbSet<GrbPiecesFr> GrbPiecesFrs { get; set; }

    public virtual DbSet<GrbProjSoum> GrbProjSoums { get; set; }

    public virtual DbSet<GrbProjetDessin> GrbProjetDessins { get; set; }

    public virtual DbSet<GrbProjetElec> GrbProjetElecs { get; set; }

    public virtual DbSet<GrbProjetMec> GrbProjetMecs { get; set; }

    public virtual DbSet<GrbProjetModif> GrbProjetModifs { get; set; }

    public virtual DbSet<GrbProjetPiece> GrbProjetPieces { get; set; }

    public virtual DbSet<GrbProjetPiecesTampon> GrbProjetPiecesTampons { get; set; }

    public virtual DbSet<GrbProjetsDessin> GrbProjetsDessins { get; set; }

    public virtual DbSet<GrbPunch> GrbPunches { get; set; }

    public virtual DbSet<GrbPunchExcel> GrbPunchExcels { get; set; }

    public virtual DbSet<GrbSortieMateriel> GrbSortieMateriels { get; set; }

    public virtual DbSet<GrbSoumProjSectionElec> GrbSoumProjSectionElecs { get; set; }

    public virtual DbSet<GrbSoumProjSectionMec> GrbSoumProjSectionMecs { get; set; }

    public virtual DbSet<GrbSoumissionElec> GrbSoumissionElecs { get; set; }

    public virtual DbSet<GrbSoumissionMec> GrbSoumissionMecs { get; set; }

    public virtual DbSet<GrbSoumissionModif> GrbSoumissionModifs { get; set; }

    public virtual DbSet<GrbSoumissionPiece> GrbSoumissionPieces { get; set; }

    public virtual DbSet<GrbSoumissionPiecesTampon> GrbSoumissionPiecesTampons { get; set; }

    public virtual DbSet<GrbTempDp> GrbTempDps { get; set; }

    public virtual DbSet<GrbTempInventaire> GrbTempInventaires { get; set; }

    public virtual DbSet<GrbTransport> GrbTransports { get; set; }

    public virtual DbSet<GrbVendeur> GrbVendeurs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<NetRole> NetRoles { get; set; }

    public virtual DbSet<NetUser> NetUsers { get; set; }

    public virtual DbSet<Outlook> Outlooks { get; set; }

    public virtual DbSet<ProjetPieceBack> ProjetPieceBacks { get; set; }

    public virtual DbSet<ProjetTamponBack> ProjetTamponBacks { get; set; }

    public virtual DbSet<TableDesErreur> TableDesErreurs { get; set; }

    public virtual DbSet<TblCategorie> TblCategories { get; set; }

    public virtual DbSet<TblPunchType> TblPunchTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=GRB2023;Integrated Security=True;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetro__3213E83F7C9A5DE7");

            entity.ToTable("AspNetRole");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concurrencystamp)
                .HasMaxLength(50)
                .HasColumnName("concurrencystamp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Normalizedname)
                .HasMaxLength(50)
                .HasColumnName("normalizedname");
        });

        modelBuilder.Entity<AspNetRoleclaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetro__3213E83FDA1B5C68");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Claimtype)
                .HasMaxLength(50)
                .HasColumnName("claimtype");
            entity.Property(e => e.Claimvalue)
                .HasMaxLength(1)
                .HasColumnName("claimvalue");
            entity.Property(e => e.Roleid).HasColumnName("roleid");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetRoleclaim)
                .HasForeignKey<AspNetRoleclaim>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetrol__rolei__39E294A9");
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetus__3213E83F44FC4894");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accessfailedcount).HasColumnName("accessfailedcount");
            entity.Property(e => e.Concurrencystamp)
                .HasMaxLength(50)
                .HasColumnName("concurrencystamp");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Emailconfirmed).HasColumnName("emailconfirmed");
            entity.Property(e => e.Lockoutenabled).HasColumnName("lockoutenabled");
            entity.Property(e => e.Lockoutend)
                .HasColumnType("datetime")
                .HasColumnName("lockoutend");
            entity.Property(e => e.Normalizedemail)
                .HasMaxLength(50)
                .HasColumnName("normalizedemail");
            entity.Property(e => e.Normalizedusername)
                .HasMaxLength(50)
                .HasColumnName("normalizedusername");
            entity.Property(e => e.Passwordhash)
                .HasMaxLength(50)
                .HasColumnName("passwordhash");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(50)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Phonenumberconfirmed).HasColumnName("phonenumberconfirmed");
            entity.Property(e => e.Securitystamp)
                .HasMaxLength(50)
                .HasColumnName("securitystamp");
            entity.Property(e => e.Twofactorenabled).HasColumnName("twofactorenabled");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AspNetUsersclaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetus__3213E83FF85A1F5D");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Claimtype)
                .HasMaxLength(50)
                .HasColumnName("claimtype");
            entity.Property(e => e.Claimvalue)
                .HasMaxLength(1)
                .HasColumnName("claimvalue");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetUsersclaim)
                .HasForeignKey<AspNetUsersclaim>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetuse__useri__3CBF0154");
        });

        modelBuilder.Entity<AspNetUserslogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetus__3213E83FB795AB6D");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Loginprovider)
                .HasMaxLength(128)
                .HasColumnName("loginprovider");
            entity.Property(e => e.Providerdisplayname)
                .HasMaxLength(50)
                .HasColumnName("providerdisplayname");
            entity.Property(e => e.Providerkey)
                .HasMaxLength(128)
                .HasColumnName("providerkey");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetUserslogin)
                .HasForeignKey<AspNetUserslogin>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetuse__useri__3F9B6DFF");
        });

        modelBuilder.Entity<AspNetUsersrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetus__3213E83FD6AC67BF");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetUsersrole)
                .HasForeignKey<AspNetUsersrole>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetuse__rolei__436BFEE3");

            entity.HasOne(d => d.Id1).WithOne(p => p.AspNetUsersrole)
                .HasForeignKey<AspNetUsersrole>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetuse__useri__4277DAAA");
        });

        modelBuilder.Entity<AspNetUserstoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aspnetus__3213E83FFD7D2765");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Loginprovider)
                .HasMaxLength(128)
                .HasColumnName("loginprovider");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Value)
                .HasMaxLength(1)
                .HasColumnName("value");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetUserstoken)
                .HasForeignKey<AspNetUserstoken>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnetuse__useri__46486B8E");
        });

        modelBuilder.Entity<ContactGrb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contact___3214EC27DD33E1EE");

            entity.ToTable("Contact_GRB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Celluraire)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Courriel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContactPermaRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contact___3214EC278DCACB4C");

            entity.ToTable("Contact_PermaRoute");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cellulaire)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Courriel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Poste)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GrbAchat>(entity =>
        {
            entity.ToTable("GrbAchat");
        });

        modelBuilder.Entity<GrbAchatPiece>(entity =>
        {
            entity.ToTable("GrbAchatPiece");
        });

        modelBuilder.Entity<GrbAchatPiecesTampon>(entity =>
        {
            entity.ToTable("GrbAchatPiecesTampon");
        });

        modelBuilder.Entity<GrbAlarme>(entity =>
        {
            entity.ToTable("GrbAlarme");
        });

        modelBuilder.Entity<GrbAutorisationPunch>(entity =>
        {
            entity.ToTable("GrbAutorisationPunch");
        });

        modelBuilder.Entity<GrbBavardSuppression>(entity =>
        {
            entity.ToTable("GrbBavardSuppression");
        });

        modelBuilder.Entity<GrbBonsCommande>(entity =>
        {
            entity.ToTable("GrbBonsCommande");
        });

        modelBuilder.Entity<GrbBonsCommandesPiece>(entity =>
        {
            entity.ToTable("GrbBonsCommandesPiece");
        });

        modelBuilder.Entity<GrbCatalogueElec>(entity =>
        {
            entity.ToTable("GrbCatalogueElec");
        });

        modelBuilder.Entity<GrbCatalogueMec>(entity =>
        {
            entity.ToTable("GrbCatalogueMec");
        });

        modelBuilder.Entity<GrbCedule>(entity =>
        {
            entity.ToTable("GrbCedule");
        });

        modelBuilder.Entity<GrbClient>(entity =>
        {
            entity.ToTable("GrbClient");
        });

        modelBuilder.Entity<GrbCommentaire>(entity =>
        {
            entity.ToTable("GrbCommentaire");
        });

        modelBuilder.Entity<GrbConfig>(entity =>
        {
            entity.ToTable("GrbConfig");
        });

        modelBuilder.Entity<GrbContact>(entity =>
        {
            entity.ToTable("GrbContact");

            entity.Property(e => e.Email).HasColumnName("EMail");
        });

        modelBuilder.Entity<GrbContactClient>(entity =>
        {
            entity.ToTable("GrbContactClient");
        });

        modelBuilder.Entity<GrbContactFr>(entity =>
        {
            entity.ToTable("GrbContactFr");
        });

        modelBuilder.Entity<GrbDessin>(entity =>
        {
            entity.ToTable("GrbDessin");
        });

        modelBuilder.Entity<GrbDoublon>(entity =>
        {
            entity.ToTable("GrbDoublon");
        });

        modelBuilder.Entity<GrbEmploye>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GrbEmplo__3214EC27DEFC34C3");

            entity.ToTable("GrbEmploye");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cell)
                .HasMaxLength(50)
                .HasColumnName("cell");
            entity.Property(e => e.Employe)
                .HasMaxLength(50)
                .HasColumnName("employe");
            entity.Property(e => e.Groupe).HasColumnName("groupe");
            entity.Property(e => e.Initiale)
                .HasMaxLength(50)
                .HasColumnName("initiale");
            entity.Property(e => e.Loginname)
                .HasMaxLength(50)
                .HasColumnName("loginname");
            entity.Property(e => e.Page)
                .HasMaxLength(50)
                .HasColumnName("page");
            entity.Property(e => e.Passwd)
                .HasMaxLength(50)
                .HasColumnName("passwd");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("tel");
        });

        modelBuilder.Entity<GrbErreur>(entity =>
        {
            entity.ToTable("GrbErreur");
        });

        modelBuilder.Entity<GrbExceptionsDl>(entity =>
        {
            entity.ToTable("GrbExceptionsDl");
        });

        modelBuilder.Entity<GrbFamille>(entity =>
        {
            entity.ToTable("GrbFamille");
        });

        modelBuilder.Entity<GrbFournisseur>(entity =>
        {
            entity.ToTable("GrbFournisseur");

            entity.Property(e => e.Email).HasColumnName("EMail");
        });

        modelBuilder.Entity<GrbGroupe>(entity =>
        {
            entity.ToTable("GrbGroupe");
        });

        modelBuilder.Entity<GrbImpressionBonlivraison>(entity =>
        {
            entity.ToTable("GrbImpressionBonlivraison");
        });

        modelBuilder.Entity<GrbImpressionDemandePrixElec>(entity =>
        {
            entity.ToTable("GrbImpressionDemandePrixElec");
        });

        modelBuilder.Entity<GrbImpressionDemandePrixMec>(entity =>
        {
            entity.ToTable("GrbImpressionDemandePrixMec");
        });

        modelBuilder.Entity<GrbImpressionDetailTemp>(entity =>
        {
            entity.ToTable("GrbImpressionDetailTemp");
        });

        modelBuilder.Entity<GrbImpressionListePiece>(entity =>
        {
            entity.ToTable("GrbImpressionListePiece");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<GrbImpressionPoste>(entity =>
        {
            entity.ToTable("GrbImpressionPoste");
        });

        modelBuilder.Entity<GrbImpressionPunch>(entity =>
        {
            entity.ToTable("GrbImpressionPunch");
        });

        modelBuilder.Entity<GrbImpressionSommairePunchGeneral>(entity =>
        {
            entity.ToTable("GrbImpressionSommairePunchGeneral");
        });

        modelBuilder.Entity<GrbImpressionSommairePunchGrb>(entity =>
        {
            entity.ToTable("GrbImpressionSommairePunchGrb");
        });

        modelBuilder.Entity<GrbImpressionSoumission>(entity =>
        {
            entity.ToTable("GrbImpressionSoumission");
        });

        modelBuilder.Entity<GrbInventaireElec>(entity =>
        {
            entity.ToTable("GrbInventaireElec");
        });

        modelBuilder.Entity<GrbInventaireElecModif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GrbInventaireElecModif");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(255)
                .HasColumnName("IDProjet");
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.Quantité).HasMaxLength(50);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbInventaireMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GrbInventaireMec");

            entity.Property(e => e.Commande).HasMaxLength(50);
            entity.Property(e => e.Commentaires).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DeviseMonétaire).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Localisation).HasMaxLength(50);
            entity.Property(e => e.Manufacturier).HasMaxLength(50);
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.PrixListe)
                .HasMaxLength(50)
                .HasColumnName("Prix Liste");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix net");
            entity.Property(e => e.QteBoite).HasMaxLength(50);
            entity.Property(e => e.QuantitéCommandée).HasMaxLength(50);
            entity.Property(e => e.QuantitéMinimum).HasMaxLength(50);
            entity.Property(e => e.QuantitéStock).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbInventaireMecModif>(entity =>
        {
            entity.ToTable("GrbInventaireMecModif");
        });

        modelBuilder.Entity<GrbNombreMeat>(entity =>
        {
            entity.Property(e => e.Email).HasColumnName("EMail");
        });

        modelBuilder.Entity<GrbOutil>(entity =>
        {
            entity.ToTable("GrbOutil");
        });

        modelBuilder.Entity<GrbOutilsInOut>(entity =>
        {
            entity.ToTable("GrbOutilsInOut");
        });

        modelBuilder.Entity<GrbPiecesFr>(entity =>
        {
            entity.ToTable("GrbPiecesFr");
        });

        modelBuilder.Entity<GrbProjSoum>(entity =>
        {
            entity.ToTable("GrbProjSoum");
        });

        modelBuilder.Entity<GrbProjetElec>(entity =>
        {
            entity.ToTable("GrbProjetElec");
        });

        modelBuilder.Entity<GrbProjetMec>(entity =>
        {
            entity.ToTable("GrbProjetMec");
        });

        modelBuilder.Entity<GrbProjetModif>(entity =>
        {
            entity.ToTable("GrbProjetModif");
        });

        modelBuilder.Entity<GrbProjetPiece>(entity =>
        {
            entity.ToTable("GrbProjetPiece");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<GrbProjetPiecesTampon>(entity =>
        {
            entity.ToTable("GrbProjetPiecesTampon");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<GrbProjetsDessin>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NoProjet).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbPunch>(entity =>
        {
            entity.ToTable("GrbPunch");
        });

        modelBuilder.Entity<GrbPunchExcel>(entity =>
        {
            entity.ToTable("GrbPunchExcel");
        });

        modelBuilder.Entity<GrbSortieMateriel>(entity =>
        {
            entity.ToTable("GrbSortieMateriel");
        });

        modelBuilder.Entity<GrbSoumProjSectionElec>(entity =>
        {
            entity.ToTable("GrbSoumProjSectionElec");
        });

        modelBuilder.Entity<GrbSoumProjSectionMec>(entity =>
        {
            entity.ToTable("GrbSoumProjSectionMec");
        });

        modelBuilder.Entity<GrbSoumissionElec>(entity =>
        {
            entity.ToTable("GrbSoumissionElec");
        });

        modelBuilder.Entity<GrbSoumissionMec>(entity =>
        {
            entity.ToTable("GrbSoumissionMec");
        });

        modelBuilder.Entity<GrbSoumissionModif>(entity =>
        {
            entity.ToTable("GrbSoumissionModif");
        });

        modelBuilder.Entity<GrbSoumissionPiece>(entity =>
        {
            entity.ToTable("GrbSoumissionPiece");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<GrbSoumissionPiecesTampon>(entity =>
        {
            entity.ToTable("GrbSoumissionPiecesTampon");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<GrbTempDp>(entity =>
        {
            entity.ToTable("GrbTempDp");
        });

        modelBuilder.Entity<GrbTempInventaire>(entity =>
        {
            entity.ToTable("GrbTempInventaire");
        });

        modelBuilder.Entity<GrbTransport>(entity =>
        {
            entity.ToTable("GrbTransport");
        });

        modelBuilder.Entity<GrbVendeur>(entity =>
        {
            entity.ToTable("GrbVendeur");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__@_Menu__3214EC279AB7CB6E");

            entity.ToTable("@_Menu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NormalizedName).HasMaxLength(50);
        });

        modelBuilder.Entity<NetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NetRoles__3214EC07C8027840");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NormalizedName).HasMaxLength(80);
        });

        modelBuilder.Entity<NetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NetUsers__3214EC07D6E5CA20");

            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(50);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SecurityStamp).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(24);

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.NetUsers)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NetUsers__Role__603D47BB");
        });

        modelBuilder.Entity<Outlook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Outlook__3214EC2725002DB6");

            entity.ToTable("Outlook");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cellulaire).HasMaxLength(100);
            entity.Property(e => e.Compagnie).HasMaxLength(100);
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasColumnName("E-mail");
            entity.Property(e => e.EntryIdoutlook).HasColumnName("EntryIDOutlook");
            entity.Property(e => e.NomContact).HasMaxLength(100);
            entity.Property(e => e.Noposte)
                .HasMaxLength(15)
                .HasColumnName("noposte");
            entity.Property(e => e.Telephonne).HasMaxLength(100);
        });

        modelBuilder.Entity<ProjetPieceBack>(entity =>
        {
            entity.ToTable("ProjetPieceBack");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<ProjetTamponBack>(entity =>
        {
            entity.ToTable("ProjetTamponBack");

            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<TableDesErreur>(entity =>
        {
            entity.ToTable("TableDesErreur");
        });

        modelBuilder.Entity<TblCategorie>(entity =>
        {
            entity.ToTable("TblCategorie");
        });

        modelBuilder.Entity<TblPunchType>(entity =>
        {
            entity.ToTable("TblPunchType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
