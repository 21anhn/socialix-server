namespace Socialix.Commons
{
    public class ApiBaseResponse<T>
    {
        public string? MessageId { get; set; }
        public string? Message { get; set; } 
        public bool? Success { get; set; }
        public T? Response { get; set; }
        public List<DetailError>? DetailErrorList { get; set; }
    }
}
