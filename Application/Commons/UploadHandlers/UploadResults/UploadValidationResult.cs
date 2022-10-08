namespace Application.Commons.UploadHandlers.UploadResults
{
    public class UploadValidationResult
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; } = new();

    }
}
