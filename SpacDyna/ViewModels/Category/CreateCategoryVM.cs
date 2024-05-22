using SpacDyna.Models;

namespace SpacDyna.ViewModels
{
    public class CreateCategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Img { get; set; }
        public List<Category> categories { get; set; }
    }
}
