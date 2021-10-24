using System;
using System.Collections.Generic;

namespace Notas
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class TestContact
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public List<TestPhone> TestPhones { get; set; }
    }

    public class TestPhone
    {
        public int PhoneId { get; set; }
        public int ContactID { get; set; } // foreign key
        public string Number { get; set; }
    }

    public class WsVenda
    {
        public WsCabecalho WsCabecalho {get; set;}

        public virtual IEnumerable<WsItemVenda> WsItemVenda {get; set;}

        //public virtual ICollection<WsPagamento> WsPagamento {get; set;}

    }

    public class WsCabecalho
    {
        public int valor { get; set; }
        public int numerocupom { get; set; }
    }

    public class WsItemVenda
    {
        public int id { get; set; }
        public int prod { get; set; }
        public int quant { get; set; }
        public int preco { get; set; }
        public string descricao { get; set; }
    }

    public class WsPagamento
    {
        public int codpag { get; set; }
        public int numerocupom { get; set; }
        public int valor { get; set; }
    }

    

}
