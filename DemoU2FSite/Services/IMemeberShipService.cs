﻿using DemoU2FSite.Models;

namespace DemoU2FSite.Services
{
    public interface IMemeberShipService
    {
        /// <summary>
        /// Determines whether [is user registered] [the specified user name].
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool IsUserRegistered(string userName, string password);

        /// <summary>
        /// Generates the server challenge.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        ServerChallenge GenerateServerChallenge(string userName);

        bool HasChallengeForUser(string userName);
        
        bool AuthenticateUser(string userName, string deviceResponse);
        
        ServerRegisterResponse GenerateServerRegisteration(string userName, string password);
        
        void CompleteRegisteration(string userName, string deviceResponse);
    }
}