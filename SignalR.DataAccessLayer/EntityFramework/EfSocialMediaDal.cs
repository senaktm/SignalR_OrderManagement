﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(Context context) : base(context)
        {
        }
    }
}
