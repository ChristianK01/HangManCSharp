using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HangManGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables to be used throughout the program
        string hidden_word = "";
        List<Label> unknown_letters = new List<Label>();
        int guesses = 0;

        private void Form1_Shown(object sender, EventArgs e) //Calls methods
        {
            Hangman_Post();
            Draw_UnknownLetters();
        }

        void Reset() //Method to reset board on a win or lose condition
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Panel.DefaultBackColor);
            RandomWord();
            Draw_UnknownLetters();
            Hangman_Post();
            label2.Text = "Wrong Letters: ";
            Submit_letter_box.Text = "";
        }

        string RandomWord() //Selects a random word from the URL. Places that word in an array.
        {
            WebClient wc = new WebClient();
            string wordList = wc.DownloadString
            ("https://raw.githubusercontent.com/Tom25/Hangman/master/wordlist.txt");

            string[] selected_word = wordList.Split('\n'); //Separates words by a new line
            Random random_word = new Random(); // Picks a word at random
            return selected_word[random_word.Next(0, selected_word.Length - 1)]; //Returns word in the array
        }

        void Draw_UnknownLetters() // Creates spaces in the panel to indicate unknown letters of the random word
        {
            hidden_word = RandomWord();
            char[] word = hidden_word.ToCharArray();
            int between = 275 / word.Length - 1; // Creates spaces based on the position on the Unknown Word panel
            for (int i = 0; i < word.Length; i++)
            {
                unknown_letters.Add(new Label());
                unknown_letters[i].Location = new Point((i * between) + 10, 80); // calculates position of next space
                unknown_letters[i].Text = "_"; //Default marker for unknown letter. Is replaced by letter on correct guess.
                unknown_letters[i].Parent = Unknown_Word;
                unknown_letters[i].BringToFront(); //Makes sure you can always see spaces by bringing them to the front
                unknown_letters[i].CreateControl();
            }
            label1.Text = "Word Length: " + (word.Length).ToString();
        }

        enum BodyParts //Creates body parts that will be drawn if a wrong letter or word is selected
        {
            Head,
            Body,
            R_Arm,
            L_Arm,
            R_Leg,
            L_Leg,
            L_Eye,
            R_Eye,
            Mouth,
        }

        void Hangman_Post() // Draws hangman post when the program loads
        {
            Graphics hangPost = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 10);
            hangPost.DrawLine(pen, new Point(160, 275), new Point(160, 5)); //Coordinates of the post in the panel
            hangPost.DrawLine(pen, new Point(165, 5), new Point(95, 5));
            hangPost.DrawLine(pen, new Point(90, 0), new Point(90, 50));
           
        }

        void DrawBodyParts(BodyParts BP) // Creates body parts that will be revealed on a wrong guess
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            if (BP == BodyParts.Head)
                g.DrawEllipse(p, 65, 50, 50, 50);

            else if (BP == BodyParts.L_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 77, 70, 5, 5);
            }
            else if (BP == BodyParts.R_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 94, 70, 5, 5);
            }
            else if (BP == BodyParts.Mouth)
            {
                g.DrawArc(p, 77, 85, 25, 25, 225, 90);
            }
            else if (BP == BodyParts.Body)
            {
                g.DrawLine(p, new Point(90, 100), new Point(90, 188));
            }
            else if (BP == BodyParts.L_Arm)
            {
                g.DrawLine(p, new Point(90, 125), new Point(50, 110));
            }
            else if (BP == BodyParts.R_Arm)
            {
                g.DrawLine(p, new Point(90, 125), new Point(125, 110));
            }
            else if (BP == BodyParts.L_Leg)
            {
                g.DrawLine(p, new Point(90, 185), new Point(65, 230));
            }
            else if (BP == BodyParts.R_Leg)
            {
                g.DrawLine(p, new Point(89, 185), new Point(115, 230));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = Submit_letter_box.Text.ToLower().ToCharArray()[0];  // user submission will always be lower case letter
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("Invalid. Only letters accepted", "Wrong Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hidden_word.Contains(letter))
            {
                char[] letters = hidden_word.ToCharArray(); //Places hidden word into an array separated by letters
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter) //Changes blank spaces with correct letter if the user is correct.
                        unknown_letters[i].Text = letter.ToString();
                }
            }
            else
            {
                MessageBox.Show("That letter is not in the word.", "Incorrect");
                label2.Text += " " + letter.ToString() + ",";
                DrawBodyParts((BodyParts)guesses); //Assigns body parts to an int, and draws body part on wrong guess 
                guesses++;
                if (guesses == 9)
                {
                    MessageBox.Show("You lost! The word was: " + hidden_word);
                    Reset();
                }
                foreach (Label l in unknown_letters) 
                    if (l.Text == "_") return;
                MessageBox.Show("You have won!!! The word was: " + hidden_word, "You have won!!!");
                Reset();
            }
        }
    }
}
