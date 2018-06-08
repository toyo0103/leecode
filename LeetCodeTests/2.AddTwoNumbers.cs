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
    [TestClass]
    public partial class SolutionTests
    {
        [TestMethod]
        public void AddTwoNumbersTest_輸入L1為342_L2為456_應得到807()
        {
            //arrange
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var sut = new Solution();

            var expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);
            //act
            var actual = sut.AddTwoNumbers(l1, l2);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void AddTwoNumbersTest_輸入L1為42_L2為708_應得到750()
        {
            //arrange
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);

            var l2 = new ListNode(8);
            l2.next = new ListNode(0);
            l2.next.next = new ListNode(7);

            var sut = new Solution();

            var expected = new ListNode(0);
            expected.next = new ListNode(5);
            expected.next.next = new ListNode(7);
            //act
            var actual = sut.AddTwoNumbers(l1, l2);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void AddTwoNumbersTest_輸入L1為1_L2為99_應得到100()
        {
            //arrange
            var l1 = new ListNode(1);

            var l2 = new ListNode(9);
            l2.next = new ListNode(9);

            var sut = new Solution();

            var expected = new ListNode(0);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(1);
            //act
            var actual = sut.AddTwoNumbers(l1, l2);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}



