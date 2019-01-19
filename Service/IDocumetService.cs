﻿using BibDomain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDocumetService:IService<Document>
    {
        IEnumerable<Document> LISTElivreDispo();
    }
}
