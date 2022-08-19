using System.ComponentModel.DataAnnotations;


namespace WebAppAndApi.Features.ProductMakes.Models
{
    public class CreateProductMakeRequestModel
    {
        [Required]
        public int ProductMovieCode { get; set;}
        [Required]
        [StringLength(100)]
        public string ProductMovieDes {get; set;}
       
    }
}