using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebApp.Core.Services.Contracts.Models
{
    [Description("Account story info.")]
    public class AccountInfoModel
	{
        [Description("Account Id.")]
        public int Id { get; set; }

        [Description("Account unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("Account creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("Account last modification date.")]
        public DateTime DateModified { get; set; }

        [Description("Account username.")]
        public string Username { get; set; }

        [Description("Account password.")]
        public string Password { get; set; }

        [Description("Account confirm password.")]
        public string ConfirmPassword { get; set; }

        [Description("Account userID.")]
        public int UserID { get; set; }
    }
}
