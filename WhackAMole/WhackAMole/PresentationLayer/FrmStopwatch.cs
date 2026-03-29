/*
 * Dominique Canada
 * CST - 250
 * 03/25/2026
 * Whack-A-Mole
 * Activity 5 
 */
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WhackAMole
{
    public partial class FrmStopwatch : Form
    {
        // Class level variable to hold the timers time
        TimeSpan timeElapsed = new TimeSpan();
        // Create a new Random object to generate numbers
        Random random = new Random();
        //create score
        int score = 0;

        public FrmStopwatch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Event Handler for btnStart
        /// Starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartClickEH(object sender, EventArgs e)
        {
            // Start the timer
            tmrStopwatch.Start();
        }

        /// <summary>
        /// Click Event Handler for btnStop
        /// Stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopClickEH(object sender, EventArgs e)
        {
            // Stop the timer
            tmrStopwatch.Stop();
            //
            MessageBox.Show("Game Over! Final Score: " + score + "\nTime: " + timeElapsed);
        }

        /// <summary>
        /// tICK EVENT HANDLER for tmrStopwatch
        /// Updates the timeElapsed variable and the label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrStopwatchIickEH(object sender, EventArgs e)
        {
            // Get the interval from tmrStopwatch
            int interval = tmrStopwatch.Interval;
            // Addthe timers interval to timeElased
            timeElapsed = timeElapsed.Add(TimeSpan.FromMilliseconds(interval));
            // Show the timeElasped on the label
            lblTimeElapsed.Text = timeElapsed.ToString();
            //Check if it is time to move the target button
            if (timeElapsed.Seconds % 3 == 0)
            {
                //Select a new location for the top of btTarget
                // Randomly generate a location for the top of the button
                // between 0 and the form height minus the button height
                btnTarget.Top = random.Next(0, this.Height - btnTarget.Height);
                // select a new location for the left side of btntarget
                btnTarget.Left = random.Next(0, this.Height - btnTarget.Width);
                // get random numbers for the RGB COLOR FOR the button
                btnTarget.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                // set the target to be visible 
                btnTarget.Visible = true;

                //Decoy movement and color
                btnDecoy.Left = random.Next(0, this.Width - btnDecoy.Width);
                btnDecoy.Top = random.Next(0, this.Height - btnDecoy.Height);
                btnDecoy.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                btnDecoy.Visible = true;
            }

            if (score > 5)
            {
                //fast
                interval = 500; 
            }
            if (score > 10)
            {
                //faster
                interval = 200; 
            }
        }// end of tmrStopwatchTickEH

        /// <summary>
        /// Click Event Handler for btnReset
        /// reset the timer and related variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetClickEH(object sender, EventArgs e)
        {
            // Stop the timer
            tmrStopwatch.Stop();
            // Reset elapsedTime
            timeElapsed = new TimeSpan();
            // Show the reset time on the label
            lblTimeElapsed.Text = timeElapsed.ToString();
        }

        /// <summary>
        /// Click Event Handler for btnTarget to hide the target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTargetClickEH(object sender, EventArgs e)
        {
            // Hide the target
            btnTarget.Visible = false;
            score++;
            lblScore.Text = "Score: " + score;
        }

        /// <summary>
        /// Click Event Handler for btnDecoy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecoyClickEH(object sender, EventArgs e)
        {
            // Hide the decoy
            btnDecoy.Visible = false;
            score--;
            lblScore.Text = "Score: " + score;
        }
    }
}
