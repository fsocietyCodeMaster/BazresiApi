namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_SabegheKar
    {
        [Key]
        public long ID_SabegheKar { get; set; }

        [StringLength(50)]
        public string Title_SabegheKar { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_SabegheKarApp { get; set; }
    }
}
