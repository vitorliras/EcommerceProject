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
    }
}
