namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Vahed
    {
        [Key]
        public long ID_Vahed { get; set; }

        [StringLength(500)]
        public string Titles_Vahed { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Soalat_CheckListApp { get; set; }
    }
}
