namespace ClasseInterface
{
    public class PF : Cliente, IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }

        public PF(int Id, string Nome, string CPF, string Email, string Telefone, Endereco endereco)
        {
            base.Id=Id;
            this.Nome=Nome;
            this.CPF=CPF;
            base.Email=Email;
            base.Telefone=Telefone;
            base.End=endereco;            
        }
        public string Cadastro()
        {
            string composicao = "Id do cliente: "+Id+
                                "\nNome do cliente: "+Nome+
                                "\nCPF do cliente: "+CPF+
                                "\nE-mail do cliente: "+Email+
                                "\nTelefone do cliente: "+Telefone+
                                "\nEndereço do cliente: "+End.Logradouro+", "+End.Numero+" - "+End.Bairro;
                                
            return "Dados do cliente\n\n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}