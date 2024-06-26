﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Coffee_Shop_Management_System.DTO
{
    public class UserAccountDTO
    {
        private string _ID;
        private string _UserName;
        private string _Password;
        private bool _Authentication;
        public string ID { get { return _ID; } set { _ID = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        public bool Authentication { get { return _Authentication; } set { _Authentication = value; } }
        public UserAccountDTO() { }
        public UserAccountDTO(string ID, string UserName, string Password)
        {
            _ID = ID;
            _UserName = UserName;
            _Password = Password;
        }
    }
}
