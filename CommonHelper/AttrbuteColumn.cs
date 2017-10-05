using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class AttrbuteColumn : Attribute
    {

        public AttrbuteColumn(string columntext, bool isvisbale = true)
        {
            columnText = columntext;
            isVisbale = isvisbale;
        }
        private string columnText;

        public string ColumnText
        {
            get
            {
                return columnText;
            }

            set
            {
                columnText = value;
            }
        }

        public bool IsVisbale
        {
            get
            {
                return isVisbale;
            }

            set
            {
                isVisbale = value;
            }
        }

        private bool isVisbale = true;
    }
}
