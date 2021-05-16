using System.Collections.Generic;
using CepValidate.Domain.Entities.Models;
using CepValidate.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CepValidate.Domain.Queries;

namespace CepValidation.Domain.Test.Queries
{
    [TestClass]
    public class EnderecamentoQueriesTest
    {
        IList<Enderecamento> fakeRepos = new List<Enderecamento>();
     
        /*Red green refactory*/
        [TestMethod]
        public void QueryValidateFail()
        {
            var cep = "12345678";
            var result = fakeRepos.AsQueryable()
            .Where(EnderecamentoQueries.GetEnderecamentoByCep(cep))
            .ToList();

            Assert.AreNotEqual(0, result.Count());
        }

        /*red green refactory*/
        [TestMethod]
        public void QueryValidateOk()
        {
            string cep = "12345678";
            var result = new List<Enderecamento>();

             result = fakeRepos.AsQueryable()
            .Where(EnderecamentoQueries.GetEnderecamentoByCep(cep)).ToList();               
            
            Assert.AreEqual(1, result.Count());
        }

        
           public EnderecamentoQueriesTest()
        {

            fakeRepos.Add(new Enderecamento(cep: "12345678", logradouro: "Rua", complemento: "",
            bairro: "Jd tal", regiao: new Regiao(localidade: "", uf: ""), ibge: 1234, gia: 1234, ddd: 11, siafi: 0
            ));

            fakeRepos.Add(new Enderecamento(cep: "00000000", logradouro: "Rua", complemento: "",
            bairro: "Jd tal", regiao: new Regiao(localidade: "", uf: ""), ibge: 1234, gia: 1234, ddd: 11, siafi: 0
            ));

            fakeRepos.Add(new Enderecamento(cep: "87654321", logradouro: "Rua", complemento: "",
            bairro: "Jd tal", regiao: new Regiao(localidade: "", uf: ""), ibge: 1234, gia: 1234, ddd: 11, siafi: 0
            ));

            
        }
    
    }
}