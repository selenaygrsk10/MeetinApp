using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MeetinApp.Models
{
    public class UserInfo 
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
        
        }
    }

