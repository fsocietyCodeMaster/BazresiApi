namespace BazresiApi.DTO
{
    public class UserManageResponse
    {
        public string Message { get; set; }

        public bool isSuccess { get; set; }

        public IEnumerable<string>? Error { get; set; }
    }
}
