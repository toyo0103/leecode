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
        public void FractionToDecimalTest_輸入numerator_1_denominator_2()
        {
            //arrange
            var sut = new Solution();
            var numerator = 1;
            var denominator = 2;

            var expected = "0.5";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_2_denominator_1()
        {
            //arrange
            var sut = new Solution();
            var numerator = 2;
            var denominator = 1;

            var expected = "2";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_2_denominator_3()
        {
            //arrange
            var sut = new Solution();
            var numerator = 2;
            var denominator = 3;

            var expected = "0.(6)";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_負2147483648_denominator_負1()
        {
            //arrange
            var sut = new Solution();
            var numerator = -2147483648;
            var denominator = -1;

            var expected = "2147483648";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_負50_denominator_8()
        {
            //arrange
            var sut = new Solution();
            var numerator = -50;
            var denominator = 8;

            var expected = "-6.25";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_0_denominator_負5()
        {
            //arrange
            var sut = new Solution();
            var numerator = 0;
            var denominator = -5;

            var expected = "0";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void FractionToDecimalTest_輸入numerator_7_denominator_負12()
        {
            //arrange
            var sut = new Solution();
            var numerator = 7;
            var denominator = -12;

            var expected = "-0.58(3)";
            //act
            var actual = sut.FractionToDecimal(numerator, denominator);

            //assert
            actual.Should().Be(expected);
        }
    }
}