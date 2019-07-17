using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Eatery.Extension
{
    public static class IFormFileExtensions
    {
        public static bool IsImage(this IFormFile Image)
        {
            return Image == null || Image.ContentType.Contains("image/") || Image.Length / 1024 / 1024 > 2;
           
        }
        public async static Task<string> Save(this IFormFile file,IHostingEnvironment env,string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.FileName;
            string resultpath = Path.Combine(env.WebRootPath,folder, filename);
            using (FileStream stream = new FileStream(resultpath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filename;
        }
    }
}
