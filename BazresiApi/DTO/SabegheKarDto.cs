using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class SabegheKarDto
    {

        [StringLength(50)]
        public string Title_SabegheKar { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_SabegheKarApp { get; set; }
    }
}
