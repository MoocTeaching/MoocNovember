﻿using Mooc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.Models.Dtos.User
{
    public class UserDto : BaseEntityDto
    {

        [Display(Name = "用户名")]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int UserState { get; set; }

        public int RoleType { get; set; }

        public DateTime? AddTime { get; set; }

        public string Email111 { get; set; }

        public string Gender { get; set; }


        public string StudentNo { get; set; }

        public string Faulty { get; set; }

        public string Major { get; set; }

        public int CountryId { get; set; }

        public string ProfessorGuid { get; set; }

        public int ProfessorId { get; set; }

        public string PhotoFileName { get; set; }

        public string NickName { get; set; }

        public string GenderName => Enum.GetName(typeof(GenderEnum), Gender);

        [Display(Name = "角色")]
        public string RoleName => Enum.GetName(typeof(RoleTypeEnum), RoleType);
        [Display(Name = "状态")]
        public string StatusName => Enum.GetName(typeof(StatusEnum), UserState);
        [Display(Name = "创建时间")]
        public string DisplayDate => Convert.ToDateTime(AddTime).ToString("yyyy-MM-dd");

    }
}
