namespace CadastroLivrosPOO;

public interface Ipessoa
{
    string Nome { get; set; }
    string CPF { get; set; }
    void ObterIdentificacao();
}

