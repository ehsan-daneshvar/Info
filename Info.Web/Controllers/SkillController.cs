using Info.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Info.Web.Controllers
{
    public class SkillController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SkillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var allSkills = _unitOfWork.Skill.GetAll();
            return View(allSkills);
        }
    }
}
