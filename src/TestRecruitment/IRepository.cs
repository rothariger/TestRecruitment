namespace TestRecruitment.Repository
{
    public interface IRepository
    {
        Node GetNodeAndImmediateChildren(string nodeName);
    }
}
