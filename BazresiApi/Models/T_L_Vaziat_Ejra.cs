namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Vaziat_Ejra
    {
        [Key]
        public long ID_Vaziat_Ejra { get; set; }

        [StringLength(500)]
        public string Title_Vaziat_Ejra { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Vaziat_EjraApp { get; set; }
    }
}
