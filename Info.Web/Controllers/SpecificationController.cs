using Info.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Info.Web.Controllers
{
    public class SpecificationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SpecificationController(IUnitOfWork unitOfWork)
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
