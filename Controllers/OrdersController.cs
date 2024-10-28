using EdenWebAPI.DTO;
using EdenWebAPI.Models;
using EdenWebAPI.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EdenWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _UnitOfWork;

        public OrdersController(IConfiguration Config, EdenDBContext DbContext)
        {
            _UnitOfWork = new UnitOfWork.UnitOfWork(Config, DbContext);
        }

        [HttpPut("AddOrder")]
        public async Task<ActionResult<ResponseDTO>> Add(OrdersDTO ordersDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO { StatusCode = BadRequest().StatusCode, Data = false };

            Orders orders = OrdersDTO.FromDTO(ordersDTO);
            if(await _UnitOfWork.ordersRepo.AddOrderAsync(orders))
            {
                await _UnitOfWork.SaveAsync();
                responseDTO.StatusCode = Ok().StatusCode;
                responseDTO.Data = true;

            }

            return responseDTO;
        }
    };

}