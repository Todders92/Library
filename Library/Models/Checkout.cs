using System.Collections.Generic;
using Library.Models;

namespace Library.Models
{
  public class Checkout
  {
    
    public int CheckoutId { get; set; }
    public string BookTitle { get; set; }
    public string DueDate { get; set; }
    public string History { get; set; }
    public virtual ApplicationUser User { get; set; }

    public ICollection<BookCheckout> Books { get; set; }
    public Checkout(int checkoutId, int bookTitle)
    {
      CheckoutId = checkoutId;
      BookTitle = bookTitle;
      this.Books = new HashSet<BookCheckout>();
    }
    
    public Checkout(){}
  }
}