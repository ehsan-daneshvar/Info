using Info.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Info.Web.Controllers
{
    public class Specification : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public Specification(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var specification = _unitOfWork.Specification.GetAll().FirstOrDefault();
            return View(specification);
        }
    }
}
