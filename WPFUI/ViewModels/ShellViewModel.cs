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


namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        private List<int> _number = Enumerable.Range(1, 36).ToList();
        
        public List<int> Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                NotifyOfPropertyChange(() => Number);
                
            }
        }

        public ShellViewModel()
        {

        }
        
      
    }
}
