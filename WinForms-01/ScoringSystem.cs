using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_01
{
    internal class ScoringSystem
    {
        public string Name { get; init; }
        public List<JudgeValue> Judgements { get; set; }

        public (double, double) CalculateScore(int[] judgeCounts) {
            double score = 0;
            double normalizedScore = 0;
            double maxWeight = double.MinValue;
            for (int i = 0; i < Judgements.Count; i++)
            {
                var judge = Judgements[i];
                if (i >= judgeCounts.Length) break;
                if (!judge.Used) continue;

                maxWeight = Math.Max(maxWeight, judge.Value);
                score += judge.Value * judgeCounts[i];
            }
            normalizedScore = score / maxWeight;
            return (score, normalizedScore);
        }

    }
}
