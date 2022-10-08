using Application.Commons.UploadHandlers.UploadHelpers;

namespace Application.Commons.UploadHandlers.Options
{
    public interface IUploadFileOption
    {
        public bool IsDividedByFormat { get; set; }
        public bool IsChangingNameAllowed { get; set; }
        public string FileName { get; set; }
        public int MaxAllowedSizeInKb { get; set; }
        public List<AllowedFormatsToUpload> AllowedFormats { get; set; }
        public DirectoryFactory.CustomDirectory DirectoryMaker { get; set; }

    }
    public class UploadFileOption : IUploadFileOption
    {
        public bool IsDividedByFormat { get; set; } = false;
        public bool IsChangingNameAllowed { get; set; } = true;
        public string FileName { get; set; }
        public int MaxAllowedSizeInKb { get; set; } = int.MaxValue;
        public List<AllowedFormatsToUpload> AllowedFormats { get; set; }
            = new()
            {
                AllowedFormatsToUpload.All
            };

        public DirectoryFactory.CustomDirectory DirectoryMaker { get; set; }
    }
}
