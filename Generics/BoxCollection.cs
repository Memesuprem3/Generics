using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;
        public BoxCollection() 
        {
            innerCollection = new List<Box>();
        }

        public Box this[int index]
        {
            get { return innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        
        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("Box allready exists in the collection");
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;
            foreach(Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            } return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return innerCollection.GetEnumerator();
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for(int i =0; i < innerCollection.Count; i++)
            {
                Box currentBox = innerCollection[i];
                if(new BoxSameProp().Equals(currentBox, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        } 

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        

        public int Count
        {
            get
            {
                return innerCollection.Count;
            }
        }
    }
}
