using System.Collections.Generic;
using Library.Models;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public virtual ApplicationUser User { get; set; }

    public ICollection<AuthorBook> Authors { get; set;}
  }
}