namespace Agriculture.Aplication.FileSercives
{
    using Agriculture.Aplication.Common.Helpers.ITTradeSoft.Application.Common.Helpers;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;


    namespace ITTradeSoft.Application.FileServices
    {
        public class FileService : IFileService
        {

            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly string MEDIA = "media";
            private readonly string IMAGES = "images";
            private readonly string ROOTPATH;

            public FileService(IWebHostEnvironment enviroment, IWebHostEnvironment webHostEnvironment)
            {
                this.ROOTPATH = enviroment.WebRootPath;
                _webHostEnvironment = webHostEnvironment;
            }

            public async ValueTask<byte[]> GetImageAsync(string filepath)
            {
                string path = Path.Combine(ROOTPATH, filepath);
                byte[] imageBytes = await File.ReadAllBytesAsync(path);
                return imageBytes;
            }

            public async ValueTask<string> UploadFileAsync(IFormFile filePath)
            {
                string newImageName = MediaHelper.MakeFileName(filePath.FileName.ToLower());
                string subPath = Path.Combine(MEDIA, IMAGES, newImageName);
                string path = Path.Combine(ROOTPATH, subPath);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await filePath.CopyToAsync(stream);
                    return subPath;
                }
            }

            public async ValueTask<string> UploadImageAsync(IFormFile imagepath)
            {
                string newImageName = MediaHelper.MakeImageName(imagepath.FileName);
                string subPath = Path.Combine(MEDIA, IMAGES, newImageName);

                string path = Path.Combine(ROOTPATH, subPath);

                FileStream fileStream = new FileStream(path, FileMode.Create);
                await imagepath.CopyToAsync(fileStream);
                fileStream.Close();

                return subPath;
            }
        }
    }

}
