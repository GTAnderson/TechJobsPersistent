using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public AddEmployerViewModel(string Name, string Location)
        {
        }

        public AddEmployerViewModel()
        {
        }
    }
}