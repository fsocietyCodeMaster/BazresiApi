namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;

    public partial class T_Ferekans_Item_Bazresi
    {
        [Key]
        public long ID_Ferekans_Item_Bazresi { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        public int? T_L_Ferekans_Bazresi_Id { get; set; }

        public int? T_L_Ferekans_Bazresi_Title { get; set; }

        public int? LastBazresi { get; set; }

        [StringLength(50)]
        public string NextBazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ferekans_Item_BazresiApp { get; set; }
    }
}
