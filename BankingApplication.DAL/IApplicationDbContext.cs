﻿using BankingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.DAL
{
    public interface IApplicationDbContext :  IDisposable
    {
        IDbSet<Transaction> Transactions { get; set; }
        int SaveChanges();
    }
}
