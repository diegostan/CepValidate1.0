using CepValidate.Domain.Commands;
using CepValidate.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CepValidate.Domain.Test.Commands
{
    [TestClass]
    public class CriarEnderecamentoCommandTest
    {

        /*red green refactory*/
        [TestMethod]
        public void CommandValidateFail()
        {
            var command = new CriarEnderecamentoCommand(cep:"", logradouro:"", complemento:"",
            bairro:"", regiao: new Regiao(localidade:"", uf:""), ibge:1234, gia:1234, ddd:11, siafi:0
            );

            Assert.AreEqual(false, command.Validate());
        }

        /*red green refactory*/
        [TestMethod]
        public void CommandValidateOk()
        {
            var command = new CriarEnderecamentoCommand(cep:"12345678", logradouro:"Rua", complemento:"",
            bairro:"Jd Saude", regiao: new Regiao(localidade:"", uf:""), ibge:1234, gia:1234, ddd:11, siafi:0
            );
            
            Assert.AreEqual(true, command.Validate());
        }


    }
}