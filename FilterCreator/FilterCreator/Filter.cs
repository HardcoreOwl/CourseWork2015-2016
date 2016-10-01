using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;
using System.Numerics;

namespace FilterCreator
{
    [Serializable]
    public class CustomFilter
    {
        public List<Filter> MyFilter { get; set; } 
        public string CustomFilterName{get;set;}
        public CustomFilter()
        {
            MyFilter = new List<Filter>();
            CustomFilterName = "NoName";
        }
        public CustomFilter(List<Filter> myFilter, string name)
        {
            MyFilter = myFilter;
            CustomFilterName = name;
        }
    }

    [Serializable]
    public class Filter
    {
        public Filter()
        {

        }

        public string Name{get;set;}
        public string Type
        {
            get;
            set;
        }
        
        public Filter(string name)
        {
            Name = name;
            Params = new List<double>();
        }
        public List<double> Params
        {
            get;
            set;
        }
        public double[,] CoM
        {
            get;
            set;
        }
        public bool Pass
        {
            get;
            set;
        }
        public int Style
        {
            get;
            set;
        }
        public int Range
        {
            get;
            set;
        }
        public int Power
        {
            get;
            set;
        }
    }

}
