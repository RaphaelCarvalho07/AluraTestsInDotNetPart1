using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class PatioTestes
    {
        [Fact]
        public void ValidaFaturamento()
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "Raphilske Carvalho";
            veiculo.Tipo = TipoVeiculo.Motocicleta;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo( veiculo );
            estacionamento.RegistrarSaidaVeiculo( veiculo.Placa );

            // Act
            double faturamento = estacionamento.TotalFaturado();

            // Assert
            Assert.Equal( 1, faturamento );
        }

        [Theory]
        [InlineData( "Raphilske Carvalho", "ASD-1498", "Preto", "Gol" )]
        [InlineData( "Bina Carvalho", "ASD-1490", "Preto", "Peugeot" )]
        [InlineData( "Kael Carvalho", "ASD-1430", "Amarelo", "Civic" )]
        [InlineData( "Isabela Carvalho", "ASD-1178", "Amarelo", "Porshe" )]

        public void ValidaFaturamentoComVariosVeiculos( string proprietario, string placa, string cor, string modelo )
        {
            // Arrange
            Patio estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo( veiculo );
            estacionamento.RegistrarSaidaVeiculo( placa );

            // Act
            double faturamento = estacionamento.TotalFaturado();

            // Assert
            Assert.Equal( 2, faturamento );
        }

        [Theory]
        [InlineData( "Raphilske Carvalho", "ASD-1498", "Preto", "Gol" )]

        public void LocalizaVeiculoNoPatio( string proprietario, string placa, string cor, string modelo )
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();

            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo( veiculo );

            // Act
            var consultado = estacionamento.PesquisaVeiculo( placa );

            // Assert
            Assert.Equal( placa, consultado.Placa );
        }
    }
}