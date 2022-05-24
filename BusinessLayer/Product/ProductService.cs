using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;
using Models.Common;
using Models.Product;
using System.Linq.Dynamic.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Constant.ResponseMesssage;

namespace BusinessLayer.Product
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly ILogger<ProductService> _logger;

        public ProductService(DataContext context,ILogger<ProductService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<ResponseMessageModel> CreateProductAsync(CreateProductModel model)
        {
            try
            {

                var checkIfProductCodeAlereadyExists = await _context.Product.AnyAsync(x => x.ProductCode.ToLower() == model.ProductCode.ToLower());


                if (!checkIfProductCodeAlereadyExists)
                {
                    var product = new Entities.Product.Product
                    {
                        ProductName = model.ProductName,
                        ProductCode = model.ProductCode,
                        ParentProductId = model.ParentProductId,
                        InsertDate = DateTimeOffset.UtcNow,
                        InsertPersonId = "1",
                        UpdateDate = DateTimeOffset.UtcNow,
                        UpdatePersonId = "1",
                    };
                    await _context.Product.AddAsync(product);
                    await _context.SaveChangesAsync();
                    return new ResponseMessageModel()
                    {
                        ResponseMessage = ResponseMessage.ProductCreatedSucessfully
                    };
                }
                else
                {
                    return new ResponseMessageModel()
                    {
                        ResponseMessage = ResponseMessage.ProductCodeAlreadyExists
                    };
                }

            }
            catch (Exception ex)
            {

                _logger.LogError("Error while adding new Product. Exception message: {Message}", ex.Message);
                throw;
            }

        }
        public async Task<ProductDataTableModel> GetAllProductAsync(DataTableRequestModel model)
        {
            try
            {
                int pageSize = model.Length != null ? Convert.ToInt32(model.Length) : 0;
                int skip = model.Start != null ? Convert.ToInt32(model.Start) : 0;


                var query = from p in _context.Product
                            select new ProductModel
                            {
                                ProductId = p.ProductId,
                                ParentProductId = p.ParentProductId,
                                ProductName = p.ProductName,
                                ProductCode = p.ProductCode
                            };

                if (!string.IsNullOrEmpty(model.SortColumn) && !string.IsNullOrEmpty(model.SortColumnDirection))
                {
                    query = query.OrderBy(model.SortColumn + " " + model.SortColumnDirection);
                }
                if (!string.IsNullOrEmpty(model.SearchValue))
                {
                    query = query.Where(r => r.ProductName.ToLower().Contains(model.SearchValue.ToLower()) ||
                                            r.ProductCode.ToLower().Contains(model.SearchValue.ToLower()));
                }
                int recordsTotal = query.Count();
                var data = await query.Skip(skip).Take(pageSize).ToListAsync();

                return new ProductDataTableModel
                {
                    Draw = model.Draw,
                    RecordsFiltered = recordsTotal.ToString(),
                    RecordsTotal = recordsTotal.ToString(),
                    Data = data
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while fetching all Product. Exception message: {Message}", ex.Message);
                throw;
            }
        }
        public async Task<List<ProductModel>> GetAllProductForDropdownAsync()
        {
            try
            {
                var product = await (from p in _context.Product
                              select new ProductModel
                              {
                                  ProductId = p.ProductId,
                                  ProductName = p.ProductName,
                              }).ToListAsync();

                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while fetching all Product. Exception message: {Message}", ex.Message);
                throw;
            }
        }

        public async Task<UpdateProductModel> GetProductByIdAsync(int productId)
        {
            try
            {
                var product = await (from p in _context.Product
                                             where p.ProductId == productId.ToString()
                                             select new UpdateProductModel
                                             {
                                                 ProductId = p.ProductId,
                                                 ProductName = p.ProductName,
                                                 ProductCode = p.ProductCode,
                                                 ParentProductId = p.ParentProductId
                                             }).SingleOrDefaultAsync();

                if (product != null)
                {
                    return product;

                }
                return new UpdateProductModel
                {

                };

            }
            catch (Exception ex)
            {
                _logger.LogError("Error while fetching Company Rate. Exception message: {Message}", ex.Message);
                throw;
            }

        }
        public async Task<ResponseMessageModel> UpdateProductAsync(UpdateProductModel model)
        {
            try
            {
                var product = await _context.Product.Where(p => p.ProductId == model.ProductId).SingleOrDefaultAsync();
                if (product == null)
                    return new ResponseMessageModel
                    {
                        ResponseMessage = ResponseMessage.ProductIdNotValid
                    };

                var checkIfProductCodeExists = await _context.Product.AnyAsync(x => x.ProductCode.ToLower() == model.ProductCode.ToLower());
                bool nameNotChanged = product.ProductCode == model.ProductCode;

                if (!checkIfProductCodeExists || nameNotChanged)
                {
                    product.ProductName = model.ProductName;
                    product.ProductCode = model.ProductCode;
                    product.ParentProductId = model.ParentProductId;
                    _context.Product.Update(product);
                    await _context.SaveChangesAsync();
                    return new ResponseMessageModel
                    {
                        ResponseMessage = ResponseMessage.ProductUpdatedSuccessfully
                    };
                }
                else
                {
                    return new ResponseMessageModel()
                    {
                        ResponseMessage = ResponseMessage.ProductCodeMustBeUnique
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while updating Product. Exception message: {Message}", ex.Message);
                throw;
            }

        }

    }
}
