using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class RavesheBazresiDto
    {

        [StringLength(500)]
        public string Title_Ravesh_Bazresi { get; set; }

        public int? Is_Active { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Ravesh_BazresiApp { get; set; }
    }
}

