using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class VahedDto
    {

        [StringLength(500)]
        public string Titles_Vahed { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Soalat_CheckListApp { get; set; }
    }
}
