using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
        public class BrandManager : IBrandService
        {
        IBrandDal _brandDal;

            public BrandManager(IBrandDal brandDal)
            {
                _brandDal = brandDal;
            }

            public void Add(Brands brand)
            {

                    _brandDal.Add(brand);
   
            }

            public void Delete(Brands brand)
            {
                _brandDal.Delete(brand);
                

            }

            public List<Brands> GetAll()
            {
                return _brandDal.GetAll();
            }

            public Brands GetById(int id)
            {
                return _brandDal.Get(c => c.BrandID == id);
            }

            public void Update(Brands brand)
            {
                if (brand.BrandName.Length >= 2)
                {
                    _brandDal.Update(brand);
                    Console.WriteLine("Marka başarıyla Güncellendi.");
                }
                else
                {
                    Console.WriteLine($"Lütfen marka isminin uzunluğunu 1 karakterden fazla giriniz. Girdiğiniz marka ismi : {brand.BrandName}");
                }

            }
        }
    }
