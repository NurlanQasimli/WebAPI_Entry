using Business.Abstract;
using Business.dtos.Requests;
using Business.dtos.Responses;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //business rules

        //mapping
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate = DateTime.Now;

        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createdBrandResponse = new();
        createdBrandResponse.Id = 4;
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.CreatedDate = brand.CreatedDate;

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();
        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
        foreach (Brand brand in brands)
        {
            GetAllBrandResponse getAll = new GetAllBrandResponse();
            getAll.Id = brand.Id;
            getAll.Name = brand.Name;
            getAll.CreatedDate = brand.CreatedDate;
            getAllBrandResponses.Add(getAll);

        }
        return getAllBrandResponses;
    }


}
