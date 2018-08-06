using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DemoInterface
{    
    public interface ITestService
    {
        bool IsValid(string name, string password, int level);

        int Sum(List<int> list, Dictionary<string, int> dic);

        int GetDistance(Point pt1, Point pt2);
    }
}
