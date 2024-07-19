using System.Collections.Generic;
using BankStatement.Roles.Dto;

namespace BankStatement.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}