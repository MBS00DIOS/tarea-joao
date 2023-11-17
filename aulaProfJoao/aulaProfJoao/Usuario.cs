public class Usuario
{

    private string nome;// = tx_nome.Text;
   // private string senha;// = tx_senha.Text;
    private string CPF;
    private double salario;
    


    public string GetNome(string nome)
    {
        return nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }


    public string GetCpf(string CPF)
    {
        return CPF;
    }

    public void SetCpf(string CPF)
    {
        this.CPF = CPF;
    }
    public double GetSalario(double salario)
    {
        return salario;
    }
    public void SetSalario(double salario)
    {
        this.salario = salario;
    }
}
