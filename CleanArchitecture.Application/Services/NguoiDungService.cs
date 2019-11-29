using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class NguoiDungService : INguoiDungService
    {
        private INguoiDungRepository iNguoiDungRepository;

        public NguoiDungService(INguoiDungRepository iNguoiDungRepository)
        {
            this.iNguoiDungRepository = iNguoiDungRepository;
        }
        public NguoiDungViewModel GetNguoiDungs()
        {
            return new NguoiDungViewModel()
            {
                NguoiDungs = iNguoiDungRepository.GetNguoiDungs()
            };
        }
    }
}
