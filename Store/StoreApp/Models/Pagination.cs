namespace StoreApp.Models
{
    public class Pagination
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrenPage { get; set; }

        public int TotalPages => 
            (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
    }
}