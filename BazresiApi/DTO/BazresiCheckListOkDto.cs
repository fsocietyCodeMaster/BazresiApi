using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class BazresiCheckListOkDto
    {

        public int? T_Bazresi_Azmon_Id { get; set; }

        public int? T_CheckList_Id { get; set; }

        [StringLength(500)]
        public string T_Soalat_CheckList_Onvan_Soal { get; set; }

        public decimal? Natijeh_Number { get; set; }

        [StringLength(50)]
        public string Natijeh_Text { get; set; }

        public int? Is_Temp { get; set; }

        public int? Is_Moshkel { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Bazresi_CheckList_OKApp { get; set; }
    }
}
