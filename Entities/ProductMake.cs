using WebAppAndApi.Features.ProductMakes.Models;
using Newtonsoft.Json;

namespace WebAppAndApi.Entities
{
    public class ProductMake
    {
        public int ProductMovieCode { get; set;}
        public string ProductMovieDes {get; set;}
        
        
        public static ProductMake Create(CreateProductMakeRequestModel model)
        {
            return JsonConvert.DeserializeObject<ProductMake>(JsonConvert.SerializeObject(model));
        }
    }
}