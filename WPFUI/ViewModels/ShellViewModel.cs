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

            // Add numbers in the desired pattern
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 12; col++)
                {
                    // Calculate the value based on the column and row
                    int value = (2 - row) + (3 * col) + 1;
                    if (value <= 36)
                    {
                        Brush color;
                        if (value <= 10 || (value >= 19 && value <= 28))
                        {
                            // 1-10 and 19-28: odd numbers red, even black
                            color = value % 2 == 1 ? Brushes.Red : Brushes.Black;
                        }
                        else
                        {
                            //  11-18 and 29-36: odd numbers black, even red
                            color = value % 2 == 1 ? Brushes.Black : Brushes.Red;
                        }

                        _number.Add(new NumberItem(value, color));
                    }

                }
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
