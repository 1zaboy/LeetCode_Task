namespace PathSum
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SolutionTask
    {
        // Runtime 88 ms Beats 90.4%
        // Memory 42.6 MB Beats 14.20%
        public bool HasPathSum(TreeNode root, int targetSum, int sum = 0)
        {
            if (root == null) return false;

            sum += root.val;

            if (sum == targetSum && root.left == null && root.right == null)
            {
                return true;
            }

            if (root.left != null)
            {
                if (HasPathSum(root.left, targetSum, sum)) return true;
            }
            if (root.right != null)
            {
                if (HasPathSum(root.right, targetSum, sum)) return true;
            }

            return false;

        }
    }
}