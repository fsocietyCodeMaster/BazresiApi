using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class ZirClassItemDto
    {

        [StringLength(500)]
        public string Title_Zir_Class_Item { get; set; }

        public int? T_L_Class_Item_Id { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Zir_Class_ItemApp { get; set; }
    }
}
