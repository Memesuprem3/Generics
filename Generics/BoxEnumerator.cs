using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class BoxEnumerator: IEnumerator<Box>
    {
        private BoxCollection _boxCollection;
        private int currentindex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection boxes)
        {
            _boxCollection = boxes;
            currentindex = -1;
            currentBox = default(Box);
        }

        public Box Current {  get { return currentBox; } }
        Object IEnumerator.Current {  get { return Current; } }

        public int Count
        {
            get { return _boxCollection.Count;}
        }

        

        public bool MoveNext()
        {
            if(++currentindex >= _boxCollection.Count)
            {
                return false;
            }
            else
            {
                currentBox = _boxCollection[currentindex];
            }
            return true;
        }

        void IEnumerator.Reset()
        {
            currentindex = -1;
        }

        public void Dispose()
        {

        }
    }
}
