﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Wrapper.NoutFondExeption
{
    public class NotFoundExeption : Exception
    {
        public NotFoundExeption(string message) : base(message) { }
    }


}
