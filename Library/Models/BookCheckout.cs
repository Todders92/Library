namespace Library.Models
{
  public class BookCheckout
    {       
        public int BookCheckoutId { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int CheckoutId { get; set; }
        public Book Book { get; set; }
        public Checkout Checkout { get; set; }
    }
}