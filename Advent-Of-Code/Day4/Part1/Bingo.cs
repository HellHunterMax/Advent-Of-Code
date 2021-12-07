using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day4.Part1
{
    public class Bingo
    {
        private readonly List<BingoCard> _bingoCards = new List<BingoCard>();
        private readonly NumberCaller _numberCaller;
        private BingoCard? _winner;
        private List<BingoCard> _winners = new List<BingoCard>();

        public Bingo(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            
            _numberCaller = BuidNumberCaller(lines[0].Split(','));
            CreateBingoCards(lines);
        }

        public int FindLoser()
        {
            while (_winners.Count != _bingoCards.Count)
            {
                _numberCaller.CallNumber();
                foreach (var card in _bingoCards)
                {
                    if (card.IsWon && !_winners.Contains(card))
                    {
                        _winners.Add(card);
                        _winner = card;
                        _numberCaller.NumberCalled -= card.OnNumberCalled;
                    }
                }
            }
            return _winner.GetScore() * _numberCaller.Last.Value;
        }

        public int FindWinner()
        {
            while (_winner == null)
            {
                _numberCaller.CallNumber();
                foreach (var card in _bingoCards)
                {
                    if (card.IsWon)
                    {
                        _winner = card;
                    }
                }
            }
            return _winner.GetScore() * _numberCaller.Last.Value;
        }

        private void CreateBingoCards(string[] lines)
        {
            for (int i = 2; i < lines.Length; i+=6)
            {
                List<string> CardLinesCollection = lines.Take(new Range(i, i + 5)).ToList();
                BingoCard bingoCard = new(CardLinesCollection);
                _numberCaller.NumberCalled += bingoCard.OnNumberCalled;
                _bingoCards.Add(bingoCard);
            }
        }

        private NumberCaller BuidNumberCaller(IEnumerable<string> numbersString)
        {
            List<int> numbers = new();
            foreach (var number in numbersString)
            {
                numbers.Add(int.Parse(number));
            }
            return new NumberCaller(numbers);
        }

    }
}
