using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Vendor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Vendor;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseApiController
    {
        private readonly IVendorService _iVendorService;

        public VendorController(IVendorService iVendorService)
        {
            _iVendorService = iVendorService;
        }
        [HttpPost("VendorList")]
        public async Task<List<VendorModel>> VendorList()
        {
            return  await _iVendorService.VendorListAsync();
        }
        
        [HttpPost("CreateVendor")]
        public async Task<ResponseMessageModel> CreateVendor(CreateVendorModel createVendorModel)
        {
            return  await _iVendorService.CreateVendor(createVendorModel);
        }
    }
}
