using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
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
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear( 10 );
            // Assert
            Assert.Equal ( -150, veiculo.VelocidadeAtual );
        }

        [Fact]
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