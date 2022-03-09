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
                new object[] { start.AddDays(10),end.AddDays(20) }
            };

            return data;
        }

        public static IEnumerable<object[]> ReturnTrue()
        {
            var data = new List<object[]>
            {
                new object[] { start.AddDays(1),end.AddDays(3) }
            };

            return data;
        }

    }
}
