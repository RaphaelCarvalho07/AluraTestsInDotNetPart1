using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTeste : IDisposable
    {

        private Veiculo veiculo;
        public ITestOutputHelper SaidaConsoleTeste;

        public VeiculoTeste( ITestOutputHelper _saidaConsoleTeste )
        {
            SaidaConsoleTeste = _saidaConsoleTeste;
            SaidaConsoleTeste.WriteLine( "Construtor invocado." );
            veiculo = new Veiculo();
        }

        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            // Arrange
            // var veiculo = new Veiculo();
            // Act
            veiculo.Acelerar( 10 );
            // Assert
            Assert.Equal( 100, veiculo.VelocidadeAtual );
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            // Arrange
            // var veiculo = new Veiculo();
            // Act
            veiculo.Frear( 10 );
            // Assert
            Assert.Equal( -150, veiculo.VelocidadeAtual );
        }

        [Fact( Skip = "Teste em desenvolvimento" )]
        public void TestaTipoVeiculo()
        {
            //Arrange
            // var veiculo = new Veiculo( "1" );
            //Act            
            //Assert
            Assert.Equal( TipoVeiculo.Automovel, veiculo.Tipo );
        }

        [Fact]
        public void FichaDeInformaçãoDoVeiculo()
        {
            // Arrange
            // var veiculo = new Veiculo();
            veiculo.Proprietario = "Raphilske Carvalho";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "ZAP-7419";
            veiculo.Cor = "Cinza";
            veiculo.Modelo = "Variante";

            // Act
            string dados = veiculo.ToString();
            // Console.WriteLine( dados );

            // Assert
            Assert.Contains( "Ficha do Veículo:", dados );
        }

        public void Dispose()
        {
            SaidaConsoleTeste.WriteLine( "Dispose invocado." );
        }
    }
}
