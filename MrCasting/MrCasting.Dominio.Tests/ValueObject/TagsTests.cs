using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.ValueObject;

namespace MrCasting.Domain.Tests.ValueObject
{
    /// <summary>
    /// Summary description for TagsTests
    /// </summary>
    [TestClass]
    public class TagsTests
    {
        public TagsTests()
        {
        }
        /*
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Tags_New_ExceptionIfNull()
        {
            Tags tags = new Tags(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Tags_Add_ExceptionIfAddNull()
        {
            Tags tags = new Tags();
            tags.Add(null);
        }

        [TestMethod]
        public void Tags_Add_CountEqualsOneIfAddOne()
        {
            Tags tags = new Tags();
            tags.Add("ONE");
            Assert.AreEqual(1, tags.List.Count);
        }

        [TestMethod]
        public void Tags_Add_CountEqualsTwoIfAddTwo()
        {
            Tags tags = new Tags();
            tags.Add("ONE");
            tags.Add("TWO");
            Assert.AreEqual(2, tags.List.Count);
        }

        [TestMethod]
        public void Tags_New_CountEqualsZeroIfAddRemoveOne()
        {
            Tags tags = new Tags("ONE");
            tags.Remove("ONE");
            Assert.AreEqual(0, tags.List.Count);
        }

        [TestMethod]
        public void Tags_Add_CountEqualsTwoIfAddTwoInOneString()
        {
            Tags tags = new Tags();
            tags.Add("ONE TWO");            
            Assert.AreEqual(2, tags.List.Count);
        }

        [TestMethod]
        public void Tags_New_CountEqualsTwoIfPassTwoTagsToConstructor()
        {
            Tags tags = new Tags("ONE TWO");
            Assert.AreEqual(2, tags.List.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Tags_New_ExceptionIfRemoveTagNotExistantTag()
        {
            Tags tags = new Tags("ONE");
            tags.Remove("NOT_EXISTANT_TAG");
        }*/

    }
}
