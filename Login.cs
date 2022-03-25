using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebServicesAssignment4
{
    public class Login
    {
        List<User> users;
        
        public Login()
        {
            users = new List<User>();
            User admin = new User();
            admin.Username = "admin";
            admin.Password = "passWord";
            admin.role = User.Role.admin;
            users.Add(admin);

            User user = new User();
            user.Username = "user";
            user.Password = "pass";
            user.role = User.Role.user;
            users.Add(user);
        }

        public string login(string username, string password)
        {
            foreach(var user in users)
            {
                if (user.Username == username)
                {
                    if(user.Password == password)
                    {
                        return GenerateToken(username, user.role);
                    }
                    return "";
                }
            }
            return "";

        }

        private string GenerateToken(string username, User.Role role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("webservicesassignmentrandom12345");
            var subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role.ToString())
            });

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = subject,
                IssuedAt = DateTime.Now,
                Expires = DateTime.Now.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
