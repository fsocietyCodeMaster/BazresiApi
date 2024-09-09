using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class SoalatCheckListDto
    {

        public int? T_CheckList_Id { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        public int? T_Ferekans_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Ferekans_Item_Bazresi_Title { get; set; }

        public string Onvan_Soal { get; set; }

        public string Marja_Porsesh { get; set; }

        public string Tozihat { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Soalat_CheckListApp { get; set; }
    }
}
