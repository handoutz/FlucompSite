using DreamSeat.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace NewFlucompMVC.Areas.Admin534139597.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string PassHash { get; set; }
    }
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public string PWHash(string pw)
        {
            //vadsfGFSDc423fSdg
            //return SHA512.Create().ComputeHash()
            using (var mem = new MemoryStream())
            using (var write = new StreamWriter(mem))
            {
                write.Write(Password);
                write.Write("asdfamsverklmt345sgvdfgserbt4526b5464wcw");
                write.Flush();
                mem.Position = 0;
                return Convert.ToBase64String(SHA512.Create().ComputeHash(mem));
            }
        }
    }
}