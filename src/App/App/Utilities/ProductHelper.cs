using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Utilities
{
    public static class ProductHelper
    {
        public static IEnumerable<ProductModel> GetProducts()
        {
            return new List<ProductModel> {
                new ProductModel
                {
                    Id=1,
                    Name="ABC1",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=2,
                    Name="ABC2",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=3,
                    Name="ABC3",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=4,
                    Name="ABC4",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=5,
                    Name="ABC5",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=6,
                    Name="ABC6",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=7,
                    Name="ABC7",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                },
                new ProductModel
                {
                    Id=8,
                    Name="ABC8",
                    Src="~/images/Login_signup.jpg",
                    Desc="demo"
                }
            };
        }

        public static string GetUniqueKey(int length = 32)
        {
            string result = string.Empty;

            while (result.Length < length)
            {
                // Get the GUID.
                result += Guid.NewGuid().ToString().GetHashCode().ToString("x");
            }

            // Make sure length is valid.
            if (length <= 0 || length > result.Length)
                throw new ArgumentException("Length must be between 1 and " + result.Length);

            // Return the first length bytes.
            return result.Substring(0, length);
        }
    }
}