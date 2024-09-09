using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class SharhMoshkelatDto
    {

        [StringLength(500)]
        public string Title_Sharh_Moshkelat { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_L_Sharh_MoshkelatApp { get; set; }
    }
}
