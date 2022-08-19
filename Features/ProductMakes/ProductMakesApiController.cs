using Microsoft.AspNetCore.Mvc;
using WebAppAndApi.Repositories.Interfaces;
using WebAppAndApi.Entities;
using WebAppAndApi.Models;
using System.Collections.Generic;
using WebAppAndApi.Features.ProductMakes.Models;
using WebAppAndApi.Constants;
using System.Transactions;
using WebAppAndApi.Repositories.EfCore; 

using System.Linq;
namespace WebAppAndApi.Features.ProductMakes
{
    [ApiController]
    [Route("api/ProductMakes")]
    public class ProductMakesApiController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationContext data ;
        private readonly IProductMakesRepository ProductMakesRepository;
        public ProductMakesApiController(
            IUnitOfWork unitOfWork, IProductMakesRepository ProductMakesRepository , ApplicationContext db)
        {
            this.unitOfWork = unitOfWork;
            this.ProductMakesRepository = ProductMakesRepository;
            this.data = db;
        }

        [HttpGet("list")]
        public ApiResponseModel<List<Entities.ProductMake>> List()
        {
            List<Entities.ProductMake> productmake = ProductMakesRepository.FindAll();
            ApiResponseModel<List<Entities.ProductMake>> response = new ApiResponseModel<List<Entities.ProductMake>>();
            
            response.Data = productmake;
            return response;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CreateProductMakeRequestModel request)
        {
            
            ApiResponseModel<Entities.ProductMake> response = new ApiResponseModel<Entities.ProductMake>();
            if (TryValidateModel(request, nameof(CreateProductMakeRequestModel)))
            {
                
                
                Entities.ProductMake convertrequest = ProductMake.Create(request);
                if(data.ProductMake.FirstOrDefault(e => e.ProductMovieCode == request.ProductMovieCode) != null){
                    response.Status = new Status(ResponseStatusCodeConstant.BadRequest);
                    return Ok(response);
                }
                else{

                    ProductMakesRepository.Add(convertrequest);
                    unitOfWork.SaveChanges();
                    response.Status = new Status(ResponseStatusCodeConstant.Ok);
                    response.Data = new Entities.ProductMake
                    {
                    ProductMovieCode = convertrequest.ProductMovieCode,
                    ProductMovieDes = request.ProductMovieDes,
                    
                    
                   
                    };
                   
                }
               
            }
            else
            {
                response.Status = new Status(ResponseStatusCodeConstant.BadRequest);
            }
             return Ok(response);
        }

        [HttpPost("Update")]
        public ApiResponseModel<Entities.ProductMake> Update([FromBody] CreateProductMakeRequestModel request)
        {
            ApiResponseModel<Entities.ProductMake> response = new ApiResponseModel<Entities.ProductMake>();
            response.Status = new Status(ResponseStatusCodeConstant.BadRequest);
            if (TryValidateModel(request, nameof(CreateProductMakeRequestModel)))
            {
                TransactionOptions transactionOptions = new TransactionOptions();
                transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead;
                using (TransactionScope mainTransactionScope = new TransactionScope(TransactionScopeOption.RequiresNew, transactionOptions))
                {
                    Entities.ProductMake updaterequest = new Entities.ProductMake();
                    updaterequest.ProductMovieCode = request.ProductMovieCode;
                    updaterequest.ProductMovieDes = request.ProductMovieDes;
                    
                    ProductMakesRepository.Update(updaterequest);
                    unitOfWork.SaveChanges();
                    mainTransactionScope.Complete();
                    response.Status = new Status(ResponseStatusCodeConstant.Ok);
                }
            }
            return response;
        }

        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] DeleteProductMakeRequestModel request)
        {
            
            ApiResponseModel<Entities.ProductMake> response = new ApiResponseModel<Entities.ProductMake>();
            response.Status = new Status(ResponseStatusCodeConstant.BadRequest);
            if (TryValidateModel(request, nameof(DeleteProductMakeRequestModel)))
            {
                TransactionOptions transactionOptions = new TransactionOptions();
                transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead;
                using (TransactionScope mainTransactionScope = new TransactionScope(TransactionScopeOption.RequiresNew, transactionOptions))
                {
                    Entities.ProductMake deleterequest = new Entities.ProductMake();
                    deleterequest.ProductMovieCode = request.ProductMovieCode;
                    ProductMakesRepository.Delete(deleterequest);
                    unitOfWork.SaveChanges();
                    mainTransactionScope.Complete();
                    response.Status = new Status(ResponseStatusCodeConstant.Ok);
                }
            }
            return Ok(response);
        }
    }
}