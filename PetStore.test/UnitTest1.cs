using Moq;
using TaylorsPetStore.Logic;
using TaylorsPetStore.Repositories;

namespace TaylorsPetStore.Tests
{
    public class ProductLogicTests 
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;
        private readonly Mock<IOrderRepository> _orderRepositoryMock; 
        private readonly ProductLogic _productLogic;

        public ProductLogicTests()
        {
            _productRepositoryMock = new Mock<IProductRepository>();
            _orderRepositoryMock = new Mock<IOrderRepository>();
            _productLogic = new ProductLogic(_productRepositoryMock.Object, _orderRepositoryMock.Object);
        }

        [Fact] 
        public void GetProductById_CallsRepo()
        {
            _productRepositoryMock.Setup(x => x.GetProductById(10))
                .Returns(new Product { ProductId = 10, Name = "Test Product" });
            
            _productLogic.GetProductById(10);
            
            _productRepositoryMock.Verify(x => x.GetProductById(10), Times.Once);
        }
    }
}