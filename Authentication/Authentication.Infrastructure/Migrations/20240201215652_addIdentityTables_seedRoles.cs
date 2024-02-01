using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addIdentityTables_seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Competen__3213E83F8016AE91", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DomaineExpertise",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DomaineE__3213E83FA948D570", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ModeTravail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ModeTrav__3213E83F9D7319CC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ville__3213E83FC203427C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComptenceDmExpertise",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_competence = table.Column<int>(type: "int", nullable: true),
                    id_dmexpertise = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comptenc__3213E83F1B87D054", x => x.id);
                    table.ForeignKey(
                        name: "FK__Comptence__id_co__4222D4EF",
                        column: x => x.id_competence,
                        principalTable: "Competence",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Comptence__id_dm__4316F928",
                        column: x => x.id_dmexpertise,
                        principalTable: "DomaineExpertise",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Condidat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    titre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    avatar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    adresse = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    date_naissance = table.Column<DateTime>(type: "date", nullable: true),
                    tele = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    mobilite = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    disponibilite = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id_ville = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condidat__3213E83F0E35DC80", x => x.id);
                    table.ForeignKey(
                        name: "FK__Condidat__id_vil__38996AB5",
                        column: x => x.id_ville,
                        principalTable: "Ville",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Entreprise",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    raison_sociale = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    logo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    date_creation = table.Column<DateTime>(type: "date", nullable: true),
                    adresse = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id_ville = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Entrepri__3213E83FBF39B25F", x => x.id);
                    table.ForeignKey(
                        name: "FK__Entrepris__id_vi__3B75D760",
                        column: x => x.id_ville,
                        principalTable: "Ville",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Offre",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    titre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    descrpition = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    dure = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    adresse = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id_ville = table.Column<int>(type: "int", nullable: true),
                    date_pub = table.Column<DateTime>(type: "date", nullable: true),
                    id_modetravail = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Offre__3213E83F208C604A", x => x.id);
                    table.ForeignKey(
                        name: "FK__Offre__id_modetr__5EBF139D",
                        column: x => x.id_modetravail,
                        principalTable: "ModeTravail",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Offre__id_ville__5DCAEF64",
                        column: x => x.id_ville,
                        principalTable: "Ville",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CondidatComp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    niveau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id_comp = table.Column<int>(type: "int", nullable: true),
                    id_cond = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condidat__3213E83FAF442B14", x => x.id);
                    table.ForeignKey(
                        name: "FK__CondidatC__id_co__5070F446",
                        column: x => x.id_comp,
                        principalTable: "Competence",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__CondidatC__id_co__5165187F",
                        column: x => x.id_cond,
                        principalTable: "Condidat",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    titre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    local_ = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    description_ = table.Column<string>(type: "text", nullable: true),
                    id_ville = table.Column<int>(type: "int", nullable: true),
                    date_debut = table.Column<DateTime>(type: "date", nullable: true),
                    date_fin = table.Column<DateTime>(type: "date", nullable: true),
                    id_condidat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Experien__3213E83FDFDF460E", x => x.id);
                    table.ForeignKey(
                        name: "FK__Experienc__id_co__46E78A0C",
                        column: x => x.id_condidat,
                        principalTable: "Condidat",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Experienc__id_vi__45F365D3",
                        column: x => x.id_ville,
                        principalTable: "Ville",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Formation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    niveau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ecole = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    description_ = table.Column<string>(type: "text", nullable: true),
                    id_ville = table.Column<int>(type: "int", nullable: true),
                    date_debut = table.Column<DateTime>(type: "date", nullable: true),
                    date_fin = table.Column<DateTime>(type: "date", nullable: true),
                    id_condidat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Formatio__3213E83F9AD22692", x => x.id);
                    table.ForeignKey(
                        name: "FK__Formation__id_co__4AB81AF0",
                        column: x => x.id_condidat,
                        principalTable: "Condidat",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Formation__id_vi__49C3F6B7",
                        column: x => x.id_ville,
                        principalTable: "Ville",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Projet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    description_ = table.Column<string>(type: "text", nullable: true),
                    id_condidat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Projet__3213E83FD52ABFF2", x => x.id);
                    table.ForeignKey(
                        name: "FK__Projet__id_condi__4D94879B",
                        column: x => x.id_condidat,
                        principalTable: "Condidat",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ConsultaionProfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_condidat = table.Column<int>(type: "int", nullable: true),
                    id_entreprise = table.Column<int>(type: "int", nullable: true),
                    date_consultation = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Consulta__3213E83F93C2C409", x => x.id);
                    table.ForeignKey(
                        name: "FK__Consultai__id_co__5441852A",
                        column: x => x.id_condidat,
                        principalTable: "Condidat",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Consultai__id_en__5535A963",
                        column: x => x.id_entreprise,
                        principalTable: "Entreprise",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Messagerie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    expediteur_id = table.Column<int>(type: "int", nullable: true),
                    destinataire_id = table.Column<int>(type: "int", nullable: true),
                    msg = table.Column<string>(type: "text", nullable: true),
                    date_msg = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Messager__3213E83FB632B91A", x => x.id);
                    table.ForeignKey(
                        name: "FK__Messageri__exped__5812160E",
                        column: x => x.expediteur_id,
                        principalTable: "Condidat",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Messageri__exped__59063A47",
                        column: x => x.expediteur_id,
                        principalTable: "Entreprise",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CompetenceOffre",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_competence = table.Column<int>(type: "int", nullable: true),
                    id_Offre = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Competen__3213E83F51A53AEB", x => x.id);
                    table.ForeignKey(
                        name: "FK__Competenc__id_Of__628FA481",
                        column: x => x.id_Offre,
                        principalTable: "Offre",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Competenc__id_co__619B8048",
                        column: x => x.id_competence,
                        principalTable: "Competence",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11086d24-bd5b-4348-aaf2-2c2f5f11034c", "2", "Candidat", "CANDIDAT" },
                    { "1ba69201-f7c5-427d-b427-706101443023", "3", "Entreprise", "ENTREPRISE" },
                    { "a814423e-0467-40a4-ac00-92feee24cc16", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceOffre_id_competence",
                table: "CompetenceOffre",
                column: "id_competence");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceOffre_id_Offre",
                table: "CompetenceOffre",
                column: "id_Offre");

            migrationBuilder.CreateIndex(
                name: "IX_ComptenceDmExpertise_id_competence",
                table: "ComptenceDmExpertise",
                column: "id_competence");

            migrationBuilder.CreateIndex(
                name: "IX_ComptenceDmExpertise_id_dmexpertise",
                table: "ComptenceDmExpertise",
                column: "id_dmexpertise");

            migrationBuilder.CreateIndex(
                name: "IX_Condidat_id_ville",
                table: "Condidat",
                column: "id_ville");

            migrationBuilder.CreateIndex(
                name: "IX_CondidatComp_id_comp",
                table: "CondidatComp",
                column: "id_comp");

            migrationBuilder.CreateIndex(
                name: "IX_CondidatComp_id_cond",
                table: "CondidatComp",
                column: "id_cond");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaionProfil_id_condidat",
                table: "ConsultaionProfil",
                column: "id_condidat");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaionProfil_id_entreprise",
                table: "ConsultaionProfil",
                column: "id_entreprise");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprise_id_ville",
                table: "Entreprise",
                column: "id_ville");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_id_condidat",
                table: "Experience",
                column: "id_condidat");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_id_ville",
                table: "Experience",
                column: "id_ville");

            migrationBuilder.CreateIndex(
                name: "IX_Formation_id_condidat",
                table: "Formation",
                column: "id_condidat");

            migrationBuilder.CreateIndex(
                name: "IX_Formation_id_ville",
                table: "Formation",
                column: "id_ville");

            migrationBuilder.CreateIndex(
                name: "IX_Messagerie_expediteur_id",
                table: "Messagerie",
                column: "expediteur_id");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_id_modetravail",
                table: "Offre",
                column: "id_modetravail");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_id_ville",
                table: "Offre",
                column: "id_ville");

            migrationBuilder.CreateIndex(
                name: "IX_Projet_id_condidat",
                table: "Projet",
                column: "id_condidat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompetenceOffre");

            migrationBuilder.DropTable(
                name: "ComptenceDmExpertise");

            migrationBuilder.DropTable(
                name: "CondidatComp");

            migrationBuilder.DropTable(
                name: "ConsultaionProfil");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Formation");

            migrationBuilder.DropTable(
                name: "Messagerie");

            migrationBuilder.DropTable(
                name: "Projet");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Offre");

            migrationBuilder.DropTable(
                name: "DomaineExpertise");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "Entreprise");

            migrationBuilder.DropTable(
                name: "Condidat");

            migrationBuilder.DropTable(
                name: "ModeTravail");

            migrationBuilder.DropTable(
                name: "Ville");
        }
    }
}
