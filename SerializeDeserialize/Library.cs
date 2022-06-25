using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize
{
    [Serializable]
    class Library
    {
        public int _isbn { get; set; }

        public string _bookTitle { get; set; }

        public String _author { get; set; }

        public Library(int isbn, string bookTitle, string author)
        {
            this._isbn = isbn;

            this._bookTitle = bookTitle;

            this._author = author;
        }
    }
}
