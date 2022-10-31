using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DotNetTools.Labs
{
    internal class Lab3
    {
        public string inputPath;
        public string outputPath;
        public Lab3(string inputPath, string outputPath)
        {
            this.inputPath = inputPath;
            this.outputPath = outputPath;
        }
        public void Run()
        {
            char[,] arr = { { '#' } };
            int x = 0;
            int y = 0;
            int tY = 0;
            int tX = 0;
            try
            {
                string[] lines = System.IO.File.ReadAllLines
                    (inputPath);
                y = int.Parse(lines[0].Split(' ')[0]);
                x = int.Parse(lines[0].Split(' ')[1]);
                for (int i = 0; i < lines.Length; i++)
                {
                    tX = lines[i].IndexOf('T');
                    if (tX != -1)
                    {
                        tY = i - 1;
                        break;
                    }
                }
                if (y < 4 || x > 1000 || x < 0)
                    throw new Exception("Invalid input values");
                arr = new char[y, x];
                for (int i = 1; i < lines.Length; i++)
                {
                    char[] tempArr = lines[i].ToCharArray();
                    for (int j = 0; j < tempArr.Length; j++)
                    {
                        arr[i - 1, j] = tempArr[j];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            matrixNode tigerNode = AStar(arr, tY, tX, y - 2, x - 2, y, x);
            Stack<matrixNode> tigerPath = new Stack<matrixNode>();
            int tigerCount = 0;
            while (tigerNode.x != tY || tigerNode.y != tX)
            {
                tigerPath.Push(tigerNode);
                tigerNode = tigerNode.parent;
            }
            tigerCount = tigerPath.Count;
            Console.WriteLine($"The shortest path from {tY} {tX}  to {y - 2} {x - 2} is:");
            Console.WriteLine(tigerPath.Count);

            while (tigerPath.Count > 0)
            {
                matrixNode node = tigerPath.Pop();
                Console.WriteLine("(" + node.x + "," + node.y + ")");
            }
            //
            matrixNode endNode = AStar(arr, 1, 1, y - 2, x - 2, y, x);
            Stack<matrixNode> path = new Stack<matrixNode>();
            int count = 0;
            while (endNode.x != 1 || endNode.y != 1)
            {
                path.Push(endNode);
                endNode = endNode.parent;
            }
            count = path.Count;
            Console.WriteLine($"The shortest path from {1} {1}  to {y - 2} {x - 2} is:");
            Console.WriteLine(path.Count);

            while (path.Count > 0)
            {
                matrixNode node = path.Pop();
                Console.WriteLine("(" + node.x + "," + node.y + ")");
            }

            File.WriteAllText(outputPath, count.ToString() + "\n" + (tigerCount > count ? "Yes" : "No"));


            matrixNode AStar(char[,] matrix, int fromX, int fromY, int toX, int toY, int maxX, int maxY)
            {
                Dictionary<string, matrixNode> greens = new Dictionary<string, matrixNode>(); //open 
                Dictionary<string, matrixNode> reds = new Dictionary<string, matrixNode>(); //closed 

                matrixNode startNode = new matrixNode { x = fromX, y = fromY };
                string key = startNode.x.ToString() + startNode.x.ToString();
                greens.Add(key, startNode);

                Func<KeyValuePair<string, matrixNode>> smallestGreen = () =>
                {
                    KeyValuePair<string, matrixNode> smallest = greens.ElementAt(0);

                    foreach (KeyValuePair<string, matrixNode> item in greens)
                    {
                        if (item.Value.sum < smallest.Value.sum)
                            smallest = item;
                        else if (item.Value.sum == smallest.Value.sum
                                && item.Value.to < smallest.Value.to)
                            smallest = item;
                    }

                    return smallest;
                };
                List<KeyValuePair<int, int>> fourNeighbors = new List<KeyValuePair<int, int>>()
                                            { new KeyValuePair<int, int>(-1,0),
                                              new KeyValuePair<int, int>(0,1),
                                              new KeyValuePair<int, int>(1, 0),
                                              new KeyValuePair<int, int>(0,-1) };
                while (true)
                {
                    if (greens.Count == 0)
                        return null;

                    KeyValuePair<string, matrixNode> current = smallestGreen();
                    if (current.Value.x == toX && current.Value.y == toY)
                        return current.Value;

                    greens.Remove(current.Key);
                    reds.Add(current.Key, current.Value);

                    foreach (KeyValuePair<int, int> plusXY in fourNeighbors)
                    {
                        int nbrX = current.Value.x + plusXY.Key;
                        int nbrY = current.Value.y + plusXY.Value;
                        string nbrKey = nbrX.ToString() + nbrY.ToString();
                        if (nbrX < 0 || nbrY < 0 || nbrX >= maxX || nbrY >= maxY
                            || matrix[nbrX, nbrY] == '#'
                            || reds.ContainsKey(nbrKey))
                            continue;

                        if (greens.ContainsKey(nbrKey))
                        {
                            matrixNode curNbr = greens[nbrKey];
                            int from = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                            if (from < curNbr.fr)
                            {
                                curNbr.fr = from;
                                curNbr.sum = curNbr.fr + curNbr.to;
                                curNbr.parent = current.Value;
                            }
                        }
                        else
                        {
                            matrixNode curNbr = new matrixNode { x = nbrX, y = nbrY };
                            curNbr.fr = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                            curNbr.to = Math.Abs(nbrX - toX) + Math.Abs(nbrY - toY);
                            curNbr.sum = curNbr.fr + curNbr.to;
                            curNbr.parent = current.Value;
                            greens.Add(nbrKey, curNbr);
                        }
                    }
                }
            }
        }
    }
}
