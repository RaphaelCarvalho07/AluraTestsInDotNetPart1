using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        [Trait( "Funcionalidade", "Acelerar" )]
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Acelerar( 10 );
            // Assert
            Assert.Equal( 100, veiculo.VelocidadeAtual );
        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear( 10 );
            // Assert
            Assert.Equal ( -150, veiculo.VelocidadeAtual );
        }

        [Fact(DisplayName = "Testa o tipo de veículo", Skip = "Teste em desenvolvimento")]
        public void TestaTipoVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo("1");
            //Act            
            //Assert
            Assert.Equal( TipoVeiculo.Automovel, veiculo.Tipo );
        }
    }
}
