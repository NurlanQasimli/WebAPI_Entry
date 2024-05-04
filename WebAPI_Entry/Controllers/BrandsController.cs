using Business.dtos.Responses;
using Business.dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI_Entry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        [HttpPost]
        public CreateBrandResponse Add(CreateBrandRequest createBrandRequest)
        {

        }

    }
}
