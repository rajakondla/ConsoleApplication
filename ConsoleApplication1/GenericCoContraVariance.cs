using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace ConsoleApplication1
{
    public interface IBaseComparer<T, N>
    {
        int CompareTo(T obj, N Comparer);
    }


    class Country : IBaseComparer<Country,Utilities.ComparisionType>
    {
        public int? countryTradeCode = null;
        public string countryName = "";
        public int countryId = int.MinValue;
        
        public Country()
        {

        }

        public Country(int countryId)
        {

        }

        public Country(int countryId, string countryName, int? countryTradeCode):this(countryId)
        {
            this.countryName = countryName;
            this.countryTradeCode = countryTradeCode;
        }

        public int CountryID
        {
            get { return countryId; }
            set { countryId = value; }
        }
        public int? CountryTradeCode
        {
            get { return countryTradeCode; }
            set { countryTradeCode = value; }
        }
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public int CompareTo(Country rhs, Utilities.ComparisionType whichCompare)
        {
            switch (whichCompare)
            {
                case Utilities.ComparisionType.CountryID:
                    return this.countryId.CompareTo(rhs.countryId);
                case Utilities.ComparisionType.CountryName:
                    return this.countryName.CompareTo(rhs.countryName);
                case Utilities.ComparisionType.CountryTradeCode:
                    return this.countryTradeCode.GetValueOrDefault().CompareTo(this.countryTradeCode.GetValueOrDefault());
            }
            return 0;
        }

      
    }


    public class BaseComparer<T,N> : IComparer<T> where T:IBaseComparer<T,N>
    {
        private Utilities.SortOrder _sortDirection;
        private N _whichComparison;  
        public Utilities.SortOrder SortDirection
        {
            get { return _sortDirection; }
            set { _sortDirection = value; }
        }

        public N WhichComparer
        {
            get
            {
                return _whichComparison;
            }
            set
            {
                _whichComparison = value;
            }
        }

        public int Compare(T lhs, T rhs)
        {
            if (_sortDirection == Utilities.SortOrder.Asc)
                return lhs.CompareTo(rhs, _whichComparison);
            else
                return lhs.CompareTo(rhs, _whichComparison);
        }
    }




    class ProgramGeneric
    {
        IList<Country> listCountry = null;

        public IList<Country> GetCountryList
        {
            get { return listCountry; }
            set { listCountry = value; }
        }

        static void Main()
        {
            IList<Country> listCountries = new ProgramGeneric().GetCounties();


        }

        public IList<Country> GetCounties()
        {
            GetCountryList = new List<Country>() { 
                                                    new Country(1,"India",1001),
                                                    new Country(2,"Sri Lanka",1002),
                                                    new Country(3,"Pakistan",1003),
                                                    new Country(4,"Bangladesh",1004)
                                                 };
            return GetCountryList;
        }
    }
}
