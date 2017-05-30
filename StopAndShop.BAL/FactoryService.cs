using StopAndShop.DAL.IRepository;
using StopAndShop.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StopAndShop.BAL
{
    public class FactoryService:IDisposable
    {
        internal static IRegisterRepository GetRegisteration()
        {
            IRegisterRepository obj = new RegisterRepository();
                return obj;
        }

        public void Dispose() { }
    }
}