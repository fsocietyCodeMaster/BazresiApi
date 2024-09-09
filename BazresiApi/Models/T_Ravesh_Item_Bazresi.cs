namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_Ravesh_Item_Bazresi
    {
        [Key]
        public long ID_Ravesh_Item_Bazresi { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        public int? T_L_Ravesh_Bazresi_Id { get; set; }

        [StringLength(50)]
        public string T_L_Ravesh_Bazresi_Title { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ravesh_Item_BazresiApp { get; set; }
    }
}
