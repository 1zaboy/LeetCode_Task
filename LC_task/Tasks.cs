using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LC_task
{
    internal class Tasks
    {
        public IList<int> ProductExceptSelf(int[] nums)
        {
            HashSet<int> map = new HashSet<int>();
            List<int> res = new List<int>();

            foreach (int i in nums)
            {
                if (map.Contains(i))
                {
                    res.Add(i);
                }
                else
                {
                    map.Add(i);
                }
            }

            return res;
        }

        public bool Exist(char[][] board, string word)
        {
            TaskWordSearch taskWordSearch = new TaskWordSearch(board, word);
            return taskWordSearch.Exist();
        }
    }

    //https://leetcode.com/problems/word-search/
    //В попытках оптимазации был поломан
    internal class TaskWordSearch
    {
        private string _word;
        private char[][] _board;
        private ValueTuple<int, int> _boardSize;

        public TaskWordSearch(char[][] board, string word)
        {
            _board = board;
            _word = word;
            _boardSize = new ValueTuple<int, int>(_board.Length, _board[0].Length);
        }

        public bool Exist()
        {
            ValueTuple<int, int>? firstCharPorision = null;
            while (true)
            {
                firstCharPorision = GetFirstCharPosition(firstCharPorision);

                if (firstCharPorision == null) return false;

                if (_word.Length == 1) return firstCharPorision.HasValue;

                if (NextChar(1, new List<ValueTuple<int, int>>() { firstCharPorision.Value }))
                    return true;
            }
        }

        private ValueTuple<int, int>? GetFirstCharPosition(ValueTuple<int, int>? lastValue)
        {
            var s1 = 0;
            var s2 = 0;

            if (lastValue.HasValue)
            {
                s1 = lastValue.Value.Item1 + 1;
                s2 = lastValue.Value.Item2 + 1;
            }

            var count = 0;

            for (var i = s1; i < _board.Length; i++)
            {
                for (var ii = s2; ii < _board[i].Length; ii++)
                {
                    if (_word[0] == _board[i][ii])
                    {
                        if (count == 0 && lastValue == null)
                        {
                            return new ValueTuple<int, int>(i, ii);
                        }
                        else if (count > 0)
                        {
                            return new ValueTuple<int, int>(i, ii);
                        }
                        count++;
                    }
                }
            }

            return null;
        }

        private bool NextChar(int indexWord, IEnumerable<ValueTuple<int, int>> position)
        {
            var chars = GetСoming(_word[indexWord], position).ToList();
            if (chars.Count == 0) return false;

            if (_word.Length - 1 == indexWord)
            {
                return true;
            }
            else
            {
                foreach (var ch in chars)
                {
                    if (NextChar(indexWord + 1, new List<ValueTuple<int, int>>(position) { ch }))
                        return true;
                }
            }

            return false;
        }

        private IEnumerable<ValueTuple<int, int>> GetСoming(char ch, IEnumerable<ValueTuple<int, int>> position)
        {
            var allPair = GetCloseCells(position.Last());
            foreach (var pair in allPair.Where(x => !position.Contains(x)))
                if (_board[pair.Item1][pair.Item2] == ch) yield return pair;
        }

        private IEnumerable<ValueTuple<int, int>> GetCloseCells(ValueTuple<int, int> position)
        {
            var xMap = _board[0].Length;
            var yMap = _board.Length;

            if (position.Item1 >= 0 && position.Item1 < yMap)
            {
                var value = position.Item2 - 1;
                if (value >= 0)
                    yield return (position.Item1, value);

                value = position.Item2 + 1;
                if (value < xMap)
                    yield return (position.Item1, value);
            }

            if (position.Item2 >= 0 && position.Item2 < xMap)
            {
                var value = position.Item1 - 1;
                if (value >= 0)
                    yield return (value, position.Item2);


                value = position.Item1 + 1;
                if (value < yMap)
                    yield return (value, position.Item2);
            }
        }

    }
}
