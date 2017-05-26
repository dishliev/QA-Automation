using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Models
{
    public class SearchBySizeTyre
    {
        private string key;
        private string width;
        private string diameter;
        private string ratio;
        private string brand;

       

        public SearchBySizeTyre(string key,
                                    string width,
                                    string diameter,
                                    string ratio,
                                    string brand
                                   
                              )
        {
            this.key = key;
            this.width = width;
            this.diameter = diameter;
            this.ratio = ratio;
            this.brand = brand;
           
        }

        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public string Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public string Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public string Ratio
        {
            get { return this.ratio; }
            set { this.ratio = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

      
    }
}