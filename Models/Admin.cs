﻿using System.ComponentModel.DataAnnotations;

namespace GonjoyWebApp.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EMAIL { get; set; }

        public DateTime DOB { get; set; }
        public string AVA_PATH { get; set; }
        public int RANK { get; set; } = 0;
        [Required]
        public string USERNAME { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        public string PHONE_NUM { get; set; }
        public string ADDRESS { get; set; }
        public DateTime DATESTART { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
