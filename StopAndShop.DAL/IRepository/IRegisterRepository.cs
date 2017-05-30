using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopAndShop.Entites;

namespace StopAndShop.DAL.IRepository
{
    public interface IRegisterRepository
    {
         List<Genders> PopulateGenderList();
        bool AddNewUser(UserDetails data);
    }
}
