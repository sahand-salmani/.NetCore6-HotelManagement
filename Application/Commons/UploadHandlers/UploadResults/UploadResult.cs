namespace Application.Commons.UploadHandlers.UploadResults
{
    public class UploadResult
    {
        public UploadResult()
        {
        }

        public UploadResult(string url, string fullUrl, string fileName, string type, int size)
        {
            Url = url;
            FullUrl = fullUrl;
            FileName = fileName;
            FileType = type;
            Size = size;
        }
        public string Url { get; set; }
        public string FullUrl { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int Size { get; set; }

    }
}
