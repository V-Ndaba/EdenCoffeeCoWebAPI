using EdenWebAPI.Models;

namespace EdenWebAPI.DTO
{
    public class OrdersDTO
    {
        public int Id { get; set; } = 0;
        public int DrinkId { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public decimal Tip { get; set; } = 0;
        public decimal Price { get; set; } = 0;

        public static Orders FromDTO(OrdersDTO Dto)
        {
            return new Orders
            {
                OrderId = Dto.Id,
                Drinks = Dto.DrinkId,
                Quantity = Dto.Quantity,
                Tip = Dto.Tip,
                TotalPrice = Dto.Price
            };
        }

    }


}
