API desenvolvida em ASP .NET MVC com SQLServer.

Para executar, é só mudar a connectionString no arquivo appsettings.json.

Depois disso, é só digitar o comando update-database no diretório do projeto.

Para usar a API, é só acessar /pedido e passar a requisição via POST.

Exemplo:

{
    "Frete" : 10.9,
    "Total" : 164.80,

    "Cliente" : {
        "Email" : "vinicius@gmail.com",
        "CPF" : "123.456.789-10",
        "CEP" : "12345-678"
    },

    "Itens" : [{
        "SKU" : 20,
        "Descricao" : "BOOSTERGEN DEEP CARE +",
        "Valor" : "89.90",
        "Quantidade" : 5
    },{
        "SKU" : 40,
        "Descricao" : "BOOSTERGEN DEEP CARE +",
        "Valor" : "74.90",
        "Quantidade" : 3 
    }]
}
