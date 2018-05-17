using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public static class CheckSum
    {
        public static bool GetCheckSum(this DefaultInput objDefaultInput)
        {
            if (objDefaultInput.UserID == "16341" && objDefaultInput.Password == "Powai")
                return true;
            return false;
        }
    }
}