using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CepConsoleApi
{
    class CepResponse
    {
        // link do via cep de consulta => https://viacep.com.br/

        [JsonProperty("cep")]
        public string Cep { get; set; } //prop tab tab

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("unidade")]
        public string Unidade { get; set; }

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

    }
}
