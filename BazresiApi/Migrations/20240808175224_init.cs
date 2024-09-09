using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BazresiApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    ID_T_Admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Create_Datetime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dateupdate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Admin_Name_Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Admin_Mobail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Admin_company = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_Admin_Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Vaziyat_Noskheh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Types = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_T_AdminApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.ID_T_Admin);
                });

            migrationBuilder.CreateTable(
                name: "BarnameBazresi",
                columns: table => new
                {
                    ID_Barname_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Vahed_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Bazres_Id = table.Column<int>(type: "int", nullable: true),
                    T_Bazres_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Zaman_Bazresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Ferekans_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ferekans_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Vaziat_Bazresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Completed = table.Column<int>(type: "int", nullable: true),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Barname_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarnameBazresi", x => x.ID_Barname_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "Bazres",
                columns: table => new
                {
                    ID_Bazres = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Shomare_Personeli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MadrakTahsili = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code_Meli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_L_SabegheKar_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Title_SabegheKar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phoneNumberBazres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    userNameBazres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    passwordBazres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VahedHayBazresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_BazresApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bazres", x => x.ID_Bazres);
                });

            migrationBuilder.CreateTable(
                name: "BazresiAzmon",
                columns: table => new
                {
                    ID_Bazresi_Azmon = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Bazres_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Zir_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ferekans_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    TotoalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RouteVoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tozihat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaziat_Nomre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Temp = table.Column<int>(type: "int", nullable: true),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Bazresi_AzmonApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazresiAzmon", x => x.ID_Bazresi_Azmon);
                });

            migrationBuilder.CreateTable(
                name: "BazresiAzmonPic",
                columns: table => new
                {
                    ID_Bazresi_Azmon_Pic = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Bazresi_Azmon_Id = table.Column<int>(type: "int", nullable: true),
                    Name_Pic = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Route_Pic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Temp = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Bazresi_Azmon_PicApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazresiAzmonPic", x => x.ID_Bazresi_Azmon_Pic);
                });

            migrationBuilder.CreateTable(
                name: "BazresiCheckList",
                columns: table => new
                {
                    ID_Bazresi_CheckList_OK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Bazresi_Azmon_Id = table.Column<int>(type: "int", nullable: true),
                    T_CheckList_Id = table.Column<int>(type: "int", nullable: true),
                    T_Soalat_CheckList_Onvan_Soal = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Natijeh_Number = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Natijeh_Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Temp = table.Column<int>(type: "int", nullable: true),
                    Is_Moshkel = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Bazresi_CheckList_OKApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazresiCheckList", x => x.ID_Bazresi_CheckList_OK);
                });

            migrationBuilder.CreateTable(
                name: "BazresVahed",
                columns: table => new
                {
                    ID_Bazres_Vahed = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Bazres_Id = table.Column<int>(type: "int", nullable: true),
                    T_Bazres_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Vahed_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Bazres_VahedApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazresVahed", x => x.ID_Bazres_Vahed);
                });

            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    ID_CheckList = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Titles_Vahed = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Titles_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Zir_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Title_Zir_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_Ferekans_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ferekans_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_Ravesh_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ravesh_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Onvan_CheckList = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_CheckListApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.ID_CheckList);
                });

            migrationBuilder.CreateTable(
                name: "ClassItem",
                columns: table => new
                {
                    ID_Class_Item = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titles_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Class_ItemApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassItem", x => x.ID_Class_Item);
                });

            migrationBuilder.CreateTable(
                name: "EghdamEslahi",
                columns: table => new
                {
                    ID_Eghdam_Eslahi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Zir_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    Code_Eghdam_Eslahi = table.Column<int>(type: "int", nullable: true),
                    T_Sharh_Moshkelat_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Bazresi_Azmon_Id = table.Column<int>(type: "int", nullable: true),
                    Onvan_Eghdam_Eslahi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Sharh_Eghdam_Eslahi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Masol_Ejra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zaman_Aghaz = table.Column<int>(type: "int", nullable: true),
                    Zaman_Payan = table.Column<int>(type: "int", nullable: true),
                    Route_Voice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T_L_Vaziat_Ejra_Id = table.Column<int>(type: "int", nullable: true),
                    Vaziat_Ejra_Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    Is_Temp = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Eghdam_EslahiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EghdamEslahi", x => x.ID_Eghdam_Eslahi);
                });

            migrationBuilder.CreateTable(
                name: "FerekansBazresi",
                columns: table => new
                {
                    ID_Ferekans_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Ferekans_Bazresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Ferekans_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FerekansBazresi", x => x.ID_Ferekans_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "FerekansItem",
                columns: table => new
                {
                    ID_Ferekans_Item_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Ferekans_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Ferekans_Bazresi_Title = table.Column<int>(type: "int", nullable: true),
                    LastBazresi = table.Column<int>(type: "int", nullable: true),
                    NextBazresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Ferekans_Item_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FerekansItem", x => x.ID_Ferekans_Item_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "ItemBazresi",
                columns: table => new
                {
                    ID_Item_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_L_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Titles_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Zir_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Title_Zir_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Vahed_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Titles_Vahed = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Onvan_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Shomare_Shenasayi = table.Column<int>(type: "int", nullable: true),
                    Sarparast_Vahed = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalSakht = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sazande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ferekans_Bazresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ravesh_Bazresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Item_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBazresi", x => x.ID_Item_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "RaveshBazresi",
                columns: table => new
                {
                    ID_Ravesh_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Ravesh_Bazresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Ravesh_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaveshBazresi", x => x.ID_Ravesh_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "RaveshItemBazresi",
                columns: table => new
                {
                    ID_Ravesh_Item_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Ravesh_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_L_Ravesh_Bazresi_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Ravesh_Item_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaveshItemBazresi", x => x.ID_Ravesh_Item_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "SabegheKar",
                columns: table => new
                {
                    ID_SabegheKar = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_SabegheKar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_SabegheKarApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SabegheKar", x => x.ID_SabegheKar);
                });

            migrationBuilder.CreateTable(
                name: "SharhMoshkelat",
                columns: table => new
                {
                    ID_L_Sharh_Moshkelat = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Sharh_Moshkelat = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_L_Sharh_MoshkelatApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharhMoshkelat", x => x.ID_L_Sharh_Moshkelat);
                });

            migrationBuilder.CreateTable(
                name: "SharhMoshkelatBazresi",
                columns: table => new
                {
                    ID_Sharh_Moshkelat_Bazresi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Bazresi_Azmon_Id = table.Column<int>(type: "int", nullable: true),
                    T_Bazresi_CheckList_OK_Id = table.Column<int>(type: "int", nullable: true),
                    T_Soalat_CheckList_Onvan_Soal = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Title_Sharh_Moshkelat = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Temp = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Sharh_Moshkelat_BazresiApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharhMoshkelatBazresi", x => x.ID_Sharh_Moshkelat_Bazresi);
                });

            migrationBuilder.CreateTable(
                name: "SoalatCheckList",
                columns: table => new
                {
                    ID_Soalat_CheckList = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_CheckList_Id = table.Column<int>(type: "int", nullable: true),
                    T_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ferekans_Item_Bazresi_Id = table.Column<int>(type: "int", nullable: true),
                    T_Ferekans_Item_Bazresi_Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Onvan_Soal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marja_Porsesh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tozihat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    DateCreate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Soalat_CheckListApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoalatCheckList", x => x.ID_Soalat_CheckList);
                });

            migrationBuilder.CreateTable(
                name: "Vahed",
                columns: table => new
                {
                    ID_Vahed = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titles_Vahed = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Soalat_CheckListApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vahed", x => x.ID_Vahed);
                });

            migrationBuilder.CreateTable(
                name: "VaziatEjra",
                columns: table => new
                {
                    ID_Vaziat_Ejra = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Vaziat_Ejra = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Vaziat_EjraApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaziatEjra", x => x.ID_Vaziat_Ejra);
                });

            migrationBuilder.CreateTable(
                name: "ZirClassItem",
                columns: table => new
                {
                    ID_Zir_Class_Item = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Zir_Class_Item = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_L_Class_Item_Id = table.Column<int>(type: "int", nullable: true),
                    Is_Active = table.Column<int>(type: "int", nullable: true),
                    T_AdminsBackups_ID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Zir_Class_ItemApp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZirClassItem", x => x.ID_Zir_Class_Item);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "BarnameBazresi");

            migrationBuilder.DropTable(
                name: "Bazres");

            migrationBuilder.DropTable(
                name: "BazresiAzmon");

            migrationBuilder.DropTable(
                name: "BazresiAzmonPic");

            migrationBuilder.DropTable(
                name: "BazresiCheckList");

            migrationBuilder.DropTable(
                name: "BazresVahed");

            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "ClassItem");

            migrationBuilder.DropTable(
                name: "EghdamEslahi");

            migrationBuilder.DropTable(
                name: "FerekansBazresi");

            migrationBuilder.DropTable(
                name: "FerekansItem");

            migrationBuilder.DropTable(
                name: "ItemBazresi");

            migrationBuilder.DropTable(
                name: "RaveshBazresi");

            migrationBuilder.DropTable(
                name: "RaveshItemBazresi");

            migrationBuilder.DropTable(
                name: "SabegheKar");

            migrationBuilder.DropTable(
                name: "SharhMoshkelat");

            migrationBuilder.DropTable(
                name: "SharhMoshkelatBazresi");

            migrationBuilder.DropTable(
                name: "SoalatCheckList");

            migrationBuilder.DropTable(
                name: "Vahed");

            migrationBuilder.DropTable(
                name: "VaziatEjra");

            migrationBuilder.DropTable(
                name: "ZirClassItem");
        }
    }
}
