using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class SharhMoshkelatBazresiDto
    {

        public int? T_Item_Bazresi_Id { get; set; }

        public int? T_Bazresi_Azmon_Id { get; set; }

        public int? T_Bazresi_CheckList_OK_Id { get; set; }

        [StringLength(500)]
        public string T_Soalat_CheckList_Onvan_Soal { get; set; }

        [StringLength(500)]
        public string T_L_Title_Sharh_Moshkelat { get; set; }

        public int? Is_Temp { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Sharh_Moshkelat_BazresiApp { get; set; }
    }
}
