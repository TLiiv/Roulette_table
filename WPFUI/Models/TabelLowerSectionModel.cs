using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Windows.Media.Media3D;

namespace WPFUI.Models
{
    public class TabelLowerSectionModel
    {
        public string Text { get; set; }
        public int ColumnSpan { get; set; }
        public string Name { get; set; }
        public Brush Color { get; set; }
        public double Width { get; set; } 
        public double Height { get; set; } 

        public TabelLowerSectionModel(string text, int columnSpan, string name, Brush color,double width, double height)
        {
            Text = text;
            ColumnSpan = columnSpan;
            Name = name;
            Color = color;
            Width = width;
            Height = height;
        }
    }

}
