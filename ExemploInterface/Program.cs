using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produto pr = new Produto(){
            //     Id=30, //Passagem das informações direto nas propriedades, não utilizando o construtor pr.Id=30; pr.Nome="Sabão"... Poderia ser no parênteses também Produto pr = new Produto(Id:30, Nome:"Sabão", Descricao: "em pó", Preco: 12)
            //     Nome="Sabão",
            //     Descricao="Em pó",
            //     Preco=12
            // };
            // Console.WriteLine(pr.Cadastro());

            Endereco endereco = new Endereco();
            endereco.Logradouro = "Alameda Barros";
            endereco.Numero = "131";
            endereco.Bairro = "Santa Cecília";
            
            PF pf = new PF(10, "Gabriela Lima", "07939313983", "gabicobra@gmail.com","1198498-1497", endereco);
            Console.WriteLine(pf.Cadastro());
        }
    }
}
