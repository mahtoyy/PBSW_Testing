using System;
using System.Collections.Generic;
using HotelBooking.Core;
using HotelBooking.UnitTests.Fakes;
using Moq;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class BookingManagerTests
    {
        private IBookingManager bookingManager;
        private Mock<IRepository<Room>> fakeRoomRepository;
        private Mock<IRepository<Booking>> fakeBookingRepository;
        private DateTime start;
        private DateTime end;

        public BookingManagerTests(){
            start = DateTime.Now.Date.AddDays(10);
            end = DateTime.Now.Date.AddDays(20);

            var rooms = new List<Room>
            {
                new Room { Id=1, Description="A" },
                new Room { Id=2, Description="B" }
            };

            var bookings = new List<Booking>
            {
                new Booking { Id=1, StartDate=start, EndDate=end, IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id=2, StartDate=start, EndDate=end, IsActive=true, CustomerId=2, RoomId=2 }
            };

            fakeRoomRepository = new Mock<IRepository<Room>>();
            fakeBookingRepository = new Mock<IRepository<Booking>>();


            fakeRoomRepository.Setup(x => x.GetAll()).Returns(rooms);
            fakeRoomRepository.Setup(x => x.Get(2)).Returns(rooms[1]);

            fakeBookingRepository.Setup(x => x.Get(1)).Returns(bookings[0]);
            fakeBookingRepository.Setup(x => x.GetAll()).Returns(bookings);

            bookingManager = new BookingManager(fakeBookingRepository.Object, fakeRoomRepository.Object);
        }

        [Theory]
        [MemberData(nameof(DateTimeProvider.ReturnTrue), MemberType = typeof(DateTimeProvider))]
        public void CreateBooking_UnoccupiedPeriod_ReturnTrue(DateTime StartDate, DateTime EndDate)
        {
            var result = bookingManager.CreateBooking(new Booking { StartDate=StartDate, EndDate=EndDate });
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(DateTimeProvider.ReturnFalse), MemberType = typeof(DateTimeProvider))]
        public void CreateBooking_OccupiedPeriod_ReturnFalse(DateTime StartDate, DateTime EndDate)
        {
            var result = bookingManager.CreateBooking(new Booking { StartDate = StartDate, EndDate = EndDate });
            Assert.False(result);
        }

        [Theory]
        [MemberData(nameof(DateTimeProvider.ThrowArgumentExpection), MemberType =typeof(DateTimeProvider))]
        public void FindAvailableRoom_StartDateNotInTheFuture_ThrowsArgumentExceptionm(DateTime start, DateTime end)
        {
            Action act = () => bookingManager.FindAvailableRoom(start, end);
            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [MemberData(nameof(DateTimeProvider.IdNotInMinus), MemberType = typeof(DateTimeProvider))]
        public void FindAvailableRoom_RoomAvailable_RoomIdNotMinusOne(DateTime start, DateTime end)
        {
            int act = bookingManager.FindAvailableRoom(start, end);
            Assert.NotEqual(-1, act);
        }

        [Fact]
        public void FindAvailableRoom_RoomAvailable_GetAllIsCalled()
        {
            bookingManager.FindAvailableRoom(start, end);

            fakeBookingRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Fact]
        public void GetFullyOccupiedDates_OccupiedRoomsForPeriod_ReturnList()
        {
            var list = bookingManager.GetFullyOccupiedDates(start,end);
            Assert.NotEmpty(list);

        }

    }
}
