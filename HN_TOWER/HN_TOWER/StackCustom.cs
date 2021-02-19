using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN_TOWER
{
    public class Node<T>//generic
    {
        public T data;
        public Node<T> pNext;
    }
    public class TopStack<T>
    {
        public Node<T> pTop;
    }
    public class StackCustom<T>
    {
        private TopStack<T> topStack;

        public TopStack<T> Top
        {
            get
            {
                return topStack;
            }

            set
            {
                topStack = value;
            }
        }
        public StackCustom()
        {
            topStack = new TopStack<T>();
        }
        #region Method
        public void CreateStack()
        {
            topStack.pTop = null;
        }
        public void Push(T data)
        {
            Node<T> p = CreateNode(data);
            if (topStack.pTop == null)//neu stack chua co phan tu nao
            {
                topStack.pTop = p;
            }
            else
            {
                p.pNext = topStack.pTop;
                topStack.pTop = p;
            }
        }
        public T Pop()
        {
            T result;
            Node<T> node = topStack.pTop;
            result = topStack.pTop.data;
            topStack.pTop = topStack.pTop.pNext;
            node = null;
            return result;
        }
        public bool isEmpty()
        {
            if (topStack.pTop == null) return true;
            return false;
        }
        public Node<T> CreateNode(T data)
        {
            Node<T> p = new Node<T>();
            p.data = data;
            p.pNext = null;
            return p;
        }
        public void Clear()
        {
            topStack.pTop = null;
        }
        #endregion
    }
}
