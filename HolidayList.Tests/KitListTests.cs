using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HolidayList.Core;

namespace HolidayList.Tests
{
    [TestClass]
    public class KitListTests
    {
        [TestMethod]
        public void when_I_add_an_item_to_a_kitlist()
        {
            var kitList = new KitList();
            var item = new KitListItem("beachball", Who.Family, "fun stuff");

            kitList.Add(item);


            Assert.AreEqual(1, kitList.Items.Count());
            var actualItem = kitList.Items.Single();
            Assert.AreEqual("beachball", actualItem.Name);
            Assert.AreEqual(Who.Family, actualItem.Who);
            Assert.AreEqual("fun stuff", actualItem.Category);
        }
    }
}
