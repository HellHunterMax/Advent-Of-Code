namespace Advent_Of_Code.Day3.Part2
{
    public class LifeSupport : IPower
    {
        private List<string> _report = new();
        private string _oxygen = String.Empty;
        private string _scrubber = String.Empty;

        public decimal ParseReport(List<string> report)
        {
            for (int i = 0; i < report.Count; i++)
            {
                _report.Add(report[i]);
            }

            FindOxygen();
            _report = report;
            FindScrubber();

            return CalculateLifeSupport();
        }

        private decimal CalculateLifeSupport()
        {
            return Convert.ToInt32(_oxygen, 2) * Convert.ToInt32(_scrubber, 2);
        }

        private void FindScrubber()
        {
            for (int i = 0; i < _report[0].Length; i++)
            {
                int halve = _report.Count / 2;
                int zeros = ReportParser.CountNumberOfZeros(_report, i);
                int zerosMoreLessOrEqual = ReportParser.ZerosMoreThanHalf(halve, zeros);
                char numberToKeep = FindScrubberNumber(zerosMoreLessOrEqual);
                for (int j = 0; j < _report.Count; j++)
                {
                    if (_report[j][i] != numberToKeep)
                    {
                        _report.Remove(_report[j]);
                        j--;
                    }
                    if (_report.Count == 1)
                    {
                        _scrubber = _report[0];
                        break;
                    }
                }
                if (_report.Count == 1)
                {
                    break;
                }
            }
        }

        private static char FindScrubberNumber(int zerosMoreLessOrEqual)
        {
            if (zerosMoreLessOrEqual == 1)
            {
                return '1';
            }
            else if (zerosMoreLessOrEqual == -1)
            {
                return '0';
            }
            return '0';
        }

        private void FindOxygen()
        {
            for (int i = 0; i < _report[0].Length; i++)
            {
                int halve = _report.Count / 2;
                int zeros = ReportParser.CountNumberOfZeros(_report, i);
                int zerosMoreLessOrEqual = ReportParser.ZerosMoreThanHalf(halve, zeros);
                char numberToKeep = FindOxygenNumber(zerosMoreLessOrEqual);
                for (int j = 0; j < _report.Count; j++)
                {
                    if (_report[j][i] != numberToKeep)
                    {
                        _report.Remove(_report[j]);
                        j--;
                    }
                    if (_report.Count == 1)
                    {
                        _oxygen = _report[0];
                        break;
                    }
                }
                if (_report.Count == 1)
                {
                    break;
                }
            }
        }

        private static char FindOxygenNumber(int zerosMoreLessOrEqual)
        {
            if (zerosMoreLessOrEqual == 1)
            {
                return '0';
            }
            else if (zerosMoreLessOrEqual == -1)
            {
                return '1';
            }
            return '1';

        }
    }
}
