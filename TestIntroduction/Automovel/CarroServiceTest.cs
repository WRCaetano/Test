using Moq;
using Xunit;

//install-package xunit
//install-package xunit.runner.visualstudio
//install-package moq

namespace Automovel
{
    public class CarroServiceTest
    {
        [Fact]//Padrao AAA
        public void CarroService_ConsultarMotor_RetornaNomeMotor()
        {
            //Arrange = Cenario
            //Efetua a "Gambi/Instancia" da Interface
            var repositorio = new Mock<ICarroRepository>();
            //Cria um objeto carro que será o retorno do repositorio
            var carro = new Carro()
            {
                Motor = "Honda"
            };
            //Definição de retorno do objeto carro
            repositorio.Setup(o => o.ConsultarMotor("Honda")).Returns(carro);
            //Instancia a classe service onde ira retornar o objeto mockado pelo repositorio
            var motorService = new CarroService(repositorio.Object);

            //Act = Ação
            //Traz o retorno da classe Service
            var motorConsultar = motorService.ConsultarMotor("Honda");

            //Assert = Validação
            //Faz a validação do mock com a service
            Assert.True(carro.Motor == motorConsultar.Motor);
        }

        [Fact]//Padrao AAA
        public void CarroService_ConsultarMotor_RetornaNomeMotorRepository()
        {
            //Arrange = Cenario
            var repositorio = new Mock<CarroRepository>();
            var carro = new Carro()
            {
                Motor = "Honda"
            };
            repositorio.Setup(o => o.ConsultarMotor("Honda")).Returns(carro);
            var motorRepository = new CarroRepository();

            //Act = Ação
            var motorConsultar = motorRepository.ConsultarMotor("Honda");

            //Assert = Validação
            Assert.True(carro.Motor == motorConsultar.Motor);
        }
    }
}
