﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface INguoiDungService
    {
        NguoiDungViewModel GetNguoiDungs();
    }
}
