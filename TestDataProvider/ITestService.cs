using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DemoInterface;

namespace DemoService
{
    public class TestService : MarshalByRefObject, ITestService
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

        public bool IsValid(string name, string password, int level)
        {
            return level == 0;
        }

        public int Sum(List<int> list, Dictionary<string, int> dic)
        {
            if (list == null)
            {
                return 0;
            }

            int res = 0;
            foreach (int val in list)
            {
                res += val;
            }

            return res;
        }

        public int GetDistance(Point pt1, Point pt2)
        {
            return (pt1.X - pt2.X) * (pt1.X - pt2.X) + (pt1.Y - pt2.Y) * (pt1.Y - pt2.Y);
        }
    }

}
