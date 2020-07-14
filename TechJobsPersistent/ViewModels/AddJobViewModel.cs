using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        public string JobName { get; set; }
        [Required]
        public int EmployerID { get; set; }
       // [Required]
        public List<SelectListItem> AllEmployers { get; set; } 
        public List<int> SkillId { get; set; }
        public List<Skill> AllSkills { get; set; }
      


        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
          
            AllEmployers = new List<SelectListItem>();
            foreach (Employer emp in employers)
            {
                AllEmployers.Add(new SelectListItem
                {
                    Text = emp.Name,
                    Value = emp.Id.ToString()
                });
            }
            AllSkills = skills;
          
        }
        public AddJobViewModel()
        {

        }    
    }
  }
