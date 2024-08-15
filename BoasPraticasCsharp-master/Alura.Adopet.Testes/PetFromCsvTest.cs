using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes
{
    public class PetFromCsvTest
    {
        [Fact]
        public void ValidStringReturnsPet()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
            //var conversor = new PetFromCsv();
            //Act
            Pet pet = linha.ConverteDoTexto();
            //Assert
            Assert.NotNull(pet);
        }

        [Fact]
        public void NullStringThrowsNullException()
        {
            //Arrange
            string? linha = null;
            //Act + Assert
            Assert.Throws<ArgumentNullException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void EmptyStringThrowsArgumentException()
        {
            //Arrange
            string linha = "";
            //Act + Assert
            Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void insufficientNumberOfArguments()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";
            //Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void InvalidGuidThrowsArgumentException()
        {
            //Arrange
            string linha = "456b24f4--4a80e8854a41;Lima Limão;1";
            //Act + Assert
            Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void InvalidTypeThrowsArgumentException()
        {
            //Arrange
            string? linha = "456b24f4--4a80e8854a41;Lima Limão;3";
            //Act + Assert
            Assert.Throws<ArgumentException>(() => linha.ConverteDoTexto());
        }
    }
}
