using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day4.Part1
{
    public class BingoCard
    {
        List<List<Number>> Numbers;
        public bool IsWon { get; private set; }
        public int GetScore()
        {
            int score = 0;
            foreach (var row in Numbers)
            {
                foreach (var number in row)
                {
                    if (!number.Called)
                    {
                        score += number.Value;
                    }
                }
            }
            return score;
        }

        public BingoCard(List<string> numbersString)
        {
            CreateCard(numbersString);
        }

        private void CreateCard(List<string> numbersString)
        {
            Numbers = new();
            foreach (var row in numbersString)
            {
                CreateNumbersRow(row.Split(' '));
            }
        }

        private void CreateNumbersRow(string[] row)
        {
            List<Number> numbersRow = new List<Number>();
            foreach (var number in row)
            {
                if (string.IsNullOrWhiteSpace(number))
                {
                    continue;
                }
                numbersRow.Add(new Number(int.Parse(number)));
            }
            Numbers.Add(numbersRow);
        }

        public void OnNumberCalled(object source, NumberEventArgs args)
        {
            bool numberFound = false;
            foreach (var row in Numbers)
            {
                foreach (var number in row)
                {
                    if (number.IsNumber(args.Number))
                    {
                        numberFound = true;
                        break;
                    }
                }
                if (numberFound)
                {
                    CheckWin();
                    break;
                }
            }

        }

        private void CheckWin()
        {
            CheckHorizontalWin();
            if (IsWon)
            {
                return;
            }
            CheckVerticalWin(); 
        }

        private void CheckVerticalWin()
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                bool RowWin = false;
                for (int j = 0; j < Numbers[i].Count; j++)
                {
                    if (Numbers[j][i].Called)
                    {
                        RowWin = true;
                        continue;
                    }
                    RowWin = false;
                    break;
                }
                if (RowWin)
                {
                    IsWon = true;
                    break;
                }
            }
        }

        private void CheckHorizontalWin()
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                bool RowWin = false;
                for (int j = 0; j < Numbers[i].Count; j++)
                {
                    if (Numbers[i][j].Called)
                    {
                        RowWin = true;
                        continue;
                    }
                    RowWin = false;
                    break;
                }
                if (RowWin)
                {
                    IsWon = true;
                    break;
                }
            }
        }
    }
}
