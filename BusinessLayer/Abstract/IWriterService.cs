﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        void WriterAdd(Writer writer);//İlk Writer:writer sınıfından parametre al demektir.
    }
}
