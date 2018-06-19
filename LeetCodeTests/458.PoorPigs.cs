using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
namespace LeetCode.Tests
{
    public partial class SolutionTests
    {
        [TestMethod]
        public void PoorPigsTest_5桶水_1小時_毒發時間15分鐘_最少需要1隻豬來測試()
        {
            //arrange
            var sut = new Solution();
            var bukets = 5;
            var minutesToDie = 15;
            var minutesToTest = 60;

            var expected = 1;
            //act
            var actual = sut.PoorPigs(bukets, minutesToDie, minutesToTest);

            //assert
            actual.Should().Be(expected);

        }

        [TestMethod]
        public void PoorPigsTest_6桶水_1小時_毒發時間15分鐘_最少需要2隻豬來測試()
        {
            //arrange
            var sut = new Solution();
            var bukets = 6;
            var minutesToDie = 15;
            var minutesToTest = 60;

            var expected = 2;
            //act
            var actual = sut.PoorPigs(bukets, minutesToDie, minutesToTest);

            //assert
            actual.Should().Be(expected);

        }

        [TestMethod]
        public void PoorPigsTest_1桶水_1分鐘測試時間_毒發時間1分鐘_最少需要0隻豬來測試()
        {
            //arrange
            var sut = new Solution();
            var bukets = 1;
            var minutesToDie = 1;
            var minutesToTest = 1;

            var expected = 0;
            //act
            var actual = sut.PoorPigs(bukets, minutesToDie, minutesToTest);

            //assert
            actual.Should().Be(expected);

        }
    }
}