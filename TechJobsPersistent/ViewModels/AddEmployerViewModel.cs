﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
        }

        public AddEmployerViewModel()
        {
        }
    }
}