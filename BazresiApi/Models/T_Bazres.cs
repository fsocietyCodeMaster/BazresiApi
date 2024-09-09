namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class T_Bazres
    {
        [Key]
        public long ID_Bazres { get; set; }

        [StringLength(50)]
        public string Name_Family { get; set; }

        [StringLength(50)]
        public string Shomare_Personeli { get; set; }

        [StringLength(50)]
        public string MadrakTahsili { get; set; }

        [StringLength(50)]
        public string Code_Meli { get; set; }

        public int? T_L_SabegheKar_Id { get; set; }

        [StringLength(50)]
        public string T_L_Title_SabegheKar { get; set; }

        [StringLength(50)]
        public string phoneNumberBazres { get; set; }

        [StringLength(50)]
        public string userNameBazres { get; set; }

        [StringLength(50)]
        public string passwordBazres { get; set; }

        [StringLength(50)]
        public string VahedHayBazresi { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_BazresApp { get; set; }
    }
}
