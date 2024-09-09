namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public partial class T_Item_Bazresi
    {
        [Key]
        public long ID_Item_Bazresi { get; set; }

        public int? T_L_Class_Item_Id { get; set; }

        [StringLength(500)]
        public string T_L_Titles_Class_Item { get; set; }

        public int? T_L_Zir_Class_Item_Id { get; set; }

        [StringLength(500)]
        public string T_L_Title_Zir_Class_Item { get; set; }

        public int? T_L_Vahed_Id { get; set; }

        [StringLength(500)]
        public string T_L_Titles_Vahed { get; set; }

        [StringLength(500)]
        public string Onvan_Item { get; set; }

        public int? Shomare_Shenasayi { get; set; }

        [StringLength(500)]
        public string Sarparast_Vahed { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string SalSakht { get; set; }

        [StringLength(50)]
        public string Sazande { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(500)]
        public string Ferekans_Bazresi { get; set; }

        [StringLength(500)]
        public string Ravesh_Bazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Item_BazresiApp { get; set; }
    }
}
