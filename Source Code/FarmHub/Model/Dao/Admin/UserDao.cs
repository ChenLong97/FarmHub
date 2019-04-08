using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao.Admin
{
    public class UserDao
    {
        FarmHubDbContext db = null;
        public UserDao()
        {
            db = new FarmHubDbContext();
        }
        public int Insert(USER_AUTHENTICATION entity)
        {
            db.USER_AUTHENTICATION.Add(entity);
            db.SaveChanges();
            return entity.Id_User;
        }

        //public Boolean Update(USER_AUTHENTICATION entity)
        //{
        //    try
        //    {
        //        var user = db.USER_AUTHENTICATIONs.Find(entity.ID);
        //        user.Name_User = entity.Name_User;
        //        user.Id_User = entity.Address;


        //        if (!string.IsNullOrEmpty(entity.Password))
        //        {
        //            user.Password = entity.Password;
        //        }

        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }


        //}

        public bool Delete(int id)
        {
            try
            {
                var user = db.USER_AUTHENTICATION.Find(id);
                db.USER_AUTHENTICATION.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
     

        public USER_AUTHENTICATION GetUserByID(string username)
        {
            return db.USER_AUTHENTICATION.SingleOrDefault(x => x.Name_User == username);
        }

        public USER_AUTHENTICATION ViewDetail(int id)
        {
            return db.USER_AUTHENTICATION.Find(id);

        }

        public IEnumerable<USER_AUTHENTICATION> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<USER_AUTHENTICATION> model = db.USER_AUTHENTICATION;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name_User.Contains(searchString) || x.Name_User.Contains(searchString));
            }
            return model.OrderByDescending(x => x.CreatedDate).ToPagedList(page, pageSize);
        }

        public int? ChangeStatus(long id)
        {
            #region Example
            //var user = db.USER_AUTHENTICATION.Find(id);
            //user.Status_User = !user.Status;
            //db.SaveChanges();
            //return user.Status;
            #endregion

            var user = db.USER_AUTHENTICATION.Find(id);

            switch (user.Status_User)
            {
                case 1:
                    user.Status_User = 2;
                    break;

                case 2:
                    user.Status_User = 3;
                    break;
                case 3:
                    user.Status_User = 1;
                    break;
            }

            return user.Status_User;

        }

    }


}
