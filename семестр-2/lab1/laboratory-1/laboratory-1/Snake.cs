using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace laboratory_1
{
    /*  class Snake : Figure
      {
          Direction direction;

          public Snake(Point tail, int length, Direction _direction)
          {
              direction = _direction;
              pList = new List<Point>();
              for (int i = 0; i < length; i++)
              {
                  Point p = new Point(tail);
                  p.Move(i, direction);
                  pList.Add(p);
              }
          }

          public void Move()
          {
              Point tail = pList.First();
              pList.Remove(tail);
              Point head = GetNextPoint();
              pList.Add(head);

              tail.Clear();
              head.Draw();
          }

          private Point GetNextPoint()
          {
              Point head = pList.Last();
              Point nextPoint = new Point(head);
              nextPoint.Move(1, direction);
              return nextPoint;
          }
          public void HandleKey(ConsoleKey key)
          {
              if (key == ConsoleKey.LeftArrow)
                  direction = Direction.LEFT;
              else if (key == ConsoleKey.RightArrow)
                  direction = Direction.RIGHT;
              else if (key == ConsoleKey.DownArrow)
                  direction = Direction.DOWN;
              else if (key == ConsoleKey.UpArrow)
                  direction = Direction.UP;
          }
          public bool Eat(Point food)
          {


              Point head = GetNextPoint();
              if (head.IsHit(food))
              {
                  food.sym = head.sym;
                  pList.Add(food);
                  return true;
              }
              else
                  return false;
          }
          public bool crash()
          {
              Point err = new Point()

              if (head.sym == err.sym)
              {
                  return true;
              }
              else
                  return false;
          }
          public static Point p = new Point(4, 5, '*');
          public void Run()
          {
              Walls wall = new Walls(85, 43);
              wall.clear();

              Point food = new Point(4, 2, '$');
              food.Draw();
              Snake snake = new Snake(p, 4, Direction.RIGHT);
              snake.Draw();
              bool run = true; 
              while (run)
              {
                  if (snake.Eat(food))
                  {
                      food = new Point(food.x + 2, food.y + 1, '$');
                      food.Draw();
                  }
                  else
                  {
                      snake.Move();
                  }


                  if (crash()) 
                  {
                          run = false;
                          Console.SetCursorPosition(32, 20);
                          Console.WriteLine("ЗМЕЙКА КАПУТ");

                  }

                  Thread.Sleep(100);
                  if (Console.KeyAvailable)
                  {
                      ConsoleKeyInfo key = Console.ReadKey();
                      snake.HandleKey(key.Key);
                  }


              }

          }
      }
  }
  */

    