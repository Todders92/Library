using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

//new using directives
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Library.Controllers
{
  [Authorize] //new line
  public class CheckoutsController : Controller
  {
    private readonly LibraryContext _db;
    private readonly UserManager<ApplicationUser> _userManager; //new line

    //updated constructor
    public CheckoutsController(UserManager<ApplicationUser> userManager, LibraryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    //updated Index method
    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userCheckouts = _db.Checkouts.Where(entry => entry.User.Id == currentUser.Id);
      return View(userCheckouts);
    }

    public ActionResult Create()
    {
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View();
    }

    //updated Create post method
    [HttpPost]
    public async Task<ActionResult> Create(Checkout checkout, int BookId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      checkout.User = currentUser;
      _db.Checkouts.Add(checkout);
      if (BookId != 0)
      {
        _db.BookCheckout.Add(new BookCheckout() { BookId = BookId, CheckoutId = checkout.CheckoutId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCheckout = _db.Checkouts
          .Include(checkout => checkout.Books)
          .ThenInclude(join => join.Book)
          .FirstOrDefault(checkout => checkout.CheckoutId == id);
      return View(thisCheckout);
    }

    public ActionResult Edit(int id)
    {
      var thisCheckout = _db.Checkouts.FirstOrDefault(checkouts => checkouts.CheckoutId == id);
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View(thisCheckout);
    }

    [HttpPost]
    public ActionResult Edit(Checkout checkout, int BookId)
    {
      if (BookId != 0)
      {
        _db.BookCheckout.Add(new BookCheckout() { BookId = BookId, CheckoutId = checkout.CheckoutId });
      }
      _db.Entry(checkout).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCategory(int id)
    {
      var thisCheckout = _db.Checkouts.FirstOrDefault(checkouts => checkouts.CheckoutId == id);
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View(thisCheckout);
    }

    [HttpPost]
    public ActionResult AddCategory(Checkout checkout, int BookId)
    {
      if (BookId != 0)
      {
        _db.BookCheckout.Add(new BookCheckout() { BookId = BookId, CheckoutId = checkout.CheckoutId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCheckout = _db.Checkouts.FirstOrDefault(checkouts => checkouts.CheckoutId == id);
      return View(thisCheckout);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCheckout = _db.Checkouts.FirstOrDefault(checkouts => checkouts.CheckoutId == id);
      _db.Checkouts.Remove(thisCheckout);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
      var joinEntry = _db.BookCheckout.FirstOrDefault(entry => entry.BookCheckoutId == joinId);
      _db.BookCheckout.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}