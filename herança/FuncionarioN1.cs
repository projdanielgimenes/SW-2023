namespace herança;
class FuncionarioN1: Funcionario
{  
   

    
public override double Participacao(){
    return base.Participacao()* 0.01;
 }
}