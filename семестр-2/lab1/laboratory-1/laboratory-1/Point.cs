﻿using System;

namespace laboratory_1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        private object p1;
        private object p2;
        private char v;

        // не знаю, нафига делаю все под копирку. надеюсь, потом проявятся более интересные варианты реализации
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;

        }

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        //упростим немного и сделаем все доступным в одном методе.

        public void pointer(int x, int y, char symbol)
        {
            this.SetX(x);
            this.SetY(y);
            this.SetSym(symbol);
            this.Draw();
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public Point(char _sym)
        {
            sym = _sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

       
       
        public Point(object p1, object p2, char v)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.v = v;
        }
    }
}
