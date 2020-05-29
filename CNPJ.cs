namespace Aula_de_eranca
{
    // Chamamos a Herança da super classe "Pessoa"
    public class CNPJ : Pessoa
    {
        public string cnpj;
        public bool ValidarCNPJ(){
            if(cnpj != null){
                return true;
            }
            return false;
        }
    }
}