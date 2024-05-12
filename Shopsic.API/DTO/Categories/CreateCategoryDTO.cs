using Shopsic.Domain;

namespace Shopsic.API.DTO.Categories
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
