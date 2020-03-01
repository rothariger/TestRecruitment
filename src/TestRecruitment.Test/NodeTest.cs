using System.Linq;

using TestRecruitment.Repository;

using NUnit.Framework;

namespace TestRecruitment.Test.Repository
{
    [TestFixture]
    public class NodeTest
    {
        [Test]
        public void LoadingNodeB_ShouldAlwaysReturnTheSameInstance()
        {
            var nodeManager = new NodeManager(new FakeRepository());

            var nodeA = nodeManager.GetNodeAndImmediateChildren("Node A");
            var nodeB = nodeManager.GetNodeAndImmediateChildren("Node B");
            
            var nodeBFromNodeA = nodeA.ImmediateChildren.First(child => child.Name == "Node B");

            Assert.AreEqual(nodeB.Name, nodeBFromNodeA.Name);
            Assert.AreEqual(nodeB, nodeBFromNodeA);
        }
    }
}
