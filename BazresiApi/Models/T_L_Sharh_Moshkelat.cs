namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Sharh_Moshkelat
    {
        [Key]
        public long ID_L_Sharh_Moshkelat { get; set; }

        [StringLength(500)]
        public string Title_Sharh_Moshkelat { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_L_Sharh_MoshkelatApp { get; set; }
    }
}
