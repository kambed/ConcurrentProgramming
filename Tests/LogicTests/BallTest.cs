using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.DataTests
{
    [TestClass]
    public class BallTest
    {
        private IBall _ball = IBall.CreateBall(1, 2, 1);

        [TestMethod]
        public void CreateBallTest()
        {
            Assert.AreEqual(1, _ball.XPosition);
            Assert.AreEqual(2, _ball.YPosition);
            Assert.AreEqual(0, _ball.XSpeed);
            Assert.AreEqual(0, _ball.YSpeed);
            Assert.AreEqual(1, _ball.Radius);
        }

        [TestMethod]
        public void SetBallCoordinatesTest()
        {
            _ball.XPosition = 2;
            _ball.YPosition = 3;
            Assert.AreEqual(2, _ball.XPosition);
            Assert.AreEqual(3, _ball.YPosition);
        }

        [TestMethod]
        public void SetBallSpeedTest()
        {
            _ball.XSpeed = 2;
            _ball.YSpeed = 3;
            Assert.AreEqual(2, _ball.XSpeed);
            Assert.AreEqual(3, _ball.YSpeed);
        }

        [TestMethod]
        public void SetRadiusTest()
        {
            _ball.Radius = 2;
            Assert.AreEqual(2, _ball.Radius);
        }
    }
}