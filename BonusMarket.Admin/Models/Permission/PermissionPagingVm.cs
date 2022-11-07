using Microsoft.AspNetCore.Mvc;

namespace BonusMarket.Admin.Models.Permission
{
    public class PermissionPagingVm
    {
        [FromQuery]
        public int PageSize { get; set; } = 10;
        [FromQuery]
        public int Page { get; set; } = 1;
    }
}