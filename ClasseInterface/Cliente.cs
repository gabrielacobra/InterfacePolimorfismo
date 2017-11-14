namespace ClasseInterface
{
    public abstract class Cliente
    {
        public int Id { get; set; } //Não temos nome nesta classe, pois é a Pai e vamos criar as filhas PF e PJ, a primeira tem nome a a segunda tem razão social
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco End { get; set; }
    }
}