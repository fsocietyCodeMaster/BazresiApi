namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_Bazresi_Azmon_Pic
    {
        [Key]
        public long ID_Bazresi_Azmon_Pic { get; set; }

        public int? T_Bazresi_Azmon_Id { get; set; }

        [StringLength(500)]
        public string Name_Pic { get; set; }

        public string Route_Pic { get; set; }

        public int? Is_Temp { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Bazresi_Azmon_PicApp { get; set; }
    }
}
