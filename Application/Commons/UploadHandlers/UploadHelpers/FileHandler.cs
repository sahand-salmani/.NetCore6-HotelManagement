using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.UploadHandlers.UploadHelpers
{
    public interface IFileExistenceHandler
    {
        bool CheckFileExists(string path);
    }
    public class FileExistenceHandler : IFileExistenceHandler
    {
        public bool CheckFileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
