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
    [TestClass()]
    public class CodecTests
    {
        [TestMethod()]
        public void serializeTest()
        {
            //arrange
            var node = new TreeNode(1);
            var sut = new Codec();

            var expected = "1!#!#!";

            //act
            var actual = sut.serialize(node);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void serializeTest_傳入Null應回傳空字串()
        {
            //arrange
            var sut = new Codec();

            var expected = "#!";

            //act
            var actual = sut.serialize(null);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void serializeTest_有左邊子節點()
        {
            //arrange
            var node = new TreeNode(1);
            node.left = new TreeNode(2);

            var sut = new Codec();

            var expected = "1!2!#!#!#!";

            //act
            var actual = sut.serialize(node);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void serializeTest_有右邊子節點()
        {
            //arrange
            var node = new TreeNode(1);
            node.right = new TreeNode(2);

            var sut = new Codec();

            var expected = @"1!#!2!#!#!";

            //act
            var actual = sut.serialize(node);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void serializeTest_三層節點()
        {
            //arrange
            var node = new TreeNode(1);
            node.left = new TreeNode(2);
            node.right = new TreeNode(3);

            node.left.left = new TreeNode(4);
            node.right.right = new TreeNode(5);

            var sut = new Codec();

            var expected = "1!2!4!#!#!#!3!#!5!#!#!";

            //act
            var actual = sut.serialize(node);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void deserializeTest()
        {
            //arrange
            var nodeSerializeString = @"1!#!#!";
            var sut = new Codec();
            
            var expected = new TreeNode(1);
            //act
            var actual = sut.deserialize(nodeSerializeString);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void deserializeTest_Null_Node()
        {
            //arrange
            var nodeSerializeString = "#!";
            var sut = new Codec();

            //act
            var actual = sut.deserialize(nodeSerializeString);

            //assert
            actual.Should().BeNull();
        }

        [TestMethod()]
        public void deserializeTest_有左邊子節點()
        {
            //arrange
            var nodeSerializeString = @"1!4!#!#!#!";
            var sut = new Codec();

            var expected = new TreeNode(1);
            expected.left = new TreeNode(4);
            //act
            var actual = sut.deserialize(nodeSerializeString);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void deserializeTest_有右邊子節點()
        {
            //arrange
            var nodeSerializeString = @"1!#!2!#!#!";
            var sut = new Codec();

            var expected = new TreeNode(1);
            expected.right = new TreeNode(2);
            //act
            var actual = sut.deserialize(nodeSerializeString);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void deserializeTest_三層節點()
        {
            //arrange
            var nodeSerializeString = @"1!2!4!#!#!#!3!#!5!#!#!";
            var sut = new Codec();


            var expected = new TreeNode(1);
            expected.left = new TreeNode(2);
            expected.right = new TreeNode(3);

            expected.left.left = new TreeNode(4);
            expected.right.right = new TreeNode(5);

            //act
            var actual = sut.deserialize(nodeSerializeString);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}