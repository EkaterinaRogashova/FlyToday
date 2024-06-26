﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class PositionAtWork: IPositionAtWork
    {
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; } = string.Empty;
        public int? NumberOfEmployeesInShift { get; private set; }
        [Required]
        public string TypeWork { get; private set; } = string.Empty;


        public static PositionAtWork? Create(PositionAtWorkBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new PositionAtWork()
            {
                Id = model.Id,
                Name = model.Name,
                NumberOfEmployeesInShift = model.NumberOfEmployeesInShift,
                TypeWork = model.TypeWork
            };
        }
        public static PositionAtWork Create(PositionAtWorkViewModel model)
        {
            return new PositionAtWork
            {
                Id = model.Id,
                Name = model.Name,
                NumberOfEmployeesInShift = model.NumberOfEmployeesInShift,
                TypeWork = model.TypeWork
            };
        }
        public void Update(PositionAtWorkBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Name = model.Name;
            NumberOfEmployeesInShift = model.NumberOfEmployeesInShift;
            TypeWork = model.TypeWork;
        }
        public PositionAtWorkViewModel GetViewModel => new()
        {
            Id = Id,
            Name = Name,
            NumberOfEmployeesInShift = NumberOfEmployeesInShift,
            TypeWork = TypeWork
        };
    }
}
