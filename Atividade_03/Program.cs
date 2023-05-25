namespace exercicio03;
class Program
{
    static void Main(string[] args)
    {
        

        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Daniel Sanz";
        cf.Email = "danielsanzgimenes@gmail.com";
        cf.Telefone = "4827_8517";
        cf.Idade = 17;
        cf.Cpf = 012345678910;
        cj.Nome = "Bianca";
        cj.Email = "Bianca@gmail.com";
        cj.Telefone = "99889-3757";
        cj.Cnpj = 98765432101;
        cj.Inscricao = 101112131415;
        cj.Prazo = 10;
        cf.Prazo = 10;

        Console.WriteLine(cf.MostraDados());
         Console.WriteLine(cf.CalcularPrestacao());
        Console.WriteLine(cj.MostraDados());
         Console.WriteLine(cj.CalcularPrestacao());
       
        
    }
} 

