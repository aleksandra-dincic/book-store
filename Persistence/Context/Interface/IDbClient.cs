﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using MongoDB.Driver;

namespace Persistence.Context.Interface
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetAllBooks();
    }
}