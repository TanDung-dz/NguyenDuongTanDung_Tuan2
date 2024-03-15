namespace NguyenDuongTanDung_Tuan2.Models
{
    public interface ICategoryRepository 
    {
        IEnumerable<Category> GetAllCategories();
    }
}
