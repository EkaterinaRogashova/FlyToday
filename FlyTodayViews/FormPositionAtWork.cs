﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormPositionAtWork : Form
    {
        private readonly ILogger _logger;
        private readonly IPositionAtWorkLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormPositionAtWork(ILogger<FormPositionAtWork> logger, IPositionAtWorkLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void FormPositionAtWork_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение должности");
                    var view = _logic.ReadElement(new PositionAtWorkSearchModel
                    {
                        Id = _id.Value
                    });
                    if (view != null)
                    {
                        if (view.NumberOfEmployeesInShift != 150) textBoxNumber.Text = view.NumberOfEmployeesInShift.ToString();
                        textBoxName.Text = view.Name;
                        comboBoxTypeWork.SelectedItem = view.TypeWork == "На рейсе" ? "На рейсе" : "Посменная";
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения должности");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните поле", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение должности");
            try
            {
                int number;

                if (string.IsNullOrEmpty(textBoxNumber.Text))
                {
                    number = 0;
                }
                else
                {
                    number = Convert.ToInt32(textBoxNumber.Text);
                }
                var selectedTypeWork = comboBoxTypeWork.SelectedText;
                if (selectedTypeWork == "Посменная") { textBoxNumber.Enabled = true; }
                else { textBoxNumber.Enabled = false; }
                var model = new PositionAtWorkBindingModel
                {
                    Id = _id ?? 0,
                    Name = textBoxName.Text,
                    NumberOfEmployeesInShift = number,
                    TypeWork = comboBoxTypeWork.SelectedItem.ToString()
                };
                var operationResult = _id.HasValue ? _logic.Update(model) :
               _logic.Create(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения должности");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void comboBoxTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTypeWork = comboBoxTypeWork.SelectedItem.ToString();
            if (selectedTypeWork == "Посменная")
            {
                textBoxNumber.Enabled = true;
            }
            else
            {
                textBoxNumber.Enabled = false;
            }
        }
    }
}
