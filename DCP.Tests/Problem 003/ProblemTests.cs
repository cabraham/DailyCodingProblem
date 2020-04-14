using DCP.Exercises.Problem_003;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCP.Tests.Problem_003
{
    /*
 * Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), 
 * which deserializes the string back into the tree.

For example, given the following Node class

class Node:
def __init__(self, val, left=None, right=None):
    self.val = val
    self.left = left
    self.right = right

    The following test should pass:

node = Node("root", Node("left", Node("left.left")), Node("right"))
assert deserialize(serialize(node)).left.left.val == "left.left"
 */

    [TestFixture]
    public class ProblemTests
    {
        private Problem sut;

        [SetUp]
        public void Given()
        {
            var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
            sut = new Problem(node);
        }

        [Test]
        public void ReturnsCorrectValueWhenDeserialized()
        {
            var serialized = sut.Serialize();
            var deserialized = sut.Deserialize(serialized);
            Assert.AreEqual("left.left", deserialized.Left.Left.Value);
        }


    }
}
