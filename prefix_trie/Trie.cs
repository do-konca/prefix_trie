using System;
using System.Collections.Generic;
using System.Text;

namespace prefix_trie
{
    class Trie<T>
    {
        private Node<T> root;
        public int Count { get; set; }

        public Trie(T data) 
        {
            root = new Node<T>("", data);
            Count = 1;
        }

        public void Add(string key, T data) 
        {
            var current = root;
            foreach (var symbol in key) 
            {
                if (current.Symbol == symbol) 
                {
                    current
                }
            }
        }

        public void Remove(string key) 
        {

        }
        public T Search(string key) 
        {

        }
    }
}
