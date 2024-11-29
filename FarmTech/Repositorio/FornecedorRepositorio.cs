using FarmTech.Data;
using FarmTech.Models;

namespace FarmTech.Repositorio
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly AppDbContext _context;


        public FornecedorRepositorio(AppDbContext context) { 
            _context = context;
        }

        public FornecedorModel Adicionar(FornecedorModel fornecedor)
        {
             _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
            return fornecedor;    
        }

        public List<FornecedorModel> SearchAll()
        {
            return _context.Fornecedor.ToList();
        }

        public FornecedorModel ListForId(int id)
        {
            return _context.Fornecedor.FirstOrDefault(x => x.Id == id);
        }

        public FornecedorModel Atualizar(FornecedorModel fornecedor)
        {
            FornecedorModel fornecedorDb = ListForId(fornecedor.Id);

            if (fornecedorDb == null){
                throw new Exception("Houve um erro na atualização"); 
            }

            fornecedorDb.Name = fornecedor.Name;
            fornecedorDb.Cnpj = fornecedor.Cnpj;
            fornecedorDb.Email = fornecedor.Email;
            fornecedorDb.Numero = fornecedor.Numero;

            _context.Fornecedor.Update(fornecedorDb);
            _context.SaveChanges();
            return fornecedorDb;

        }

        public bool Deleter(int id)
        {

            FornecedorModel fornecedorDb = ListForId(id);

            if (fornecedorDb == null)
            {
                throw new Exception("Houve um erro na deleçao do Fornecedor");
            }

            _context.Fornecedor.Remove(fornecedorDb);
            _context.SaveChanges(); 

            return true;

        }
    }
}
