namespace ProductService.Models
{
    using System;
    public sealed class Users
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int CityId { get; set; }

        public int? StateId { get; set; }

        public int CountryId { get; set; }

        public string Zip { get; set; }

        public string UserName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
