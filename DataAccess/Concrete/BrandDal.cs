﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

internal class BrandDal : IBrandDal
{
    List<Brand> _brands;
    public BrandDal()
    {
        _brands =
        [
            new Brand { Id=1,Name="Audi",CreatedDate=DateTime.Now},
            new Brand { Id =2, Name = "BMW", CreatedDate = DateTime.Now },
            new Brand { Id =3, Name = "Mercedes", CreatedDate = DateTime.Now },
        ];
        
    }
    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}
