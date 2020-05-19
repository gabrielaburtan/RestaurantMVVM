using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Products
    {
        private string imageData;
        public string ImageData
        {
            get
            {
                return imageData;
            }
            set
            {
                imageData = value;
            }
        }

        private string labelData;
        public string LabelData
        {
            get
            {
                return labelData;
            }
            set
            {
                labelData = value;
            }
        }
    }
}
