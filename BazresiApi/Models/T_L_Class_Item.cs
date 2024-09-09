namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_L_Class_Item
    {
        [Key]
        public long ID_Class_Item { get; set; }

        [StringLength(500)]
        public string Titles_Class_Item { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Class_ItemApp { get; set; }
    }
}
