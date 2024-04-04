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
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        //Main Section
        private List<NumberItem> _number;
        //Lower Section class import
       
        private List<TabelLowerSectionModel> _tabelLowerSectionsUpper;
        private List<TabelLowerSectionModel> _tabelLowerSectionsLower;
       
        //Right side of the table...
        public List<string> TwoToOneItems { get; set; }


        public List<TabelLowerSectionModel> TabelLowerSectionsUpper
        {
            get => _tabelLowerSectionsUpper;
            set
            {
                _tabelLowerSectionsUpper = value;
                NotifyOfPropertyChange(() => TabelLowerSectionsUpper);
            }
        }
        public List<TabelLowerSectionModel> TabelLowerSectionsLower
        {
            get => _tabelLowerSectionsLower;
            set
            {
                _tabelLowerSectionsLower = value;
                NotifyOfPropertyChange(() => TabelLowerSectionsLower);
            }
        }
        

        //Main Section
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
        {   //Main Section
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


            //Lower table
            TabelLowerSectionsUpper = new List<TabelLowerSectionModel>
            {
                new TabelLowerSectionModel("1st12", 4, "1st12", Brushes.Black, 200, 50),
                new TabelLowerSectionModel("2nd12", 4, "2nd12", Brushes.Black, 200, 50),
                new TabelLowerSectionModel("3rd12", 4, "3rd12", Brushes.Black, 200, 50),
            };
            TabelLowerSectionsLower = new List<TabelLowerSectionModel>
            {
                new TabelLowerSectionModel("1 to 18", 2, "1to18", Brushes.Black, 100, 50),
                new TabelLowerSectionModel("Even", 2, "Even", Brushes.Black, 100, 50),
                new TabelLowerSectionModel("", 2, "Black", Brushes.Black, 100, 50),
                new TabelLowerSectionModel("", 2, "Red", Brushes.Red, 100, 50),
                new TabelLowerSectionModel("Odd", 2, "Odd", Brushes.Black, 100, 50),
                new TabelLowerSectionModel("19 to 36", 2, "19to36", Brushes.Black, 100, 50),
            };
            
            //Right side of the table refactor when time
            TwoToOneItems = new List<string> { "2to1", "2to1", "2to1" };

        } 
    }




    public class NumberItem
    {
        //transfer to models later
        public int Value { get; set; }
        public Brush Color { get; set; }
        public string Text { get; set; }
   
        public NumberItem(int value, Brush color)
        {
            Value = value;
            Color = color;
        }
    }
}
