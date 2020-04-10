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

    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '=');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '=');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '|');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
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
    }

}
