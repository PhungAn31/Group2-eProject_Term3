using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using Project.Services.IRepository;
using System.Data;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class JobController : Controller
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public JobController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<JobDto> result = (await _unitOfWork.Job.GetAll("Department")).Select(c => _mapper.Map<JobDto>(c)).ToList();
            return View(result);
        }
    }
}
