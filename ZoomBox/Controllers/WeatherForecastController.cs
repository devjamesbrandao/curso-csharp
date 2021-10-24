using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Teste")]
        public async Task<IActionResult> Get()
        {
            //Bloco Dapper
            using(var sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BlocoNotas;Trusted_Connection=True"))
            {
                //Abre conexão com o servidor de banco de dados
                sql.Open();

                //Ação que deve ser executada (SELECT, UPDATE, INSERT, DELETE, CREATE...)
                var select = "SELECT * FROM Nomes";

                //Resultado da ação realizada
                var result = await sql.QueryAsync<dynamic>(select);

                //Criando um dicionário
                IDictionary<int, string> dict = new Dictionary<int, string>();

                //Percorrendo a lista com os elementos retornados do banco de dados e inserindo-os no dicionário
                foreach(var item in result)
                {
                    dict.Add(item.Id, item.nome);
                }

                //Resposta com os dados
                return Ok(dict);

            }
        }

        [HttpGet("Teste2")]
        public async Task<IActionResult> RetornaFiltro()
        {
            
            //Bloco Dapper
            using(var sql = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BlocoNotas;Trusted_Connection=True"))
            {
                //Abre conexão com o servidor de banco de dados
                sql.Open();

                string cupoms = "SELECT top(2) [numerocupom] FROM [BlocoNotas].[dbo].[WsVenda]";

                string cabecalho = $"SELECT [numerocupom], [valor] FROM [BlocoNotas].[dbo].[WsVenda] where numerocupom = @numerocupom";

                string itens = $"SELECT [id], [numerocupom], [prod], [quant], [preco], [descricao] FROM [BlocoNotas].[dbo].[WsItemVenda] where numerocupom = @numerocupom";

                List<int> ids = (await sql.QueryAsync<int>(cupoms)).ToList();

                List<WsVenda> vendas = new List<WsVenda>(ids.Count);

                foreach(int numerocupom in ids)
                {

                    var re1 = await sql.QueryFirstOrDefaultAsync<WsCabecalho>(cabecalho, new {
                        numerocupom
                    });

                    var re2 = await sql.QueryAsync<WsItemVenda>(itens, new {
                        numerocupom
                    });

                    vendas.Add(new WsVenda {
                        WsCabecalho = re1,
                        WsItemVenda = re2
                    });

                }

                //Resposta com os dados
                return Ok(vendas);

            }

        }

    }
}
