using System;
namespace cadastroClientesAPI.Model
{
    public class UserInfo
    {
        public string CompanyName { get; set; }
        public bool Imported { get; set; }
        public bool Empty { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string LoginName { get; set; }
        public string RoleName { get; set; }
        public long RoleId { get; set; }
        public long CompanyId { get; set; }
        public string TenantId { get; set; }
        public bool IsImported { get; set; }
        public long CustomerCode { get; set; }
        public string Token { get; set; }
        public string StoreAcronym { get; set; }
    }
}
