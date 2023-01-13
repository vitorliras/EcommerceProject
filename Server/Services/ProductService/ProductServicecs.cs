namespace EcommerceProject.Server.Services.ProductService
{
    public class ProductServicecs : IProductService
    {
        private readonly DataContext _context;

        public ProductServicecs(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductsAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                response.Success = false;
                response.Message = "Desculpe, mas o produto não existe.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }
    }
}
