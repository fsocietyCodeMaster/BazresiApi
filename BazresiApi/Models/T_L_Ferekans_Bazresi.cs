namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Ferekans_Bazresi
    {
        [Key]
        public long ID_Ferekans_Bazresi { get; set; }

        [StringLength(500)]
        public string Title_Ferekans_Bazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ferekans_BazresiApp { get; set; }
    }
}
