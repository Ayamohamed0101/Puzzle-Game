using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex = 0;
        int inmoves = 0;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
    
        public Form1()
        {
            
            InitializeComponent();
            var bmap = new List<Bitmap>()
            {

                Properties.Resources._0__3_,Properties.Resources._1__3_,
                 Properties.Resources._2__3_, Properties.Resources._3__3_,
                 Properties.Resources._4__3_, Properties.Resources._5__3_,
                 Properties.Resources._6__3_, Properties.Resources._7__3_,
                 Properties.Resources._8__2_, Properties.Resources._null
            };

            lstOriginalPictureList.AddRange(bmap);
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
        }
        private bool _check()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbBuzzle.Controls[i] as PictureBox).Image != lstOriginalPictureList[i])
                    return false;
            }
            if (i == 8)
                return true;

            else return false;
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>
                    (
                    new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 }
                    );
                //8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbBuzzle.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9)
                        inNullSliceIndex = i;//store empty picture box index
                }
            } while (_check());

        }

        /// <summary>
        /// Calculates the indices of adjacent PictureBoxes for a given index in a 3x3 grid.
        /// </summary>
        /// <param name="currentIndex">The index of the current PictureBox.</param>
        /// <returns>A list of indices of adjacent PictureBoxes.</returns>
        private List<int> CalculateAdjacentIndices(int currentIndex)
        {
            List<int> adjacentIndices = new List<int>();

            // Calculate potential adjacent indices
            int leftIndex = GetLeftIndex(currentIndex);
            int aboveIndex = GetAboveIndex(currentIndex);
            int rightIndex = GetRightIndex(currentIndex);
            int belowIndex = GetBelowIndex(currentIndex);

            // Add valid adjacent indices to the list
            if (leftIndex != -1) adjacentIndices.Add(leftIndex);
            if (aboveIndex >= 0) adjacentIndices.Add(aboveIndex);
            if (rightIndex != -1) adjacentIndices.Add(rightIndex);
            if (belowIndex < 9) adjacentIndices.Add(belowIndex);

            return adjacentIndices;          //                                      
        }
        private void _SwitchPictureBox(object sender, EventArgs e)
        {
            // Start the timer if the game just started
            if (lblTimeElapsed.Text == "00:00:00")
            {
                timer.Start();
            }

            // Get the index of the clicked PictureBox
            int clickedIndex = gbBuzzle.Controls.IndexOf(sender as Control);

            // Check if the clicked PictureBox is not the empty one
            if (inNullSliceIndex != clickedIndex)
            {
                // Calculate potential indices for adjacent PictureBoxes
                List<int> adjacentIndices = CalculateAdjacentIndices(clickedIndex);

                // If the empty slice is adjacent to the clicked one
                if (adjacentIndices.Contains(inNullSliceIndex))
                {
                    // Swap images between the clicked PictureBox and the empty one
                    ((PictureBox)gbBuzzle.Controls[inNullSliceIndex]).Image = ((PictureBox)gbBuzzle.Controls[clickedIndex]).Image;

                    ((PictureBox)gbBuzzle.Controls[clickedIndex]).Image = lstOriginalPictureList[9]; // Assuming this is the placeholder image

                    inNullSliceIndex = clickedIndex;

                    // Update move counter
                    lblMovesMade.Text = $"Moves Made: {++inmoves}";

                    // Check if the puzzle is solved
                    if (_check())
                    {
                        timer.Stop();
                        (gbBuzzle.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show($"Congratulations...\nYour Girl Image Is Completed\nTime Elapsed: {timer.Elapsed.ToString().Remove(8)}\nTotal Moves Made: {inmoves}", "Rabbit Puzzle");

                        // Reset the game
                        inmoves = 0;
                        lblMovesMade.Text = "Moves Made: 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }



        /// <summary>
        /// Gets the index of the PictureBox to the left of the current index, if valid.
        /// </summary>
        /// <param name="currentIndex">The index of the current PictureBox.</param>
        /// <returns>The index of the left PictureBox, or -1 if invalid.</returns>
        private int GetLeftIndex(int currentIndex)
        {
            return (currentIndex % 3 == 0) ? -1 : currentIndex - 1;
        }

        /// <summary>
        /// Gets the index of the PictureBox above the current index, if valid.
        /// </summary>
        /// <param name="currentIndex">The index of the current PictureBox.</param>
        /// <returns>The index of the above PictureBox, or a negative number if invalid.</returns>
        private int GetAboveIndex(int currentIndex)
        {
            return currentIndex - 3;
        }

        /// <summary>
        /// Gets the index of the PictureBox to the right of the current index, if valid.
        /// </summary>
        /// <param name="currentIndex">The index of the current PictureBox.</param>
        /// <returns>The index of the right PictureBox, or -1 if invalid.</returns>
        private int GetRightIndex(int currentIndex)
        {
            return (currentIndex % 3 == 2) ? -1 : currentIndex + 1;
        }

        /// <summary>
        /// Gets the index of the PictureBox below the current index, if valid.
        /// </summary>
        /// <param name="currentIndex">The index of the current PictureBox.</param>
        /// <returns>The index of the below PictureBox, or a number >= 9 if invalid.</returns>
        private int GetBelowIndex(int currentIndex)
        {
            return currentIndex + 3;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again", "Girl Puzzle");
                Shuffle();
            }
        }
    //  
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Girl Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Moves Made : 0";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer.Stop();
                gbBuzzle.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbBuzzle.Visible = true;
                btnPause.Text = "Pause";
            }
        }
        private void _soundbutton(object sender, MouseEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("mixkit-opening-software-interface-2578.wav");
            sp.Play();

        }
        private void _sound(object sender, MouseEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("mixkit-modern-technology-select-3124.wav");
            sp.Play();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
