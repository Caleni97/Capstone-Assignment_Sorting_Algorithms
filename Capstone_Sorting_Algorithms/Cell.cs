using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Sorting_Algorithms
{
    public class Cell
    {
        private Object Element;
        private Cell Link;

        public Cell(Object theElement, Cell theLink)
        {
            Element = theElement;
            Link = theLink;
        }

        public Cell(Object theElement)
        {
            Element = theElement;
            Link = null;
        }

        public Cell()
        {
            Element = null;
            Link = null;
        }

        public Cell next()
        {
            return Link;
        }

        public void setNext(Cell theLink)
        {
            Link = theLink;
        }

        public Object value()
        {
            return Element;
        }

        public void setValue(Object theElement)
        {
            Element = theElement;
        }
    }
}

