namespace BazresiApi.DTO
{
    public class FileUploadDto
    {
        public IFormFile File { get; set; }

        public long ID_Bazresi_Azmon_Pic { get; set; }

        public int? T_Bazresi_Azmon_Id { get; set; }

        public int? Is_Temp { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Bazresi_Azmon_PicApp { get; set; }
    }
}
