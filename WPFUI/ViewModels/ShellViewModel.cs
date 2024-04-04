using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private List<NumberItem> _number;

        public List<NumberItem> Number
        {
            get => _number;
            set
            {
                _number = value;
                NotifyOfPropertyChange(() => Number);
            }
        }

        public ShellViewModel()
        {
            _number = new List<NumberItem>();
            for (int i = 1; i <= 36; i++)
            {
                _number.Add(new NumberItem(i, i % 2 == 0 ? Brushes.Red : Brushes.Black)); // Initial colors (checkered pattern)
            }
        }
    }

    public class NumberItem
    {
        public int Value { get; set; }
        public Brush Color { get; set; }

        public NumberItem(int value, Brush color)
        {
            Value = value;
            Color = color;
        }
    }
}

