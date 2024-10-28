using System.ComponentModel.DataAnnotations;

namespace EdenWebAPI.DTO
{
    public class ResponseDTO
    {
        [Required]
        public int StatusCode { get; set; }

        [Required]
        public dynamic? Data { get; set; }
    }
}
