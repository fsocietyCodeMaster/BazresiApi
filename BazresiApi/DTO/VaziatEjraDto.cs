using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class VaziatEjraDto
    {

        [StringLength(500)]
        public string Title_Vaziat_Ejra { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Vaziat_EjraApp { get; set; }
    }
}
