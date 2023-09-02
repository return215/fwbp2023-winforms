using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinForms_01.ScoringSystem;

namespace WinForms_01
{
    internal class ScoringData
    {
        /// <summary>
        /// Source:
        /// - http://aaronin.jp/ddrallcalc.html
        /// - Waterfall Theme for StepMania/ITG
        /// </summary>
        internal static readonly ScoringSystem[] Systems =
        {
            new ScoringSystem
            {
                Name = "In The Groove",
                Judgements =
                {
                    new JudgeValue("Fantastic", 5),
                    new JudgeValue("Excellent", 4),
                    new JudgeValue("Great", 2),
                    new JudgeValue("Decent", 0),
                    new JudgeValue("Way Off", -6),
                    new JudgeValue("Miss", -12),
                    new JudgeValue("Hold OK", 5),
                    new JudgeValue("Hold Miss", 0),
                    new JudgeValue("Hold Tick", 0, false),
                }
            },
            new ScoringSystem
            {
                Name = "DDRMAX (with Marvelous)",
                Judgements =
                {
                    new JudgeValue("Marvelous", 3),
                    new JudgeValue("Excellent", 2),
                    new JudgeValue("Great", 1),
                    new JudgeValue("Decent", 0),
                    new JudgeValue("Way Off", -4),
                    new JudgeValue("Miss", -8),
                    new JudgeValue("Hold OK", 6),
                    new JudgeValue("Hold Miss", 0),
                    new JudgeValue("Hold Tick", 0, false),
                }
            },
            new ScoringSystem
            {
                Name = "DDR EX Score",
                Judgements =
                {
                    new JudgeValue("Marvelous", 3),
                    new JudgeValue("Excellent", 2),
                    new JudgeValue("Great", 1),
                    new JudgeValue("Decent", 0),
                    new JudgeValue("Way Off", 0),
                    new JudgeValue("Miss", 0),
                    new JudgeValue("Hold OK", 3),
                    new JudgeValue("Hold Miss", 0),
                    new JudgeValue("Hold Tick", 0, false),
                }
            },
            new ScoringSystem
            {
                Name = "Waterfall",
                Judgements =
                {
                    new JudgeValue("Masterful", 10),
                    new JudgeValue("Awesome", 9),
                    new JudgeValue("Solid", 6),
                    new JudgeValue("OK", 3),
                    new JudgeValue("Fault", 0),
                    new JudgeValue("Miss", 0),
                    new JudgeValue("Hold OK", 6),
                    new JudgeValue("Hold Miss", 0),
                    new JudgeValue("Hold Tick", 0, false),
                }
            },
            new ScoringSystem
            {
                Name = "CHUNITHM",
                Judgements =
                {
                    new JudgeValue("JUSTICE Critical", 2.02),
                    new JudgeValue("Justice", 2),
                    new JudgeValue("Attack", 1),
                    new JudgeValue("Decent", 0, false),
                    new JudgeValue("Way Off", 0, false),
                    new JudgeValue("Miss", 0),
                    new JudgeValue("Hold OK", 3, false),
                    new JudgeValue("Hold Miss", 0, false),
                    new JudgeValue("Hold Tick", 0, false),
                }
            },
        };
    }
}
