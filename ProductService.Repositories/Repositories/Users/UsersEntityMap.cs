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
            Map(x => x.CityId).ToColumn("u_ciid");
            Map(x => x.StateId).ToColumn("u_stid");
            Map(x => x.CountryId).ToColumn("u_coid");
            Map(x => x.Zip).ToColumn("u_zip");
            Map(x => x.UserName).ToColumn("u_userName");
            Map(x => x.CreateDate).ToColumn("u_createDate");
            Map(x => x.UpdateDate).ToColumn("u_updateDate");
        }
    }
}
