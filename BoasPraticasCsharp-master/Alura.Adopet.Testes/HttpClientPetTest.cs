using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsNotEmpty()
        {
            //Arrange
            var clientePet = new HttpClientPet();

            //Act
            var lista = await clientePet.ListPetsAsync();

            //Assert
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        [Fact]
        public async Task WhenAPIisOffReturnException()
        {
            //Arrange
            var clientePet = new HttpClientPet(uri: "http://localhost:1111");

            //Act + Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientePet.ListPetsAsync());

        }
    }
}