using StopAndShop.DAL.IRepository;
using StopAndShop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StopAndShop.BAL
{
    public class RegistrationService
    {
        private readonly  IRegisterRepository _registrationService;
            
         public  RegistrationService()
        {
            _registrationService = FactoryService.GetRegisteration();
        }

        public List<Genders> PopulateGenderList()
        {
            return _registrationService.PopulateGenderList();
        }

        public bool AddNewUser(UserDetails data)
        {
            return _registrationService.AddNewUser(data);
        }
    }
}