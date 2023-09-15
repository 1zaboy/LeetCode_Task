namespace RemoveLinkedListElements.Test
{
    public class UnitTest1
    {
        private ListNode _node = new ListNode();
        private int _val = 6;

        private List<int> values = new List<int>() { 6, 1, 2, 6, 3, 4, 5, 6 };
        private List<int> resultValues = new List<int>() { 1, 2, 3, 4, 5 };

        public UnitTest1()
        {
            values.Reverse();

            ListNode oldValue = null;
            foreach (int value in values)
                oldValue = new ListNode(value, oldValue);

            _node = oldValue;
        }

        [Fact]
        public void Test1()
        {
            SolutionTask solutionTask = new SolutionTask();

            var value = solutionTask.RemoveElements(_node, _val);

            Assert.Equal<int>(value.ToArray(), resultValues);
        }

        [Fact]
        public void Test2()
        {
            SolutionTask solutionTask = new SolutionTask();

            var value = solutionTask.RemoveElements2(_node, _val);

            Assert.Equal<int>(value.ToArray(), resultValues);
        }
    }
}