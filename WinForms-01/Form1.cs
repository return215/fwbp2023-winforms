using System.Linq;

namespace WinForms_01
{
    public partial class FormScore : Form
    {
        ScoringData data1;
        public void UpdateForm()
        {
            NumericUpDown[] numericUpDowns =
            {
                numW1, numW2, numW3,
                numW4, numW5, numW6,
                numH1, numH2, numH3,
            };

            Label[] labels =
            {
                labelW1, labelW2, labelW3,
                labelW4, labelW5, labelW6,
                labelH1, labelH2, labelH3,
            };

            ScoringSystem? system;

            try
            {
                system = data1.Systems.First(s => s.Name.Equals(comboScoreSystem.SelectedItem));
            }
            catch (InvalidOperationException)
            {
                return;
            }

            for (int i = 0; i < numericUpDowns.Length; i++)
            {
                NumericUpDown field = numericUpDowns[i];
                Label label = labels[i];
                if (i >= system.Judgements.Count)
                {
                    field.Enabled = false;
                    label.Text = "-";
                }
                else
                {
                    field.Enabled = system.Judgements[i].Used;
                    label.Text = system.Judgements[i].Used
                        ? system.Judgements[i].Name : "-";
                }
            }

            (double score, double normScore) = system.CalculateScore(new int[] {
                decimal.ToInt32(numW1.Value),
                decimal.ToInt32(numW2.Value),
                decimal.ToInt32(numW3.Value),
                decimal.ToInt32(numW4.Value),
                decimal.ToInt32(numW5.Value),
                decimal.ToInt32(numW6.Value),
                decimal.ToInt32(numH1.Value),
                decimal.ToInt32(numH2.Value),
                decimal.ToInt32(numH3.Value),
            });

            labelNormScore.Text = $"{normScore*1000000:N}";
            labelScore.Text = $"{score:N}";

        }
        public FormScore()
        {
            data1 = new ScoringData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = data1.Systems;
            var filteredData = data?.Select(s => s.Name)?.ToArray();
            if (filteredData == null)
                MessageBox.Show("Cannot load data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                comboScoreSystem.Items.AddRange(filteredData);
            comboScoreSystem.SelectedIndex = 0;
            UpdateForm();
        }

        private void comboScoreSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW1_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numH2_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW3_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW4_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW5_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW6_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numH1_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numW2_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numH3_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}