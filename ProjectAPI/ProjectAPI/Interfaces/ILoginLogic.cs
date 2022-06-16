using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Interfaces
{
    public interface ILoginLogic
    {
        Task Login(string login, string password);
    }
}
