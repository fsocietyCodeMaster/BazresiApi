using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class CheckListDto
    {

        public int? T_L_Vahed_Id { get; set; }

        [StringLength(500)]
        public string T_L_Titles_Vahed { get; set; }

        public int? T_L_Class_Item_Id { get; set; }

        [StringLength(500)]
        public string T_L_Titles_Class_Item { get; set; }

        public int? T_L_Zir_Class_Item_Id { get; set; }

        [StringLength(500)]
        public string T_L_Title_Zir_Class_Item { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Item_Bazresi_Title { get; set; }

        public int? T_Ferekans_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Ferekans_Item_Bazresi_Title { get; set; }

        public int? T_Ravesh_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Ravesh_Item_Bazresi_Title { get; set; }

        [StringLength(500)]
        public string Onvan_CheckList { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_CheckListApp { get; set; }
    }
}
