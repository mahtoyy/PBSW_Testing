using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.UnitTests
{
    public class DateTimeProvider : IEnumerable<object[]>
    {
        static DateTime start = DateTime.Now.Date;
        static DateTime end = DateTime.Now.Date;


        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { start.AddDays(1),end.AddDays(3) }
        };

        public static IEnumerable<object[]> ReturnFalse()
        {
            var data = new List<object[]>
            {
                new object[] { start.AddDays(10),end.AddDays(20) },
                new object[] { start.AddDays(10),end.AddDays(29) },
                new object[] { start.AddDays(14),end.AddDays(19) }
            };

            return data;
        }

        public static IEnumerable<object[]> ReturnTrue()
        {
            var data = new List<object[]>
            {
                new object[] { start.AddDays(1),end.AddDays(3) },
                new object[] { start.AddDays(5),end.AddDays(8) },
                new object[] { start.AddDays(4),end.AddDays(6) }
            };

            return data;
        }

        public static IEnumerable<object[]> ThrowArgumentExpection()
        {
            var data = new List<object[]>
            {
                new object[] { start,start }
            };

            return data;
        }

        public static IEnumerable<object[]> IdNotInMinus()
        {
            var data = new List<object[]>
            {
                new object[] { start.AddDays(1),start.AddDays(1) }
            };

            return data;
        }

    }
}
