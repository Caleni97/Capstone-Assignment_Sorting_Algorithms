using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Sorting_Algorithms
{
    public class SinglyLinkedList
    {
        // Sentinel cell
        private int counter;
        private Cell head;   // pointer to first cell in the list

        public SinglyLinkedList()
        {
            counter = 0;
            head = null;
        }

        public int Count()
        {
            return counter;
        }

        public Cell getFirst()
        {
            return head;
        }

        public void addFirst(Object newItem) // Section Adding Cells at the Beginning pp 59 - 60
        /* pre:  Have object to be added to calling singly linked list object, which may be empty.
         * post: newItem is the element of the FIRST cell of the singly linked list.  All other existing cells of the
         *       singly linked list retain their ordering AFTER the new first cell.
         *       The counter is modified to reflect the addition of a new cell to the singly linked list. */
        {

            // ADD CODE FOR addFirst HERE
            Cell newCell = new Cell(newItem);
            newCell.setNext(head);
            head = newCell;
            counter++;

        }

        public void addLast(Object newItem) // Section Adding Cells at the End pp 60 - 61
        /* pre:  Have object to be added to calling singly linked list object, which may be empty.
         * post: newItem is the element of the LAST cell of the singly linked list.  All other existing cells of the
         *       singly linked list retain their ordering BEFORE the new last cell.
         *       The counter is modified to reflect the addition of a new cell to the singly linked list. 
         * CAREFUL: C# has certain restrictions which do not allow direct implemention of the code as specified in the 
         *          prescribed text.  Find a way around the restriction. */
        {

            // ADD CODE FOR addLast HERE
            if (this.Count() == 0)
            {
                this.addFirst(newItem);
                return;
            }
            Cell newCell = new Cell(newItem);
            Cell cur = head;
            while (cur.next() != null)
                cur = cur.next();
            cur.setNext(newCell);
            counter++;
        }

        public Cell removeFirst()
        /* pre:  Have at least one cell in calling singly linked list object.
         * post: Return the cell removed, which is the first cell in the list.
         *       The counter is modified to reflect the removal of the first cell from the singly linked list. */
        {

            // ADD CODE FOR removeFirst HERE
            Cell cur = head;
            head = cur.next();
            cur.setNext(null);
            counter--;
            return cur;

        }

        public Cell removeLast()
        /* pre:  Have at least one cell in calling singly linked list object.
         * post: Return the cell removed, which is the last cell in the list.
         *       The counter is modified to reflect the removal of the last cell from the singly linked list. 
         * CAREFUL: C# has certain restrictions - find a way around the restriction. */
        {

            // ADD CODE FOR removeLast HERE
            Cell cur;
            if (this.Count() == 1)
            {
                cur = head;
                this.Clear();
                return cur;
            }
            cur = head;
            Cell prev = head;
            while (cur.next() != null)
            {
                prev = cur;
                cur = cur.next();
            }
            prev.setNext(null);
            counter--;
            return cur;
        }

        public void addBefore(Object newItem, Cell link)
        /* pre:  Have object to be added to calling singly linked list object, and a link in the singly linked list BEFORE
         *       which the newItem's cell must be added.
         * post: newItem is the element of the added cell of the singly linked list.  All other existing cells of the
         *       singly linked list retain their ordering relevant to the position of the newly added cell.
         *       The counter is modified to reflect the addition of a new cell to the singly linked list. */
        {

            // ADD CODE FOR addBefore HERE

            if (link == null)  // list either empty or must be added at end of list
            {
                this.addLast(newItem);
                return;
            }
            Cell newCell = new Cell(newItem);
            Cell cur = head;
            if (cur == link)  // must be added as first cell
            {
                this.addFirst(newItem);
                return;
            }
            while (cur.next() != link)
                cur = cur.next();
            cur.setNext(newCell);
            newCell.setNext(link);
            counter++;
        }

        public void addAfter(Object newItem, Cell link) // Section Inserting Cells After Other Cells pp 61 - 62
        /* pre:  Have object to be added to calling singly linked list object, and a link in the singly linked list AFTER
         *       which the newItem's cell must be added.
         * post: newItem is the element of the added cell of the singly linked list.  All other existing cells of the
         *       singly linked list retain their ordering relevant to the position of the newly added cell.
         *       The counter is modified to reflect the addition of a new cell to the singly linked list. */
        {

            // ADD CODE FOR addAfter HERE
            if (link == null)
            {
                this.addLast(newItem);
                return;
            }
            Cell newCell = new Cell(newItem);
            newCell.setNext(link.next());
            link.setNext(newCell);
            counter++;
        }

        public void Clear()
        /* pre:  Have calling singly linked list object, which could be empty.
         * post: EFFICIENTLY clear the singly linked list. */
        {
            // ADD CODE FOR Clear HERE
            counter = 0;
            head = null;
        }

        // OPTIONAL TASKS

        public Cell removeBefore(Cell link)
        /* pre:  Have at least one cell in calling singly linked list object. Have a link in the singly linked list.
         * post: Return the cell removed, which is the  cell BEFORE the given link.
         *       The counter is modified to reflect the removal of the cell from the singly linked list. */
        {
            // ADD CODE FOR removeBefore HERE

            if (link == head) // nothing to remove in front of link
                return null;
            if (link == null) // then remove last cell
                return removeLast();
            Cell cur = head;
            Cell prev = head;
            while (cur.next() != link)
            {
                prev = cur;
                cur = cur.next();
            }
            if (cur == head)
                return removeFirst();
            prev.setNext(link);
            cur.setNext(null);
            counter--;
            return cur;
        }

        public Cell removeAfter(Cell link) // Section Deleting Cells pp 62 - 63
        /* pre:  Have at least one cell in calling singly linked list object. Have a link in the singly linked list.
         * post: Return the cell removed, which is the  cell AFTER the given link.
         *       The counter is modified to reflect the removal of the cell from the singly linked list. */
        {
            // ADD CODE FOR removeAfter HERE
            if (link == null)   // nothing after
                return null;
            if (link.next() == null) // then nothing after link
                return null;
            if (link == head)
                return removeFirst();
            Cell cur = link.next();
            link.setNext(cur.next());
            cur.setNext(null);
            counter--;
            return cur;
        }
    }
}
