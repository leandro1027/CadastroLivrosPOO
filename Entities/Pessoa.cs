namespace CadastroLivrosPOO;

public abstract class Pessoa : Ipessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }

    public Pessoa(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }

    public abstract void ObterIdentificacao();
}


