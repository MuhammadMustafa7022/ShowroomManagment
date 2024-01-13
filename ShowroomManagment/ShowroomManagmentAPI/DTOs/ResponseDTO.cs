namespace ShowroomManagmentAPI.DTOs
{
    public class ResponseDTO
    {
        public int Status { get; set; }
        public string? ErrorMessage { get; set; }
        public dynamic? Response { get; set;}

    }
}
