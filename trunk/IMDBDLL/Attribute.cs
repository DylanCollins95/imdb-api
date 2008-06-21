﻿using System;

namespace IMDBDLL
{
    /// <summary>
    /// http://www.developer.com/net/csharp/article.php/10918_2230091_2
    /// </summary>
    public class Attribute : ICloneable
    {
        /// <summary>
        /// The name of this attribute
        /// </summary>
        private string m_name;

        /// <summary>
        /// The value of this attribute
        /// </summary>
        private string m_value;

        /// <summary>
        /// The delimiter for the value of this attribute(i.e. " or ').
        /// </summary>
        private char m_delim;

        /// <summary>
        /// Construct a new Attribute.  The name, delim, and value
        /// properties can be specified here.
        /// </summary>
        /// <param name="name">The name of this attribute.</param>
        /// <param name="value">The value of this attribute.</param>
        /// <param name="delim">The delimiter character for the value.
        /// </param>
        public Attribute(string name, string value, char delim)
        {
            m_name = name;
            m_value = value;
            m_delim = delim;
        }


        /// <summary>
        /// The default constructor.  Construct a blank attribute.
        /// </summary>
        public Attribute()
            : this("", "", (char)0)
        {
        }

        /// <summary>
        /// Construct an attribute without a delimiter.
        /// </summary>
        /// <param name="name">The name of this attribute.</param>
        /// <param name="value">The value of this attribute.</param>
        public Attribute(String name, String value)
            : this(name, value,
                 (char)0)
        {
        }

        /// <summary>
        /// The delimiter for this attribute.
        /// </summary>
        public char Delim
        {
            get
            {
                return m_delim;
            }

            set
            {
                m_delim = value;
            }
        }

        /// <summary>
        /// The name for this attribute.
        /// </summary>
        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        /// <summary>
        /// The value for this attribute.
        /// </summary>
        public string Value
        {
            get
            {
                return m_value;
            }

            set
            {
                m_value = value;
            }
        }

        #region ICloneable Members
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return new Attribute(m_name, m_value, m_delim);
        }
        #endregion
    }
}