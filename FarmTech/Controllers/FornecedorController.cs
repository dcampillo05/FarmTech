using FarmTech.Models;
using FarmTech.Repositorio;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FarmTech.Controllers
{
	public class FornecedorController : Controller
	{
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        public FornecedorController(IFornecedorRepositorio fornecedorRepositorio) { 
            _fornecedorRepositorio = fornecedorRepositorio;
        }

		public IActionResult Index()
		{
            List<FornecedorModel> fornecedores = _fornecedorRepositorio.SearchAll();
			return View(fornecedores);
		}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FornecedorModel fornecedor) {

            try
            {
                if (ModelState.IsValid)
                {

                    _fornecedorRepositorio.Adicionar(fornecedor);
                    TempData["MensagemSucesso"] = "Fornecedor cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(fornecedor);
            }
            catch(System.Exception erro)
            {
                TempData["MensagemErro"] = $"Falha ao cadastrar o fornecedor! Tente novamente. Detalhe do erro: { erro.Message }";
                return View(fornecedor);
            }

        }

        
        public IActionResult Update(int id)
        {
            FornecedorModel fornecedor = _fornecedorRepositorio.ListForId(id);
            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Alter(FornecedorModel fornecedor)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _fornecedorRepositorio.Atualizar(fornecedor);
                    TempData["MensagemSucesso"] = "Fornecedor atualizado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(fornecedor);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Falha ao atualizar o fornecedor! Tente novamente. Detalhe do erro: {erro.Message}";
                return View(fornecedor);
            }
        }

        public IActionResult DeleteConfirm(int id)
        {
            FornecedorModel fornecedor = _fornecedorRepositorio.ListForId(id);

            if (fornecedor == null)
            {
                return NotFound(); 
            }

            return View(fornecedor);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                bool apagado = _fornecedorRepositorio.Deleter(id);

                if (apagado) {
                    TempData["MensagemSucesso"] = "Fornecedor deletado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Falha ao deletar o fornecedor! Tente novamente";
                }

                return RedirectToAction("Index");

            }
            catch (System.Exception erro) {
                TempData["MensagemErro"] = $"Falha ao deletar o fornecedor! Tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }



    
    }
}
