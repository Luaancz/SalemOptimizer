using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalemOptimizer
{
    public partial class SolutionDetailForm : Form
    {
        private SolutionDetailForm()
        {
            InitializeComponent();
        }

        public static void ShowDetail(Organism organism)
        {
            var form = new SolutionDetailForm();

            form.Text = organism.Solution.CostTotal.ToString();
            form.lblInspirationals.Text = string.Join(Environment.NewLine, organism.GetNames());
            form.Show();
        }
    }
}
