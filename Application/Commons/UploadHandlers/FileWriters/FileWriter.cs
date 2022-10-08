using Microsoft.AspNetCore.Http;

namespace Application.Commons.UploadHandlers.FileWriters
{
    public static class FileWriter
    {
        public static async Task UploadFile(IFormFile file, string path)
        {
            try
            {
                await using var fs = new FileStream(path, FileMode.Create);
                await file.CopyToAsync(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
