using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lektion8.Models.Entities;

namespace Lektion8Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_FullName_ShouldReturnFirstNameConcatenatedWithLastName()
        {
            // Arrange
            var FirstName = "First";
            var LastName = "Last";
            var FullName = string.Format("{0} {1}", FirstName, LastName);
            var user = new User() { ID = Guid.NewGuid(), FirstName = FirstName, LastName = LastName };

            // Act
            var result = user.FullName;

            // Assert
            Assert.AreEqual(FullName, result, "FullName incorrect!");
        }
    }
}
