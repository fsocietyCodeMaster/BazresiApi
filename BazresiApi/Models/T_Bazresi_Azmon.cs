namespace BazresiApi.Models
{

    using System.ComponentModel.DataAnnotations;

    public partial class T_Bazresi_Azmon
    {
        [Key]
        public long ID_Bazresi_Azmon { get; set; }

        public int? T_Bazres_Id { get; set; }

        public int? T_L_Vahed_Id { get; set; }

        public int? T_L_Class_Item_Id { get; set; }

        public int? T_L_Zir_Class_Item_Id { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        public int? T_Ferekans_Item_Bazresi_Id { get; set; }

        public decimal? TotoalScore { get; set; }

        public string RouteVoice { get; set; }

        public string Tozihat { get; set; }

        [StringLength(50)]
        public string Vaziat_Nomre { get; set; }

        public int? Is_Temp { get; set; }

        public int? Is_Active { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; } // ferestade nashe .

        public int? ID_Bazresi_AzmonApp { get; set; }
    }
}
