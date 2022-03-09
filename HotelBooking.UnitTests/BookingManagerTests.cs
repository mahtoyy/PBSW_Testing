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

        public BookingManagerTests(){
            DateTime start = DateTime.Now.Date.AddDays(10);
            DateTime end = DateTime.Now.Date.AddDays(20);

            var rooms = new List<Room>
            {
                new Room { Id=1, Description="A" },
                new Room { Id=2, Description="B" },
            };

            var bookings = new List<Booking>
            {
                new Booking { Id=1, StartDate=start, EndDate=start, IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id=2, StartDate=start, EndDate=start, IsActive=true, CustomerId=2, RoomId=2 },
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

        [Fact]
        public void FindAvailableRoom_StartDateNotInTheFuture_ThrowsArgumentException()
        {
            // Arrange
            DateTime date = DateTime.Today;

            // Act
            Action act = () => bookingManager.FindAvailableRoom(date, date);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void FindAvailableRoom_RoomAvailable_RoomIdNotMinusOne()
        {
            // Arrange
            DateTime date = DateTime.Today.AddDays(1);
            // Act
            int roomId = bookingManager.FindAvailableRoom(date, date);
            // Assert
            Assert.NotEqual(-1, roomId);
        }

    }
}
