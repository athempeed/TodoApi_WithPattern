﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;
using TodoApi.Repositories.Interfaces;

namespace TodoApi.UOW
{
    public interface IUnitOfWork
    {
        void Save();
        IRepository<Todo> TodoRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<UserInRole> UserInRoleRepository { get; }
    }
}
