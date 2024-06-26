﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Employee : IEmployeeModel
    {
        public int Id {  get; private set; }
        [Required]
        public string Surname { get; private set; } = string.Empty;
        [Required]
        public string Name { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;
        [Required]
        public bool MedAnalys { get; private set; }

        public DateTime DateMedAnalys { get; private set; }
        [Required]
        public DateTime DateOfBirth { get; private set; }
        [Required]
        public string Gender { get; private set; } = string.Empty;
        [Required]
        public int PositionAtWorkId { get; private set; }
        public PositionAtWork PositionAtWork { get; set; }

        public static Employee? Create(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Employee()
            {
                Id = model.Id,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                MedAnalys = model.MedAnalys,
                DateMedAnalys = model.DateMedAnalys,
                Gender = model.Gender,
                PositionAtWorkId = model.PositionAtWorkId
            };
        }
        public static Employee Create(EmployeeViewModel model)
        {
            return new Employee
            {
                Id = model.Id,
                Surname = model.Surname,
                Name = model.Name,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                MedAnalys = model.MedAnalys,
                DateMedAnalys = model.DateMedAnalys,
                Gender = model.Gender,
                PositionAtWorkId = model.PositionAtWorkId
            };
        }
        public void Update(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Surname = model.Surname;
            Name = model.Name;
            LastName = model.LastName;
            DateOfBirth = model.DateOfBirth;
            MedAnalys = model.MedAnalys;
            DateMedAnalys = model.DateMedAnalys;
            Gender = model.Gender;
            PositionAtWorkId = model.PositionAtWorkId;
        }
        public EmployeeViewModel GetViewModel => new()
        {
            Id = Id,
            Surname = Surname,
            Name = Name,
            LastName = LastName,
            DateOfBirth = DateOfBirth,
            MedAnalys = MedAnalys,
            DateMedAnalys = DateMedAnalys,
            Gender = Gender,
            PositionAtWorkId = PositionAtWorkId
        };
    }
}
