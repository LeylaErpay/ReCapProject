using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;
        private ICarService _carService;
        public CarImagesController(ICarImageService carImageService, ICarService carService)
        {
            _carImageService = carImageService;
            _carService = carService;
        }

        [HttpPost]
        public IActionResult UploadImage([FromForm] IFormFile file, [FromForm] int carId)
        {
            var carImages = _carImageService.GetAll(x => x.CarId == carId).Data;
            int numberOfCar = carImages.Count + 1;
            string imageName = "CarId-" + carId + "-ImageNo-" + numberOfCar + "-.jpg";
            try
            {
                string oldPath = Path.Combine(@"C:\Users\Leyla Erpay\source\repos\ReCapProject\WebAPI\images\" + file.FileName);
                string newPath = Path.Combine(@"C:\Users\Leyla Erpay\source\repos\ReCapProject\WebAPI\images\" + imageName);
                using (var stream = new FileStream(oldPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                System.IO.File.Move(oldPath, newPath);
                _carImageService.Add(new CarImage
                {
                    CarId = carId,
                    
                    ImagePath = newPath,
                    
                });
            }
            catch (Exception)
            {
                return BadRequest("Hata çıktı");
            }

            return Ok(file);
        }
        [HttpPost]
        public IActionResult ShowImages(int carId, int imageNumber = 0)
        {
            var carImages = _carImageService.GetAll(x => x.CarId == carId).Data;
            var images = new List<FileStream>();
            foreach (var carImage in carImages)
            {
                var image = System.IO.File.OpenRead(carImage.ImagePath);
                images.Add(image);
            }
            if (images.Count == 0)
            {
                images.Add(System.IO.File.OpenRead(@"C:\Users\Leyla Erpay\source\repos\ReCapProject\WebAPI\images\dd.jpg"));
            }
            if (imageNumber > images.Count)
            {
                return BadRequest("HATA VAR!");
            }
            return File(images[imageNumber], "dd/jpeg");
        }


        //ICarImageService _carImageService;

        //public CarImagesController(ICarImageService carImageService)
        //{
        //    _carImageService = carImageService;
        //}

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _carImageService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("add")]
        //public IActionResult Add([FromForm(Name = ("image"))] IFormFile file, [FromForm] CarImage carImage)
        //{
        //    var result = _carImageService.Add(file, carImage);          

        //    return Ok(result);       


        //}

        //[HttpPost("delete")]
        //public IActionResult Delete([FromForm(Name = ("Id"))] int id)
        //{

        //    var carImage = _carImageService.GetImagesByCarId(id).Data;

        //    var result = _carImageService.Delete(carImage);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("update")]
        //public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int id)
        //{
        //    var carImage = _carImageService.GetImagesByCarId(id).Data;
        //    var result = _carImageService.Update(file, carImage);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}





    }
}
