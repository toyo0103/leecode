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
        public void PermuteUniqueTest_輸入1_1()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int []{ 1, 1 };
            var expected = new List<List<int>>
            {
                new List<int>{ 1,1}
            };
            
            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void PermuteUniqueTest_輸入空Array()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int[0];
            var expected = new List<List<int>>();

            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void PermuteUniqueTest_輸入1_2()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int[] { 1, 2 };
            var expected = new List<List<int>>
            {
                new List<int>{ 1,2},
                new List<int>{ 2,1}
            };

            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void PermuteUniqueTest_輸入1_2_3()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int[] { 1, 2 , 3};
            var expected = new List<List<int>>
            {
                new List<int>{ 1,2,3},
                new List<int>{ 1,3,2},
                new List<int>{ 2,1,3},
                new List<int>{ 2,3,1},
                new List<int>{ 3,1,2},
                new List<int>{ 3,2,1},
            };

            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void PermuteUniqueTest_輸入1_1_2()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int[] { 1, 1, 2 };
            var expected = new List<List<int>>
            {
                new List<int>{ 1,1,2},
                new List<int>{ 1,2,1},
                new List<int>{ 2,1,1}
            };

            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void PermuteUniqueTest_輸入2_2_1_1()
        {
            //arrange
            var sut = new Solution();
            int[] input = new int[] { 2, 2, 1, 1 };
            var expected = new List<List<int>>
            {
                new List<int>{ 1,1,2,2},
                new List<int>{ 1,2,1,2},
                new List<int>{ 1,2,2,1},
                new List<int>{ 2,1,1,2},
                new List<int>{ 2,1,2,1},
                new List<int>{ 2,2,1,1}
            };

            //act
            var actual = sut.PermuteUnique(input);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}



