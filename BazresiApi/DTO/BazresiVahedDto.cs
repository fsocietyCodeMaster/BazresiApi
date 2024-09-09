using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazresiApi.DTO
{
    public class BazresiVahedDto
    {

        public int? T_Bazres_Id { get; set; }

        [StringLength(50)]
        public string T_Bazres_Name { get; set; }

        public int? T_L_Vahed_Id { get; set; }

        [StringLength(50)]
        public string T_L_Vahed_Title { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Bazres_VahedApp { get; set; }
    }
}
