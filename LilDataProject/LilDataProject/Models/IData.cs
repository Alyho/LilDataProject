using LilDataProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LilDataProject.Models
{
    public interface IData
    {
        User GetUser(int userId);
    }
}