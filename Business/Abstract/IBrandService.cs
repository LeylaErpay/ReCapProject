using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brands brand);
        void Update(Brands brand);
        void Delete(Brands brand);
        List<Brands> GetAll();

        Brands GetById(int id);
    }
}
