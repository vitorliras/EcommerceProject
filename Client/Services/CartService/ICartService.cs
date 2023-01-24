using EcommerceProject.Shared;

namespace EcommerceProject.Client.Services.CartService
{
    public interface ICartService
    {
        event Action onChanged;
        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResponse>> GetCartProducts();
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductResponse product);
    }
}
