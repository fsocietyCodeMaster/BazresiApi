using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class ClassItemDto
    {

        [StringLength(500)]
        public string Titles_Class_Item { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Class_ItemApp { get; set; }
    }
}
