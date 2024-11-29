using FarmTech.Models;

namespace FarmTech.Repositorio
{
    public interface IFornecedorRepositorio
    {
        FornecedorModel ListForId(int id);
        List<FornecedorModel> SearchAll();
        FornecedorModel Adicionar(FornecedorModel fornecedor);

        FornecedorModel Atualizar(FornecedorModel fornecedor);

        bool Deleter(int id);
    }
}
