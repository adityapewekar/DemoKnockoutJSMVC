using StopAndShop.DAL.IRepository;
using StopAndShop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StopAndShop.DAL.Repository
{
    public class RegisterRepository:IRegisterRepository
    {
        public List<Genders> PopulateGenderList()
        {
            List<Genders> genderList = new List<Genders>();
            //using (StopAndShopEntities entites = new StopAndShopEntities())
            //{
            //    genderList= entites.Genders.Select(a => new Genders
            //    {
            //        id = a.id,
            //        GenderValue = a.Gender1
            //    }).ToList();
            //    return genderList;
            //}

            genderList.Add(new Genders { id = 1, GenderValue = "Male" });
            genderList.Add(new Genders { id = 2, GenderValue = "Female" });
            genderList.Add(new Genders { id = 3, GenderValue = "Transgender" });

            return genderList;
        }

        public bool AddNewUser(UserDetails data)
        {
            using (StopAndShopEntities entites = new StopAndShopEntities())
            {
                 entites.Users.Add(new User{
                    Name=data.Name,
                    Gender=data.Gender
                });

                entites.SaveChanges();
            }
            return true;
        }
    }
}