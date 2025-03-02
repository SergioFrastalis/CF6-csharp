using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    internal class DLList<T>
    {
        public GenericNode<T>? Head { get; set; } = null;
        public GenericNode<T>? Tail { get; set; } = null;

        public void InsertFirst(T t)
        {
            GenericNode<T> tmp = new()
            {
                Value = t,
                Count = 1,
                Next = Head,
                Previous = null
            };

            Head = tmp;
            if (IsEmpty())
            {
                Tail = tmp;
            }

        }

        public void InsertLast(T t)
        {

            if(isEmpty())
            {
                InsertFirst(t);
                return;
            }
        }
    }
}
