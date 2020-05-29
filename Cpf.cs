namespace Aula_de_eranca
{
    public class Cpf : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(){
            if(cpf != null){
                return true;
            }

            return false;
        } 
    }
}