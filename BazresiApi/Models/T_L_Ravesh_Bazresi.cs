namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Ravesh_Bazresi
    {
        [Key]
        public long ID_Ravesh_Bazresi { get; set; }

        [StringLength(500)]
        public string Title_Ravesh_Bazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ravesh_BazresiApp { get; set; }
    }
}
