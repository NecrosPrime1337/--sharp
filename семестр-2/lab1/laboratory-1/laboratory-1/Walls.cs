using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_1
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
     }
    class lucorner : Figure
    {
        public lucorner(int xLeft, int xRight, char sym)
        {
            pList = new List<Point>();
               Point p = new Point(xLeft, xRight, sym);
                pList.Add(p);
            
        }
    }
    class ldcorner : Figure
    {
        public ldcorner(int xLeft, int xRight, char sym)
        {
            pList = new List<Point>();
            Point p = new Point(xLeft, xRight, sym);
            pList.Add(p);

        }
    }
    class rucorner : Figure
    {
        public rucorner(int xLeft, int xRight, char sym)
        {
            pList = new List<Point>();
            Point p = new Point(xLeft, xRight, sym);
            pList.Add(p);

        }
    }
    class rdcorner : Figure
    {
        public rdcorner(int xLeft, int xRight, char sym)
        {
            pList = new List<Point>();
            Point p = new Point(xLeft, xRight, sym);
            pList.Add(p);

        }
    }

    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            int x = 85, y = 43;
            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '═');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '═');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '║');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '║');
            lucorner Lucorner = new lucorner(0, 0, '╔');
            rucorner Rucorner = new rucorner(x-2, 0, '╗');
            ldcorner Ldcorner = new ldcorner(0, y-1, '╚');
            rdcorner Rdcorner = new rdcorner(x-2, y-1, '╝');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            wallList.Add(Lucorner);
            wallList.Add(Rucorner);
            wallList.Add(Ldcorner);
            wallList.Add(Rdcorner);
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public void clear()
        {
            Console.Clear();
            this.Draw();
        }
    }

}
