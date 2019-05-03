using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;
using static System.Convert;

namespace SeekWayLib
{
    public static class WaySeeker
    {
        private static void Ways(List<Edge> edges, int numberEdge, List<int> list, List<List<int>> listWays)
        {
            foreach (var edge in edges)
            {
                if (!list.Contains(numberEdge))
                {
                    if (edge.u == numberEdge)
                    {
                        list.Add(numberEdge);
                        if (!list.Contains(edge.v)) Ways(edges, edge.v, list, listWays);
                        else if (!listWays.Contains(list)) listWays.Add(list.ToList());
                        list.Remove(numberEdge);
                    }
                    else if (edge.v == numberEdge)
                    {
                        list.Add(numberEdge);
                        if (!list.Contains(edge.u)) Ways(edges, edge.u, list, listWays);
                        else if (!listWays.Contains(list)) listWays.Add(list.ToList());
                        list.Remove(numberEdge);
                    }
                }
            }
        }

        public static int Main(string[] Rows)
        {
            var startPoints = new List<int>
            {
                ToInt32(Rows[0].Split(' ')[0]),
                ToInt32(Rows[0].Split(' ')[2]),
                ToInt32(Rows[1].Split(' ')[1]),
                ToInt32(Rows[2].Split(' ')[0]),
                ToInt32(Rows[2].Split(' ')[2])
            };
            var startIndex = (startPoints.IndexOf(startPoints.Max()) + 1) * 2 - 1;


            var Digits = new List<int>
            {
                ToInt32(Rows[0].Split(' ')[0]),
                ToInt32(Rows[0].Split(' ')[1]),
                ToInt32(Rows[0].Split(' ')[2]),
                ToInt32(Rows[1].Split(' ')[0]),
                ToInt32(Rows[1].Split(' ')[1]),
                ToInt32(Rows[1].Split(' ')[2]),
                ToInt32(Rows[2].Split(' ')[0]),
                ToInt32(Rows[2].Split(' ')[1]),
                ToInt32(Rows[2].Split(' ')[2])
            };
            var listWays = new List<List<int>>();
            var edges = new List<Edge>
            {
                new Edge(1, 2),new Edge(1, 4),
                new Edge(2, 3),new Edge(2, 5),
                new Edge(3, 6),
                new Edge(4, 5),new Edge(4, 7),
                new Edge(5, 6),new Edge(5, 8),
                new Edge(6, 9),
                new Edge(7, 8),
                new Edge(8, 9)
            };
            Ways(edges, startIndex, new List<int>(), listWays);

            var listOfAnswer = new List<int>();
            foreach (var list in listWays)
            {
                var sum = 0;
                if (list.Count == 9)
                {
                    sum = list.Aggregate(sum, (current, t) => current * 10 + Digits[t - 1]);
                    listOfAnswer.Add(sum);
                }
            }
            return listOfAnswer.Max();
        }
    }
}