namespace _6thDay_ZadanieDomowe.Tests
{
    public class Tests
    {
        [Test]
        public void CheckUserLogin()
        {
            // arrange
            User user = new User("Halford", "hd763hy7");

            // act
            var result = user.Login;

            // assert
            Assert.AreEqual("Halford", result);
        }

        [Test]
        public void CheckUserPassword()
        {
            // arrange
            User user = new User("Luke", "hd763h");

            // act
            var result = user.Password;

            // assert
            Assert.AreEqual("hd763h", result);
        }
    }
}
}