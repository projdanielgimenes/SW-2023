namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Daniel Sanz";
        cf.Email = "danielsanzgimenes@gmail.com";
        cf.Telefone = "4827-8517";
        cf.Idade = 17;
        cf.Cpf = 012345678910;
        cj.Nome = "Vitor Martins";
        cj.Email = "vitormartins@gmail.com";
        cj.Telefone = "99889-3757";
        cj.Cnpj = 98765432101;
        cj.Inscricao =0991141420;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
    }
} 

