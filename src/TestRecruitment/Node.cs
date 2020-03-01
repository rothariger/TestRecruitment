using System.Collections.Generic;

namespace TestRecruitment.Repository
{
    public class Node
    {
        public string Name { get; set; }

        public IEnumerable<Node> ImmediateChildren { get; set; }
    }
}
