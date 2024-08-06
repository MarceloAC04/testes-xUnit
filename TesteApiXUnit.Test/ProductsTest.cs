using api_teste.Domains;
using api_teste.Interfaces;
using Moq;

namespace TesteApiXUnit.Test
{
    public class ProductsTest
    {
        [Fact]
        public void Get()
        {
            //Arrange
            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4060", Price = 500},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4070", Price = 600},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4080", Price = 700}
            };

            //Cria um obj de simulacao do tipo ProductsRepository
            var mockRepository = new Mock<IProductsRepository>();

            //Configura o metodo Listar para retornar a lista de produtos "mock"
           mockRepository.Setup(x => x.Listar()).Returns(products);

            //Act
            //Chama o metodo listar e armazena o resultado em result
            var result = mockRepository.Object.Listar();

            //Assert
            Assert.Equal(3, result.Count);

        }

        //Post
        [Fact]
        public void Post()
        {
            //Arrange
            var product = new Products { IdProduct = Guid.NewGuid(), Name = "Coca-Cola", Price = 8 };

            var products = new List<Products>();

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Cadastrar(product)).Callback<Products>(x => products.Add(product));

            //Act
            mockRepository.Object.Cadastrar(product);

            //Assert
            Assert.Equal(1, products.Count);
        }

        //GetById
        [Fact]
        public void GetById()
        {
            //Arrange
            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4060", Price = 500},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4070", Price = 600},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4080", Price = 700}
            };

            var produtoBuscado = products[1];
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.BuscarPorId(produtoBuscado.IdProduct)).Returns(produtoBuscado);

            //Act
            var result = mockRepository.Object.BuscarPorId(produtoBuscado.IdProduct);

            //Assert
            Assert.Equal(products[1], result);
        }

        //Delete
        [Fact]
        public void Delete() 
        {
            //Arrange
            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4060", Price = 500},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4070", Price = 600},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4080", Price = 700}
            };

            var produtoBuscado = products[0];
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Deletar(produtoBuscado.IdProduct)).Callback<Guid>(x => products.Remove(produtoBuscado));

            //Act
            mockRepository.Object.Deletar(produtoBuscado.IdProduct);

            //Assert
            Assert.Equal(2, products.Count());

        }

        //desafio
        //Update
        [Fact]
        public void Update()
        {
            //Arrange
            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4060", Price = 500},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4070", Price = 600},
                new Products {IdProduct = Guid.NewGuid(), Name = "Rtx 4080", Price = 700}
            };

  


        }
    }
}