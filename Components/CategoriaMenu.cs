using LanchoneteSite.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteSite.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoRepository;

        public CategoriaMenu(ICategoriaRepository categoRepository)
        {
            _categoRepository = categoRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _categoRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categoria);
        }
    }
}
