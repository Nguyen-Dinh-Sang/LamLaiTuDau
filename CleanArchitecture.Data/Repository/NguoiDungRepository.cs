using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Data.Context;

namespace CleanArchitecture.Data.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        private WebEnglishDBContext webEnglishDBContext;

        public NguoiDungRepository(WebEnglishDBContext webEnglishDBContext)
        {
            this.webEnglishDBContext = webEnglishDBContext;
        }
        public IEnumerable<NguoiDung> GetNguoiDungs()
        {
            return webEnglishDBContext.NguoiDung;
        }
    }
}
