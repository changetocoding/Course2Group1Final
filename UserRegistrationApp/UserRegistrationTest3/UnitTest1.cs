using UserRegistrationApp;

namespace UserRegistrationTest3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void CanRegisterNewUser()
        //{
        //    //Arrange
        //    var people = new People();

        //    //Act

        //    var result = people.AddAUser("Jesus", "isam@gmail.com");

        //    //Assert
        //    Assert.IsTrue(result);
        //}
        //[Test]
        //public void TestForViewingUserDetails()
        //{
        //    //Arrange
        //    var people = new People();

        //    //Act
        //    var result = people.ViewSpecificUserDetail("Michael");

        //    //Assert
        //    Assert.NotNull(result);
        //}
        //[Test]
        //public void TestForUpdatingUser()
        //{
        //   // Arrange
        //    var people = new People();

        //    //Act
        //    var result = people.UpdateUserDetails("Michael", "Isaac", "isamamiche@gmail.com");

        //    //Assert
        //    Assert.IsTrue(result);
        //}


        [Test]
        public void TestingIfAUserEmailExist()
        {
            //Arrange
            var people = new People();

            //Act
            var result = people.IfUserEmailExist("isama@gmail.com");

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void TestingIfAUserEmailDoesNotExist()
        {
            //Arrange
            var people = new People();

            //Act
            var result = people.IfUserEmailDoesNotExist("isamamichell@gmail.com");

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanCheckIfUsersAreAdded()
        {
            //Arrange
            var people = new People();

            //Act
            var result = people.CheckIfUsersAreAdded("isama@gmail.com");

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanCheckIfUsersAreDeleted()
        {
            //Arrange
            var people = new People();

            //Act
            var result = people.CheckIfUsersAreDeleted("isama@gmail.com");

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanCheckIfUsersAreUpdated()
        {
            //Arrange
            var people = new People();

            //Act
            var result = people.CheckIfUsersAreUpdated("isama@gmail.com");

            //Assert
            Assert.IsTrue(result);
        }
    }
}