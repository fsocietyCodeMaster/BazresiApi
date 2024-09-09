using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class FerekansBazresiDto
    {

        [StringLength(500)]
        public string Title_Ferekans_Bazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ferekans_BazresiApp { get; set; }
    }
}
