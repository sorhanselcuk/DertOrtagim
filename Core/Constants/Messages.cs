using Core.Entities.SecurityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constants
{
    public static class Messages
    {
        public const string AuthorizationDenied = "You are not authorized";
        public const string Success = "The process successfully completed.";
        public const string ThereIsNoSuchUser = "There is no such user";
        public const string TokenWasCreated = "Token was created.";
        public const string UserHasAlreadyExists = "This user has already exists.";
        public const string WrongPassword = "Password is wrong.";
    }
}
