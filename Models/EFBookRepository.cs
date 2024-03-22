
namespace MyAmazonWebsite.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;
        public EFBookRepository(BookstoreContext temp) { // Constructor
            _context = temp;
        } 
        public IQueryable<Book> Books => _context.Books;
    }
}
