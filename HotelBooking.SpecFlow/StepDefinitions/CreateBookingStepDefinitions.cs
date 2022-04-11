using HotelBooking.Core;
using Moq;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace HotelBooking.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CreateBookingStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        DateTime startdate, enddate,start,end;
        IBookingManager bookingManager;
        Mock<IRepository<Room>> fakeRoomRepository;
        Mock<IRepository<Booking>> fakeBookingRepository;
        bool result;

        public CreateBookingStepDefinitions()
        {
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

        [Given("the start date is (.*) days from now")]
        public void GivenTheStartDateIs(int days)
        {
            this.startdate = DateTime.Today.AddDays(days);
        }

        [Given("the end date is (.*) days from now")]
        public void GivenTheEndDateIs(int days)
        {
            this.enddate = DateTime.Today.AddDays(days);
        }

        [When("the two dates are submitted")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = bookingManager.CreateBooking(new Booking { StartDate=startdate, EndDate=enddate });
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            Assert.Equal(result,this.result);
        }
    }
}