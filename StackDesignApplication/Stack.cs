using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StackDesignApplication
{
    public class Stack
    {
        private readonly List<Object> _objects;

        public Stack()
        {
            _objects = new List<object>();
        }

        public void Push(Object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("object can not pushed to the Stack cause it's null object");
            }

            this._objects.Add(obj);
        }

        public Object Pop()
        {
            if (_objects.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty, so no object can be popped from the Stack");
            }

            int index = _objects.Count - 1;
            object toReturn = _objects[index];
            this._objects.RemoveAt(index);
            return toReturn;
        }

        public void Clear()
        {
            this._objects.Clear();
        }

        private int Find(Object item)
        {
            return this._objects.IndexOf(item);
        }

        public void Print()
        {
            foreach (Object obj in _objects)
            {
                Console.Write(obj + " ");
            }
        }
    }
}