﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_WebUI.Dtos.SocialMediaDtos
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        public string SocialMediaTitle { get; set; }
        public string SocialMediaIcon { get; set; }
        public string SocialMediaUrl { get; set; }
    }
}
