using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.FileSercives
{
    using Microsoft.AspNetCore.Http;

    namespace ITTradeSoft.Application.FileServices
    {
        public interface IFileService
        {
            public ValueTask<string> UploadImageAsync(IFormFile imagepath);
            public ValueTask<byte[]> GetImageAsync(string path);
            public ValueTask<string> UploadFileAsync(IFormFile filePath);
        }
    }

}
