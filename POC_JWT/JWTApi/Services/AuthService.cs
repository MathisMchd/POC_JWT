﻿using JWTApi.Services.Interfaces;

namespace JWTApi.Services
{
    /// <inheritdoc cref="IAuthService"/>
    public class AuthService : IAuthService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="userRepository">User repository</param>
        public AuthService(IUserRepository userRepository)
        {
        }


        /// <inheritdoc />
        public bool ValidateCredentials(string username, string password)
        {
            //TODO
            return true;
        }
    }
}
