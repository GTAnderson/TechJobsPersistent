using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string JobName { get; set; }
        public int EmployersId { get; set; }

        public List<SelectListItem> AllEmployers { get; set; }
        public List<Skill> Skills { get; set; }   // need skills for the job

        // is a job object necessary?

        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> allSkills)
        {
            Skills = allSkills;
            AllEmployers = new List<SelectListItem>();

            foreach (var employer in possibleEmployers)
            {
                AllEmployers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }

        public AddJobViewModel()
        {
        }
    }
}