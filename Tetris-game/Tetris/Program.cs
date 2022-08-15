using System;
using System.Collections.Generic;
using System.Threading;

namespace Tetris
{
    class Program
    {
        //Settings
        static int TetrisRows = 20;
        static int TetrisCols = 20;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1 ;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;
        static List<bool[,]> TetrisFigures = new List<bool[,]>()
            {
                new bool[,]
                { 
                    { true, true, true, true }
                },
                new bool[,] 
                {
                    { true, true },
                    { true, true }
                },
                new bool[,] 
                {
                    { false, true, false },
                    { true, true, true }
                },
                new bool[,]
                {
                    { false, true, true },
                    { true, true, false }
                },
                new bool[,] 
                {
                    { true, true, false },
                    { false, true, true }
                },
                new bool[,] 
                {
                    { true, false, false },
                    { true, true, true }
                },
                new bool[,] 
                {
                    { false, false, true },
                    { true, true, true }
                },
            };
        static int[] ScorePerLines = { 0, 40, 100, 300, 1200 };

        //State
        static int Score = 0;
        static int Frame = 0;
        static int FramesToMoveFigure = 15;
        static int CurrentFigureRow = 0;
        static int CurrentFigureCol = 0;
        static bool[,] CurrentFigure = null;
        static Random Random = new Random();

        static bool[,] TetrisField = new bool[TetrisRows, TetrisCols];

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Tetris za Bizoni i Mizoni";
            Console.CursorVisible = false;
            Console.WindowHeight = ConsoleRows + 1;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows + 1;
            Console.BufferWidth = ConsoleCols;

            CurrentFigure = TetrisFigures[Random.Next(0, TetrisFigures.Count)];

            DrawBorder();
            DrawInfo();

            while (true)
            {
                Frame++;

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A)
                    {
                        return;
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if(CurrentFigureCol >= 1)
                        {
                            CurrentFigureCol--;
                        }                       
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (CurrentFigureCol < TetrisCols - CurrentFigure.GetLength(1))
                        {
                            CurrentFigureCol++;
                        }
                    }
                    if (key.Key == ConsoleKey.UpArrow)
                    {

                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        Score++;
                        Frame = 1;
                        CurrentFigureRow++;
                    }
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        RotateCurrentFigure();
                    }
                }

                if (Frame % FramesToMoveFigure == 0)
                {
                    CurrentFigureRow++;
                    Frame = 0;
                    Score++;
                }

                if (Collision())
                {
                    AddCurrentFigureToTetrisField();
                    int lines = CheckForFullLines();
                    Score += ScorePerLines[lines];

                    CurrentFigure = TetrisFigures[Random.Next(0, TetrisFigures.Count)];
                    CurrentFigureCol = 0;
                    CurrentFigureRow = 0;

                    if (Collision())
                    {
                        Write("╔══════════╗", 5, 5);
                        Write("║Ko        ║", 6, 5);
                        Write("║ naprai   ║", 7, 5);
                        Write("║       we ║", 8, 5);
                        Write("║  Bizon?  ║", 9, 5);
                        Write("╚══════════╝", 10, 5);
                        Thread.Sleep(100000);
                        return;
                    }
                }

                DrawBorder();
                DrawInfo();
                DrawTetrisField();
                DrawCurrentFigure();

                
                Thread.Sleep(40);
            }

        }

        static void RotateCurrentFigure()
        {
            var newFigure = new bool[CurrentFigure.GetLength(1), CurrentFigure.GetLength(0)];
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    newFigure[col, CurrentFigure.GetLength(0) - row - 1] = CurrentFigure[row, col];
                }
            }
            CurrentFigure = newFigure;
        }

        static bool Collision()
        {
            if (CurrentFigureRow + CurrentFigure.GetLength(0) == TetrisRows)
            {
                return true;
            }

            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col] &&
                        TetrisField[CurrentFigureRow + row + 1, CurrentFigureCol + col])
                    { 
                        return true;
                    }
                }

            }
            return false;
        }

        static void AddCurrentFigureToTetrisField()
        {
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col])
                    {
                        TetrisField[CurrentFigureRow + row, CurrentFigureCol + col] = true;
                    }
                }

            }
        }

        static void DrawBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            for (int i = 0; i < TetrisCols; i++)
            {
                line += "═";
            }

            line += "╦";

            for (int i = 0; i < TetrisCols; i++)
            {
                line += "═";
            }

            line += "╗";
            Console.WriteLine(line);

            for (int i = 0; i < TetrisRows; i++)
            {
                string midLine = "║";
                midLine += new string(' ', TetrisCols);
                midLine += "║";
                midLine += new string(' ', InfoCols);
                midLine += "║";
                Console.WriteLine(midLine);
            }

            string lastLine = "╚";
            for (int i = 0; i < TetrisCols; i++)
            {
                lastLine += "═";
            }

            lastLine += "╩";

            for (int i = 0; i < TetrisCols; i++)
            {
                lastLine += "═";
            }

            lastLine += "╝";

            Console.WriteLine(lastLine);
        }

        static void DrawInfo()
        {
            Write("Score:", 1, 3 + TetrisCols);
            Write(Score.ToString(), 2, 3 + TetrisCols);
            Write("Frame:", 4, 3 + TetrisCols);
            Write(Frame.ToString(), 5, 3 + TetrisCols);
            Write("Position:", 7, 3 + TetrisCols);
            Write($"{CurrentFigureRow},{CurrentFigureCol}", 8, 3 + TetrisCols);
            Write("Keys:", 10, 3 + TetrisCols);
            Write($"    ^ ", 11, 3 + TetrisCols);
            Write($"  < v >", 12, 3 + TetrisCols);

        }

        static void DrawCurrentFigure()
        {
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col])
                    {
                        Write("*", row + 1 + CurrentFigureRow, col + 1 + CurrentFigureCol);
                    }
                }
            }
        }

        static void DrawTetrisField()
        {
            for (int row = 0; row < TetrisField.GetLength(0); row++)
            {
                for (int col = 0; col < TetrisField.GetLength(1); col++)
                {
                    if (TetrisField[row, col])
                    {
                        Write("*", row + 1, col + 1);
                    }
                }
            }
        }

        static int CheckForFullLines()
        {
            int lines = 0;

            for (int row = 0; row < TetrisField.GetLength(0); row++)
            {
                bool rowIsFull = true;
                for (int col = 0; col < TetrisField.GetLength(1); col++)
                {
                    if (TetrisField[row, col] == false)
                    {
                        rowIsFull = false;
                        break;
                    }
                }

                if (rowIsFull)
                {
                    for (int rowToMove = row; rowToMove >= 1; rowToMove--)
                    {
                        for (int col = 0; col < TetrisField.GetLength(1); col++)
                        {
                            TetrisField[rowToMove, col] = TetrisField[rowToMove - 1, col];
                        }
                    }

                    lines++;
                }
            }

            return lines;
        }

        static void Write(string text, int row, int col)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(text);
        }
    }
}
