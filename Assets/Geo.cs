using System.Collections.Generic;

namespace GeoService
{
    
    public static class Geo
    {
        private static int _Lon;
        private static int _Lat;
        private static List<(int, int )> Near = new();

        public static void GetPosition(double longitude, double latitude)
        {
            Near.Clear();
            double[] lonRange = { -180.0, 180.0 };
            double[] latRange = { -90.0, 90.0 };
            double mid;
            int xIndex = 0;
            int yIndex = 0;
            for (int i = 0; i < 12; i++)
            {
                mid = (lonRange[0] + lonRange[1]) / 2;
                if (longitude > mid)
                {
                    xIndex |= (1 << (12 - i));
                    lonRange[0] = mid;
                }
                else
                {
                    lonRange[1] = mid;
                }
            }

            for (int i = 0; i < 11; i++)
            {
                mid = (latRange[0] + latRange[1]) / 2;
                //反一下，y轴需要从90开始向下
                if (latitude < mid)
                {
                    yIndex |= (1 << (11 - i));
                    latRange[0] = mid;
                }
                else
                {
                    latRange[1] = mid;
                }
            }

            _Lon = xIndex;
            _Lat = yIndex;
            //获取邻域坐标对
            for (int i = xIndex - 1; i < xIndex + 1; i++)
            {
                for (int j = yIndex - 1; j < yIndex + 1; j++)
                {
                    Near.Add(((i + 4096) % 4096, j));
                }
            }

        }

        public static bool IsNear(int x, int y)
        {
            if (Near.Contains((x, y)))
            {
                return true;
            }

            return false;
        }

    }
}