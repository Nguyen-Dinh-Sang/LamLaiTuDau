using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class NguoiDungController : Controller
    {
        private INguoiDungService iNguoiDungService;

        public NguoiDungController(INguoiDungService iNguoiDungService)
        {
            this.iNguoiDungService = iNguoiDungService;
        }

        public IActionResult Index()
        {
            NguoiDungViewModel model = iNguoiDungService.GetNguoiDungs();
            return View(model.NguoiDungs);
        }
    }
}