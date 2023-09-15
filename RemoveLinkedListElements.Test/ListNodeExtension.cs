using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RemoveLinkedListElements.Test
{
    internal static class ListNodeExtension
    {
        internal static List<int> ToArray(this ListNode node)
        {
            List<int> res = new List<int>();

            _ToArray(node, res);

            res.Reverse();

            return res;
        }

        private static void _ToArray(ListNode node, List<int> list)
        {
            if (node.next != null)
                _ToArray(node.next, list);

            list.Add(node.val);
        }
    }
}
