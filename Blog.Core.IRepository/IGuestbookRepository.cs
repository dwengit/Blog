﻿using Blog.Core.IRepositoryBase;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IRepository
{
    public interface IGuestbookRepository : IBaseRepository<Guestbook>
    {
    }
}
