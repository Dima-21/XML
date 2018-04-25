﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _007_XMLWriteAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null);

            xmlWriter.WriteStartDocument();                  // Заголовок XML - <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      // Корневой элемент - <ListOfBooks>
            xmlWriter.WriteStartElement("Book");             // Книга 1 - <Book
            xmlWriter.WriteStartAttribute("FontSize");       // Атрибут - FontSize
            xmlWriter.WriteString("8");
            //  xmlWriter.WriteString("18");   // ="8"
            xmlWriter.WriteEndAttribute();                   // >
            xmlWriter.WriteString("Title-1");                // Title-1
            xmlWriter.WriteEndElement();                     // </Book>
            xmlWriter.WriteEndElement();                     // </ListOfBooks>

            xmlWriter.Close();

        }
    }
}
