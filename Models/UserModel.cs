using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace SalesPro.Models
{
    public class UserModel : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public string Fullname { get; set; }
        public UserAccess UserAccess { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }

        // Method to validate the password using SHA-256
        public bool ValidatePassword(string inputPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                string hashedInputPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return Password.Equals(hashedInputPassword);
            }
        }
    }
}
