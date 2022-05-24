using Models;
using Models.Vendor;

namespace BusinessLayer.Vendor;

public interface IVendorService
{
    public Task<List<VendorModel>> VendorListAsync();
    public Task<ResponseMessageModel> CreateVendor(CreateVendorModel createVendorModel);
}