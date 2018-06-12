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
        [TestMethod()]
        public void GetMaxRepetitionsTest()
        {
            //arrange
            var s1 = "acb";
            var n1 = 4;
            var s2 = "ab";
            var n2 = 2;
            var sut = new Solution();

            var expected = 2;

            //act
            var actual = sut.GetMaxRepetitions(s1, n1, s2, n2);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void GetMaxRepetitionsTest_2()
        {
            //arrange
            var s1 = "ab";
            var n1 = 3;
            var s2 = "ab";
            var n2 = 4;
            var sut = new Solution();

            var expected = 0;

            //act
            var actual = sut.GetMaxRepetitions(s1, n1, s2, n2);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void GetMaxRepetitionsTest_3()
        {
            //arrange
            var s1 = "phqghumeaylnlfdxfircvscxggbwkfnqduxwfnfozvsrtkjprepggxrpnrvystmwcysyycqpevikef";
            var n1 = 1000000;
            var s2 = "fmznimkkasvwsrenzkycxfxtlsgypsfad";
            var n2 = 333;
            var sut = new Solution();

            var expected = 333;

            //act
            var actual = sut.GetMaxRepetitions(s1, n1, s2, n2);

            //assert
            actual.Should().Be(expected);
        }
    }
}

