using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Entities
{
    public class User: BaseEntity
    {        
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Email { get; set; }

        public int UserState { get; set; }

        public int RoleType { get; set; }

        public DateTime? AddTime { get; set; }
    }
}