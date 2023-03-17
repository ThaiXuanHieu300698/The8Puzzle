using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The8Puzzle
{
    public partial class frmGame : Form
    {
        int pos_i_null = 0, pos_j_null = 0;

        Button[,] arrBtn;

        public frmGame()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            Random();
            lblMessage.Text = "";
            arrBtn = new Button[3, 3]
            {
                { btnOne, btnTwo, btnThree },
                { btnFour, btnFive, btnSix },
                { btnSeven, btnEight, btnNine }
            };

            FindButtonNull();
        }

        private void CheckWin()
        {
            if (arrBtn[0, 0].Text == "1" && arrBtn[0, 1].Text == "2" && arrBtn[0, 2].Text == "3" &&
                arrBtn[1, 2].Text == "4" && arrBtn[2, 2].Text == "5" && arrBtn[2, 1].Text == "6" &&
                arrBtn[2, 0].Text == "7" && arrBtn[1, 0].Text == "8")
            {
                btnOne.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnTwo.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnThree.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnFour.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnSix.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnSeven.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnEight.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;
                btnNine.BackgroundImage = global::The8Puzzle.Properties.Resources.circleorange;

                lblMessage.Text = "--Win--";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblCount.Text = "0";

            btnOne.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnTwo.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnThree.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnFour.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnSix.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnSeven.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnEight.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            btnNine.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;

            Random();
            FindButtonNull();
        }

        private void Random()
        {
            List<string> numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "" };
            List<Button> buttons = new List<Button>() { btnOne, btnTwo, btnThree, btnFour, btnFive,
            btnSix, btnSeven, btnEight, btnNine };
            Random rd = new Random();
            int index;
            //Random Button

            foreach (var button in buttons)
            {
                index = rd.Next(numbers.Count);
                button.Text = numbers[index].ToString();
                numbers.Remove(numbers[index]);
            }

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int pos_i_cur = 0, pos_j_cur = 0;
            int val;
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            if (btn.Text != "")
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!int.TryParse(arrBtn[i, j].Text, out val))
                        {

                        }
                        else if (int.Parse(arrBtn[i, j].Text) == int.Parse(btn.Text))
                        {
                            pos_i_cur = i;
                            pos_j_cur = j;
                            break;
                        }
                    }
                }

                if ((pos_i_cur == pos_i_null) && (pos_j_cur == pos_j_null + 1 || pos_j_cur == pos_j_null - 1))
                {
                    string saved = arrBtn[pos_i_cur, pos_j_cur].Text;
                    arrBtn[pos_i_cur, pos_j_cur].Text = arrBtn[pos_i_null, pos_j_null].Text;
                    arrBtn[pos_i_null, pos_j_null].Text = saved;

                    pos_i_null = pos_i_cur;
                    pos_j_null = pos_j_cur;
                }
                if ((pos_j_cur == pos_j_null) && (pos_i_cur == pos_i_null + 1 || pos_i_cur == pos_i_null - 1))
                {
                    string saved = arrBtn[pos_i_cur, pos_j_cur].Text;
                    arrBtn[pos_i_cur, pos_j_cur].Text = arrBtn[pos_i_null, pos_j_null].Text;
                    arrBtn[pos_i_null, pos_j_null].Text = saved;

                    pos_i_null = pos_i_cur;
                    pos_j_null = pos_j_cur;
                }

                CheckWin();
            }
        }
        
        public void FindButtonNull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arrBtn[i, j].Text == "")
                    {
                        pos_i_null = i;
                        pos_j_null = j;
                        return;
                    }
                }
            }
        }
    }
}
