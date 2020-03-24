using Dapper.FluentMap;
using Dapper.FluentMap.Mapping;
using System;

namespace ProductService.Repositories.Users
{
    public class UsersEntityMap : EntityMap<ProductService.Models.Users>
    {
        public UsersEntityMap()
        {
            Map(x => x.UserId).ToColumn("u_id");
            Map(x => x.FirstName).ToColumn("u_firstName");
            Map(x => x.MiddleName).ToColumn("u_middleName");
            Map(x => x.LastName).ToColumn("u_lastName");
            Map(x => x.Email).ToColumn("u_email");
            Map(x => x.PhoneNumber).ToColumn("u_phoneNumber");
            Map(x => x.Address1).ToColumn("u_address1");
            Map(x => x.Address2).ToColumn("u_address2");
            Map(x => x.City).ToColumn("ci_cityName");
            Map(x => x.State).ToColumn("st_stateName");
            Map(x => x.Country).ToColumn("co_countryName");
            Map(x => x.Zip).ToColumn("u_zip");
            Map(x => x.UserName).ToColumn("u_userName");
            Map(x => x.CreateDate).ToColumn("u_createDate");
            Map(x => x.UpdateDate).ToColumn("u_updateDate");
        }
    }
}
