using System;
using System.Collections.Generic;
using System.Text;

namespace prefix_trie
{
    class Node<T>
    {
        public char Symbol { get; set; }

        public T Data { get; set; }

        public bool IsWord { get; set; }

        public string Prefix { get; set; }

        public Dictionary<string, Node<T>> SubNodes { get; set; }

        


        public Node(T data) 
        {
            Data = data;
        }

        public Node(string key, T data) 
        {
            Data = data;
        }


        public override string ToString()
        {
            return Data.ToString();
        }

        public override bool Equals(object obj) 
        {
            if (obj is Node<T> item)
            {
                return Data.Equals(item);
            }
            else 
            {
                return false;
            }
        }
    }
}
