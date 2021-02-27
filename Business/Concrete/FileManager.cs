using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class FileManager : IFileProcess
    {
        private readonly IHostingEnvironment environment;
        string FileDirectory;

        public FileManager(IHostingEnvironment environment)
        {
            this.environment = environment;
            FileDirectory = environment.ContentRootPath + "/images/";
        }
        //public IResult Delete(string path)
        //{
        //    var roadpath = Path.Combine(FileDirectory, path + ".png");
        //    if (System.IO.File.Exists(Path.Combine(FileDirectory, path + ".png")))
        //    {
        //        System.IO.File.Delete(Path.Combine(FileDirectory, path + ".png"));
        //    }
        //    return new SuccessResult();
        //}

        //public async Task<IResult> Upload(string fileName, IFormFile fileList)
        //{
        //    using (var fileStream = new FileStream(Path.Combine(FileDirectory, fileName.ToString() + ".png"), FileMode.Create, FileAccess.Write))
        //    {
        //        await fileName.CopyToAsyn(fileStream);
        //    }
        //    return new SuccessResult(Messages.Add_Message(typeof(CarImage).Name));
        //}
    }
}
