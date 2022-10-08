namespace Infrastructure.Commons.Response
{
    public static class Response
    {
        public static Response<T> Success<T>(T data, string message) =>
            new(data, message, false);

        public static Response<T> Fail<T>(string message, T data = default) =>
            new(data, message, true);
        public static Response<T> Success<T>(T data, List<string> message) =>
            new(data, message, false);

        public static Response<T> Fail<T>(List<string> message, T data = default) =>
            new(data, message, true);
    }

    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Messages { get; set; } = new();
        public bool Error { get; set; }

        public Response(T data, List<string> messages, bool error)
        {
            messages.AddRange(messages);
            Data = data;
            Error = error;
        }

        public Response(T data, string message, bool error)
        {
            Data = data;
            Messages.Add(message);
            Error = error;
        }



    }
}
