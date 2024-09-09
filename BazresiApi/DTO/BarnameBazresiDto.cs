using System.ComponentModel.DataAnnotations;

namespace BazresiApi.Models
{
    public class BarnameBazresiDto
    {


        public int? T_L_Vahed_Id { get; set; }

        [StringLength(50)]
        public string T_L_Vahed_Title { get; set; }

        public int? T_Bazres_Id { get; set; }

        [StringLength(50)]
        public string T_Bazres_Name { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Item_Bazresi_Title { get; set; }

        [StringLength(50)]
        public string Zaman_Bazresi { get; set; }

        public int? T_Ferekans_Item_Bazresi_Id { get; set; }

        [StringLength(500)]
        public string T_Ferekans_Item_Bazresi_Title { get; set; }

        [StringLength(50)]
        public string Vaziat_Bazresi { get; set; }

        public int? Is_Completed { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Barname_BazresiApp { get; set; }
    }
}
