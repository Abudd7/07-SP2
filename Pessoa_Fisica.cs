
namespace Atividade
{
    class Pessoa_Fisica : Clientes
    {
        public string cpf {get; set;}
        public string rg {get; set;}

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        internal void Pagar_Imposto(float val_pag)
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            throw new NotImplementedException();
        }
    }
}