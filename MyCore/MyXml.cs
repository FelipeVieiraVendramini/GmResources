// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - MyXml.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;

#endregion

namespace MyCore
{
    public sealed class MyXml
    {
        private readonly XDocument m_xdRead;
        private readonly string m_szFile;

        public MyXml(string file)
        {
            m_szFile = file;
            m_xdRead = XDocument.Load(file);
        }

        #region Getters

        public int GetInt(params string[] where)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in where)
                sb.AppendFormat("/{0}", str);
            return int.TryParse(m_xdRead.XPathSelectElement(sb.ToString())?.Value, out int result) ? result : 0;
        }

        public string GetStr(params string[] where)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in where)
                sb.AppendFormat("/{0}", str);
            return m_xdRead.XPathSelectElement(sb.ToString())?.Value ?? string.Empty;
        }

        public MyXmlElement GetCollection(params string[] where)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in where)
                sb.AppendFormat("/{0}", str);
            return new MyXmlElement(m_xdRead.XPathSelectElements(sb.ToString()), m_xdRead);
        }

        #endregion

        #region Setters

        public void SetValue(int value, params string[] where)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in where)
                sb.AppendFormat("/{0}", str);
            try
            {
                m_xdRead.XPathSelectElement(sb.ToString()).Value = value.ToString();
            }
            finally
            {
                m_xdRead.Save(m_szFile);
            }
        }

        public void SetValue(string value, params string[] where)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in where)
                sb.AppendFormat("/{0}", str);
            try
            {
                m_xdRead.XPathSelectElement(sb.ToString()).Value = value;
            }
            finally
            {
                m_xdRead.Save(m_szFile);
            }
        }

        #endregion
    }

    public class MyXmlElement
    {
        private readonly XDocument m_xdRead;
        private readonly List<XElement> m_myElements;
        private int m_nCurrentIdx;

        public MyXmlElement(IEnumerable<XElement> elements, XDocument doc)
        {
            m_xdRead = doc;
            m_myElements = new List<XElement>(elements);
        }

        public int Count => m_myElements.Count;

        public XElement Current => m_myElements[Math.Max(0, Math.Min(m_myElements.Count - 1, m_nCurrentIdx))];

        public void First()
        {
            m_nCurrentIdx = 0;
        }

        public bool Next()
        {
            if (m_nCurrentIdx + 1 >= m_myElements.Count)
                return false;

            m_nCurrentIdx++;
            return true;
        }

        public bool Previous()
        {
            if (m_nCurrentIdx - 1 < 0)
                return false;

            m_nCurrentIdx--;
            return true;
        }

        public void Last()
        {
            m_nCurrentIdx = m_myElements.Count - 1;
        }

        #region Getters

        public int GetInt(string where)
        {
            return int.TryParse(Current.Element(where)?.Value, out int result) ? result : 0;
        }

        public string GetStr(string where)
        {
            return Current.Element(where)?.Value ?? string.Empty;
        }

        #endregion

        #region Setters

        public void SetValue(int value, string where)
        {
            try
            {
                Current.Element(where).Value = value.ToString();
            }
            finally
            {
                m_xdRead.Save(m_xdRead.BaseUri);
            }
        }

        public void SetValue(string value, string where)
        {
            try
            {
                Current.Element(where).Value = value;
            }
            finally
            {
                m_xdRead.Save(m_xdRead.BaseUri);
            }
        }

        #endregion
    }
}