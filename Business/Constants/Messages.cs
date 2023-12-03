using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CategoryDeleted { get; internal set; }
        public static string CategoryUpdated { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }

        public static string SuccessfulLogin = "User Login!";
        public static string UserRegistered = "User Registered!";
        public static string UserAlreadyExists = "User Already Registered!";
        public static string AccessTokenCreated = "User Token Created!";

        public static string CategoryAdded = "Added";
        public static string ErrorMessage = " Error Message";
        public static string CategoriesListed = "Listed";
        public static string AuthorizationDenied = "Not Authorization!";
    }
}
