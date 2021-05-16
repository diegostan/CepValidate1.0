using CepValidate.Domain.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CepValidate.Domain.ValueObjects;
using CepValidate.Domain.API.Convertions;

namespace CepValidate.Domain.API.Controllers
{
    [Route("v1/ViaCep/")]
    public class ViaCepController : ControllerBase
    {
        public ViaCepController()
        {
        }   

        [AllowAnonymous]        
        [Route("{cep}")]
        [HttpGet]
        public async Task<IEnumerable<Enderecamento>> GetEnderecamento(string cep)
        {
            var list = new List<Enderecamento>();
            using HttpClient client = new() {BaseAddress = new Uri(Urls.Urls.ViaCepUrl(cep))};
            JsonSerializerOptions opt= new JsonSerializerOptions();
            
            var getJson = await client.GetFromJsonAsync<EnderecamentoJson>("");
            

            list.Add(getJson.ConvertJson(getJson));  
            return list;

            
        }
    }
}