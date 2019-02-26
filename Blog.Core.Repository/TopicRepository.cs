﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.IRepository;
using Blog.Core.Model.Models;
using Blog.Core.RepositoryBase;

namespace Blog.Core.Repository
{
    public class TopicRepository: BaseRepository<Topic>, ITopicRepository
    {
    }
}
