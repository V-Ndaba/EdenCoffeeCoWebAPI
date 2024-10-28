using EdenWebAPI.DTO;
using EdenWebAPI.Models;
using EdenWebAPI.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EdenWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BevController : ControllerBase
    {
        private readonly IUnitOfWork _UnitOfWork;

        public BevController(IConfiguration configuration,EdenDBContext DbContext)
        {
            _UnitOfWork = new UnitOfWork.UnitOfWork(configuration, DbContext);
        }

        //Add Beverage
        [HttpPost("AddBeverage")]
        public async Task<ActionResult<ResponseDTO>> Add(BevDTO bevDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO { StatusCode = BadRequest().StatusCode, Data = false };
            Beverages beverages = BevDTO.FromDTO(bevDTO);
            if(await _UnitOfWork.bevRepo.AddBevAsync(beverages))
            {
                await _UnitOfWork.SaveAsync();
                responseDTO.StatusCode = Ok().StatusCode;
                responseDTO.Data = true;
            }
            return responseDTO;
        }

        //Return all beverages
        [HttpGet("GetAllBeverages")]
        public async Task<ActionResult<ResponseDTO>> Show()
        {
            ResponseDTO responseDTO = new ResponseDTO { StatusCode = NotFound().StatusCode, Data = false };

            List<Beverages?> beverages = await _UnitOfWork.bevRepo.GetAllBevsAsync();
            if(beverages != null)
            {
                responseDTO.StatusCode = Ok().StatusCode;
                responseDTO.Data = beverages.Select(Beverage => BevDTO.ToDTO(Beverage));
            }

            return responseDTO;
        }
    }
}
