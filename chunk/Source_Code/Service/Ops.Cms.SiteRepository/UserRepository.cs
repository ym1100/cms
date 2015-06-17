﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AtNet.Cms.DAL;
using AtNet.Cms.Domain.Interface.User;
using AtNet.Cms.Domain.Implement.User;
using AtNet.Cms.Domain.Interface.Value;
using AtNet.Cms.IDAL;

namespace AtNet.Cms.ServiceRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserCreator _creator;
        private IUserDAL _userDal;

        public UserRepository()
        {
            this._creator = new UserCreator();
            this._userDal = new UserDAL();
        }

        public IList<IRole> GetAppRoles(int appId)
        {
            //todo:  暂时不增加用户组
            return new List<IRole>();
        }

        public Credential GetUserCredential(int userId)
        {
            throw new NotImplementedException();
        }

        public int SaveUser(IUser user)
        {
            return -1;
        }

        public int SaveRole(IRole role)
        {
            throw new NotImplementedException();
        }

        public IUser CreateUser(int id, int flag)
        {
            return this._creator.CreateUser(this, id, flag);
        }


        public IUser GetUser(int id)
        {
            IUser user = null;
            this._userDal.GetUserById(id, rd =>
            {
                if (rd.HasRows)
                {
                    user = this.CreateUser(rd.GetInt32(0), Convert.ToInt32(rd["flag"]));
                    //todo: 
                }
            });
            return user;
        }


        public Credential GetCredentialByUserName(string username)
        {
            Credential cre = null;
            this._userDal.GetUserCredential(username, rd =>
            {
                if (rd.HasRows)
                {
                    cre = new Credential(rd.GetInt32(0),rd.GetInt32(1),username,rd.GetString(2),rd.GetInt32(3));
                }
            });
            return cre;
        }
    }
}
