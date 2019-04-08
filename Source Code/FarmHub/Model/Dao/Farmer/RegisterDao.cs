using Model.EF;
using Model.EF.REGISTER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao.Farmer
{
    class RegisterDao
    {
        FarmHubDbContext db = null;
        public RegisterDao()
        {
            db = new FarmHubDbContext();
        }
        public int Insert(FARMER_REGISTER entity)
        {
            db.USER_AUTHENTICATION.Add(entity.UserAu);
            db.FARMERs.Add(entity.Farmer);
            return entity.UserAu.Id_User;
        }
    }
}
