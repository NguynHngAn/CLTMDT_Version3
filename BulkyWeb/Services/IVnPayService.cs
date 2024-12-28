using BulkyBook.Models.ViewModels;

namespace BulkyBookWeb.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, ShoppingCartVM model);
        VnPaymentResponseVM PaymentExecute(IQueryCollection collections);

    }
}
