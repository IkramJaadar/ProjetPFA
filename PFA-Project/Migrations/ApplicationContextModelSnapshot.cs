﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFA_Project;

#nullable disable

namespace PFA_Project.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PFA_Project.Models.Article", b =>
                {
                    b.Property<int>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArticle"), 1L, 1);

                    b.Property<int?>("CategorieIdCategorie")
                        .HasColumnType("int");

                    b.Property<int?>("IdCat")
                        .HasColumnType("int");

                    b.Property<string>("LibelleArticle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QteStock")
                        .HasColumnType("int");

                    b.Property<string>("RefArticle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdArticle");

                    b.HasIndex("CategorieIdCategorie");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("PFA_Project.Models.ArticleProduit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdArticle")
                        .HasColumnType("int");

                    b.Property<int>("IdProduit")
                        .HasColumnType("int");

                    b.Property<int?>("Quantite")
                        .HasColumnType("int");

                    b.Property<int?>("articleIdArticle")
                        .HasColumnType("int");

                    b.Property<int?>("produitIdProduit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("articleIdArticle");

                    b.HasIndex("produitIdProduit");

                    b.ToTable("ArticleProduits");
                });

            modelBuilder.Entity("PFA_Project.Models.Categorie", b =>
                {
                    b.Property<int>("IdCategorie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategorie"), 1L, 1);

                    b.Property<string>("LibelleCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategorie");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PFA_Project.Models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Datecmd")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("Encaisse")
                        .HasColumnType("bit");

                    b.Property<string>("Etat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TableId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("PFA_Project.Models.Employee", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime>("Date_naissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponibilite")
                        .HasColumnType("bit");

                    b.Property<int?>("Heure_Sup")
                        .HasColumnType("int");

                    b.Property<int>("Heure_Travail")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NbrExperience")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RecetteServ")
                        .HasColumnType("float");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salaire")
                        .HasColumnType("float");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PFA_Project.Models.Famille", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Couleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Familles");
                });

            modelBuilder.Entity("PFA_Project.Models.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("N_Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("PFA_Project.Models.Fourniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdArticle")
                        .HasColumnType("int");

                    b.Property<int>("IdFournisseur")
                        .HasColumnType("int");

                    b.Property<double>("Qte")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdArticle");

                    b.HasIndex("IdFournisseur");

                    b.ToTable("Fournitures");
                });

            modelBuilder.Entity("PFA_Project.Models.LigneCommande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<double?>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId");

                    b.HasIndex("ProduitId");

                    b.ToTable("LigneCommande");
                });

            modelBuilder.Entity("PFA_Project.Models.Produit", b =>
                {
                    b.Property<int>("IdProduit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduit"), 1L, 1);

                    b.Property<int>("IdFamille")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Prix")
                        .HasColumnType("float");

                    b.Property<int?>("familleId")
                        .HasColumnType("int");

                    b.HasKey("IdProduit");

                    b.HasIndex("familleId");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("PFA_Project.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Capacite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtatTable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumTable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("PFA_Project.Models.Article", b =>
                {
                    b.HasOne("PFA_Project.Models.Categorie", null)
                        .WithMany("Articles")
                        .HasForeignKey("CategorieIdCategorie");
                });

            modelBuilder.Entity("PFA_Project.Models.ArticleProduit", b =>
                {
                    b.HasOne("PFA_Project.Models.Article", "article")
                        .WithMany("produitArticles")
                        .HasForeignKey("articleIdArticle");

                    b.HasOne("PFA_Project.Models.Produit", "produit")
                        .WithMany("produitArticles")
                        .HasForeignKey("produitIdProduit");

                    b.Navigation("article");

                    b.Navigation("produit");
                });

            modelBuilder.Entity("PFA_Project.Models.Commande", b =>
                {
                    b.HasOne("PFA_Project.Models.Employee", "Employee")
                        .WithMany("commandes")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFA_Project.Models.Table", "Table")
                        .WithMany("Commandes")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("PFA_Project.Models.Fourniture", b =>
                {
                    b.HasOne("PFA_Project.Models.Article", "Article")
                        .WithMany("Fournitures")
                        .HasForeignKey("IdArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFA_Project.Models.Fournisseur", "Fournisseur")
                        .WithMany("Fournitures")
                        .HasForeignKey("IdFournisseur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Fournisseur");
                });

            modelBuilder.Entity("PFA_Project.Models.LigneCommande", b =>
                {
                    b.HasOne("PFA_Project.Models.Commande", "commande")
                        .WithMany("lignecommande")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFA_Project.Models.Produit", "produit")
                        .WithMany("lignecommandes")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("commande");

                    b.Navigation("produit");
                });

            modelBuilder.Entity("PFA_Project.Models.Produit", b =>
                {
                    b.HasOne("PFA_Project.Models.Famille", "famille")
                        .WithMany("produits")
                        .HasForeignKey("familleId");

                    b.Navigation("famille");
                });

            modelBuilder.Entity("PFA_Project.Models.Article", b =>
                {
                    b.Navigation("Fournitures");

                    b.Navigation("produitArticles");
                });

            modelBuilder.Entity("PFA_Project.Models.Categorie", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("PFA_Project.Models.Commande", b =>
                {
                    b.Navigation("lignecommande");
                });

            modelBuilder.Entity("PFA_Project.Models.Employee", b =>
                {
                    b.Navigation("commandes");
                });

            modelBuilder.Entity("PFA_Project.Models.Famille", b =>
                {
                    b.Navigation("produits");
                });

            modelBuilder.Entity("PFA_Project.Models.Fournisseur", b =>
                {
                    b.Navigation("Fournitures");
                });

            modelBuilder.Entity("PFA_Project.Models.Produit", b =>
                {
                    b.Navigation("lignecommandes");

                    b.Navigation("produitArticles");
                });

            modelBuilder.Entity("PFA_Project.Models.Table", b =>
                {
                    b.Navigation("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}