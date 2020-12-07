﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Dtos.User
{
    public class CreateOrUpdateUserDto : BaseEntityDto
    {
        [Required(ErrorMessage = "用户名必填")]
        [StringLength(100, ErrorMessage = "用户名长度不能超过100个字符")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码必填")]
        [Display(Name = "密码")]
        [StringLength(20, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "邮箱必填")]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "User Status Need")]
        public int UserState { get; set; }

        //[Required(ErrorMessage = "Role Type Need")]
        public int RoleType { get; set; }

        public DateTime? AddTime { get; set; }

        //[Required(ErrorMessage ="Gender Need")]
        public string Gender { get; set; }


        public string StudentNo { get; set; }

        public string Faulty { get; set; }

        public string Major { get; set; }

        public int CountryId { get; set; }

        public string ProfessorGuid { get; set; }

        //[Required(ErrorMessage = "Professor Id Need")]
        public int ProfessorId { get; set; }

        public string PhotoFileName { get; set; }

        public string NickName { get; set; }
    }
}
