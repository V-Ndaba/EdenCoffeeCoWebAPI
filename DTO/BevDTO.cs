using EdenWebAPI.Models;

namespace EdenWebAPI.DTO
{
    public class BevDTO
    {
        public int DrinkID { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;

        public static Beverages FromDTO(BevDTO bevDTO)
        {
            return new Beverages
            {
                DrinkId = bevDTO.DrinkID,
                Drink = bevDTO.Name,
                Price = bevDTO.Price,
            };
        }

        public static BevDTO ToDTO(Beverages beverages)
        {
            return new BevDTO
            {
                DrinkID = beverages.DrinkId,
                Name = beverages.Drink,
                Price = (decimal)beverages.Price,
            };
        }
    }
}
