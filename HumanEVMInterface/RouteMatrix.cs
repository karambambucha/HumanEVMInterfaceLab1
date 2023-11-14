using System;
using System.Collections.Generic;

namespace HumanEVMInterface
{
    public class RouteMatrix
    {
        private List<List<int>> routes;
        private List<double[]> times;
        public double totalTime = 0;
        public double mistakenTime = 0;
        Random random;

        public RouteMatrix(List<List<int>> routeMatrix, List<double[]> times, Random random)
        {
            routes = routeMatrix;
            this.times = times;
            this.random = random;
        }

        public List<int> GetThisRoute(int currentRoute, int currentNode, out double[] timeSpent)
        {
            if (currentRoute < 0 || currentRoute >= routes.Count)
                throw new ArgumentOutOfRangeException("currentRoute");

            List<int> nextRoute = routes[currentRoute];
            timeSpent = times[routes[currentRoute][currentNode] - 1];
            return nextRoute;
        }

        public int MakeTransition(int currentRoute, int currentNode, bool mistake)
        {
            List<int> thisRoute = GetThisRoute(currentRoute, currentNode, out double[] timeSpent);
            double currTime;
            if (timeSpent[1] == 0)
                currTime = timeSpent[0];
            else
                currTime = timeSpent[0] + random.NextDouble() * (timeSpent[1] - timeSpent[0]);
            totalTime += currTime;
            if (mistake)
                mistakenTime += currTime;
            if (currentNode + 1 < thisRoute.Count)
            {
                return currentNode + 1;
            }
            else
            {
                return currentNode;
            }
        }
    }
}
