namespace BazresiApi.DTO
{
    public class NotFoundDto
    {
        public string Message { get; set; } = null!;

        public int Status { get; set; }

        public bool IsSuccess { get; set; }

        public object? Data { get; set; }
    }
}
