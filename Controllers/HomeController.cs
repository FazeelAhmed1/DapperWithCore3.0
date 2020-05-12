using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWithDepper.Models;
using CoreWithDepper.DAL;
using CoreWithDepper.DAL.Interface;

namespace CoreWithDepper.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		IStudenManager _studenManager;

		public HomeController(ILogger<HomeController> logger, IStudenManager StudenManager)
		{
			_logger = logger;
			_studenManager = StudenManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult GetAllStudents()
		{
			return View(_studenManager.GetStudent());
		}		
		public IActionResult AddStudent()
		{
			return View();
		}		
        [HttpPost]
		public IActionResult AddStudent(Student student)
		{
			_studenManager.AddStudent(student);
			return View();
		}		


	}
}
