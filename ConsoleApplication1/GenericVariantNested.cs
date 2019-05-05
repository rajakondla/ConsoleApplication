using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //public interface IBaseComparer<T, N>
    //{
    //    int CompareTo(T obj, N Comparer);
    //}

    class Country1 //:IBaseComparer<Country,>
    {   
        int m_CountryId = int.MinValue;
        string m_CountryName = string.Empty;
        int? m_CountryTradeCode = null;

        public Country1()
        {

        }

        public Country1(int CountryId)
        {
            m_CountryId = CountryId;
        }

        public Country1(int CountryId, string CountryName, int? CountryTradeCode) : this(CountryId)
        {
            m_CountryName = CountryName;
            m_CountryTradeCode = CountryTradeCode;
        }

        public int CountryId
        {
            get {return m_CountryId; }
            set { m_CountryId = value; }
        }

        public string CountryName
        {
            get { return m_CountryName; }
            set { m_CountryName = value; }
        }

        public int? CountryTradeCode
        {
            get { return m_CountryTradeCode;}
            set { m_CountryTradeCode = value; }
        }
    }
}
