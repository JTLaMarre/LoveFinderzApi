using System;
using System.Collections.Generic;
using System.Linq;
using LoveFinderz.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveFinderz.Storing
{
    public class LoveFinderzRepository
    {
        private LoveFinderzContext _ctx;

        public LoveFinderzRepository(LoveFinderzContext context)
        {
            _ctx = context;
        }

        // public async void Insert<T>(T obj) where T : class
        // {
        //     await Task.Run(() =>_db.Set<T>().Add(obj));
        // }

        public void AddLover(string UserName,string Password)
        {
            Lover Lover = new Lover();
            Lover.UserName=UserName;
            Lover.Password = Password;
            _ctx.Lovers.Add (Lover);
            _ctx.SaveChanges();
        }

        public Lover GetLover(string UserName)
        {
            return _ctx
                .Lovers
                .FirstOrDefault(lover => lover.UserName == UserName);
        }

        public List<Lover> GetAllLovers()
        {
         return _ctx.Lovers.ToList();

        }

        public void UpdateLovers(string UserName, string Lover)
        {
            var User = GetLover(UserName);
            var NewLove = GetLover(Lover);
            if(NewLove!=null){
            User.lastLoved=DateTime.Now;
            User.LoverName=NewLove.UserName;
            }
            _ctx.SaveChanges();
        }
        public void SexBio(string UserName,string Sex,string Bio)
        {
            var User = GetLover(UserName);
            User.Sex=Sex;
            User.Bio=Bio;
            _ctx.SaveChanges();
        }
        public void DeleteLover(string UserName)
        {
            var Lover = GetLover(UserName);
            _ctx.Lovers.Remove(Lover);
            _ctx.SaveChanges();
        }
    }
}
