using CanVisitAllRooms;
using System.Collections.Generic;
using Xunit;

namespace CanVisitAllRoomsTests
{
    public class AllRoomsTests
    {
        [Fact]
        public void CanVisitAllRooms()
        {
            var rooms = new List<IList<int>>()
            {
                new List<int>{1},
                new List<int>{2},
                new List<int>{3},
                new List<int>()
            };

            var canVisitAllRooms = AllRooms.CanVisitAllRooms(rooms);
            Assert.True(canVisitAllRooms);
        }

        [Fact]
        public void CantVisitAllRooms()
        {
            //[[1,3],[3,0,1],[2],[0]]
            var rooms = new List<IList<int>>()
            {
                new List<int>{1,3},
                new List<int>{3,0,1},
                new List<int>{2},
                new List<int>{0}
            };

            var canVisitAllRooms = AllRooms.CanVisitAllRooms(rooms);
            Assert.False(canVisitAllRooms);
        }
    }
}
