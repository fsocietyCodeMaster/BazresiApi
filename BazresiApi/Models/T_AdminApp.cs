namespace BazresiApi.Models
{
    using System.ComponentModel.DataAnnotations;


    public partial class T_AdminApp
    {
        [Key]
        public int ID_T_Admin { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Create_Datetime { get; set; }

        [StringLength(50)]
        public string Dateupdate { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(50)]
        public string T_Admin_Name_Family { get; set; }

        [StringLength(50)]
        public string T_Admin_Mobail { get; set; }

        [StringLength(500)]
        public string T_Admin_company { get; set; }

        [StringLength(500)]
        public string T_Admin_Address { get; set; }

        [StringLength(50)]
        public string Vaziyat_Noskheh { get; set; }

        [StringLength(50)]
        public string Types { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_T_AdminApp { get; set; }
    }
}
