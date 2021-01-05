using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(string name, int id, List<SelectListItem> Employers)
        {
            Name = name;
            Id = id;
            Employers = new List<SelectListItem>();
        }

        public AddJobViewModel()
        {
        }
    }
}