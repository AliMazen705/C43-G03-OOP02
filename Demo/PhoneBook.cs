using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct PhoneBook
    {
        #region attributes
        //string[] names;
        //long[] numbers;
        //int size;
        #endregion

        #region properities
        //public int Size //read only property
        //{
        //    get { return size; }
        //}
        #endregion

        #region constructor
        //public PhoneBook(int _size)
        //{
        //    size = _size;
        //    names = new string[size];
        //    numbers = new long[size];
        //}
        #endregion
        #region method
        //public void AddPerson(int Position, string Name, long Number)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        if (Position >= 0 && Position < size)
        //        {
        //            names[Position] = Name;
        //            numbers[Position] = Number;
        //        }

        //    }
        //}
        #endregion
        #region Encapsulation
        #region Getter/setter
        //Getter
        //public long GetNumber (string Name)
        //{
        //    if(names!= null &&numbers!=null)
        //    {
        //        for (int i = 0; i < Name.Length; i++)
        //        {
        //            if (Name == names[i])

        //                return numbers[i];


        //        }
        //    }
        //    return -1;
        //}
        ////setter
        ////طالما مكتبتش استاتك فهي اوبجكت ولازم انده عليها
        //public void SetNumber(string Name,long NewNumber)
        //{
        //    if(names!=null&&numbers!=null)
        //    {
        //        for(int i=0;i<names.Length; i++)
        //        {
        //            if (Name == names[i])
        //            {
        //                numbers[i] = NewNumber;
        //            }
        //        }
        //    }
        //}

        //indexer
        // is special property
        //1-named alwayes with keyword this
        //2- can take parameters
        //public long this[string Name ]
        //{
        //    get
        //    {
        //        if (names != null && numbers != null)
        //        {
        //            for (int i = 0; i < Name.Length; i++)
        //            {
        //                if (Name == names[i])

        //                    return numbers[i];


        //            }
        //        }
        //        return -1;
        //    }
        //    set
        //    {
        //        if (names != null && numbers != null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (Name == names[i])
        //                {
        //                    numbers[i] = value;
        //                }
        //            }
        //        }
        //    }

        //}
        #endregion

        #endregion
    }
}
