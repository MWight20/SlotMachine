using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
/*
 *  Programmers: Michael Wight
 *   
 *  Program: Assignment 5 - "Slot Machine"
 * 
 *  About:
 *         This program runs a slot machine game. There are two game modes: 3 slot(default mode) and 5 slot, each using a slightly
 *      varied points reward in a credit system. You are allowed to either choose an existing player profile from a comboBox drop down list,
 *      create a new user that will be added to the player profile list, or play anonymously as a "guest". 
 *      
 *      Spins cost a set amount of money and player is rewarded on obtaining a 3 match or 5 match depending on the game mode. The player will not be able to switch 
 *      between players until that player has "cashed out" via the button in the bottom right. After cashing out, the program will update
 *      the players credit value and then write it into the "PlayerList.txt" file. 
 * 
 */////////////////////////////////////////////////////////////////////////////////////////////////////


namespace Assignment5_SlotMachine
{
    public partial class Form1 : Form
    {
        ///////////////////////
        // global variables: //
        ///////////////////////
        
        //Containers and Timer variables
        Dictionary<string, double> playerInfo = new Dictionary<string, double>(); 
        List<string> keyList;
        List<double> valueList;
        Random rnd = new Random();
        static System.Timers.Timer timer1 = new System.Timers.Timer();
        string path = Directory.GetCurrentDirectory();
        
        //player properties
        double userCreditTotal = 0.0;
        string userkeyIndex = "";
        string currUser = "guest";
        
        int m, a, b, c, d, f; //int values used for timer and for case selection of slot images
        string gameType = "3Slot"; //sets default game mode


        //
        // Form1() 
        //  About:
        //      On startup will read a file with a list of player names and values
        //
        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }


        //
        // Form1_Load()
        //  About:
        //         Sets required properties and add the Timer1_Tick event for the timer we will use to run the slot program.
        //      At the Interval given we will fire the Timer.Elapsed event.
        //      
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Elapsed += Timer1_Tick;
            timer1.Enabled = false;
        }


        /*
         *  Timer1_Tick() 
         * 
         *   About:
         *      This is the Timer event that occurs when the player chooses to spin. The program will check whether the
         *      gamemode is set to 3slot or 5slot, then uses a random number generator to pull a number for each switch.
         *      Because 'm' is incrementing every timer interval, the form will quickly run each switch statement over and over,
         *      creating a randomizing animation for each slot.
         *      
         *      Upon m reaching 250, the timer will be reset and the game determines if the player is a winner or not.
         */
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // variable m will increment by 10
            m = m + 10;

            //3 slot game mode
            if (gameType == "3Slot")
            {
                if (m <= 250)
                {
                    a = rnd.Next(1, 5);
                    b = rnd.Next(1, 5);
                    c = rnd.Next(1, 5);

                    switch (a)
                    {
                        case 1:
                            pictureBox1.Image = Image.FromFile(path + "\\Fox.jpg");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(path + "\\Mario.jpg");
                            break;
                        case 3:
                            pictureBox1.Image = Image.FromFile(path + "\\Link.jpg");
                            break;
                        case 4:
                            pictureBox1.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                    switch (b)
                    {
                        case 1:
                            pictureBox3.Image = Image.FromFile(path + "\\Fox.jpg");
                            break;
                        case 2:
                            pictureBox3.Image = Image.FromFile(path + "\\Mario.jpg");
                            break;
                        case 3:
                            pictureBox3.Image = Image.FromFile(path + "\\Link.jpg");
                            break;
                        case 4:
                            pictureBox3.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                    switch (c)
                    {
                        case 1:
                            pictureBox5.Image = Image.FromFile(path + "\\Fox.jpg");
                            break;
                        case 2:
                            pictureBox5.Image = Image.FromFile(path + "\\Mario.jpg");
                            break;
                        case 3:
                            pictureBox5.Image = Image.FromFile(path + "\\Link.jpg");
                            break;
                        case 4:
                            pictureBox5.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                }
                else
                {
                    timer1.Enabled = false; //stops timer
                    m = 0; //resets timer back to 0

                    // if contents of a, b, and c are the same Player wins
                    if (a == b && a == c)
                    {
                        
                        if (a == 1) // Link
                        {
                            userCreditTotal += 8.00;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $8.00!");
                        }
                        else if (a == 2) // Mario
                        {
                            userCreditTotal += 7.50;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $7.50!");
                        }
                        else if (a == 3) // Fox
                        {
                            userCreditTotal += 5.00;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $5.00!");
                        }
                        else //(a == 4) //smashBall
                        {
                            userCreditTotal += 100.00;
                            ThreadHelperClass.SetText(this, textLabel, "JACKPOT! $100.00");
                        }
                    }
                    // otherwise, player loses
                    else
                    {
                        ThreadHelperClass.SetText(this, textLabel, "No luck, try again");
                    }
                }
            }//end 3 slot

            if (gameType == "5Slot")
            {
                if (m <= 250)
                {
                    a = rnd.Next(1, 5);
                    b = rnd.Next(1, 5);
                    c = rnd.Next(1, 5);
                    d = rnd.Next(1, 5);
                    f = rnd.Next(1, 5);

                    //contents of variable a
                    switch (a)
                    {
                        case 1:
                            pictureBox1.Image = Image.FromFile(path + "\\Yoshi.jpg");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(path + "\\Marth.jpg");
                            break;
                        case 3:
                            pictureBox1.Image = Image.FromFile(path + "\\Falco.jpg");
                            break;
                        case 4:
                            pictureBox1.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                    //contents of variable b
                    switch (b)
                    {
                        case 1:
                            pictureBox2.Image = Image.FromFile(path + "\\Yoshi.jpg");
                            break;
                        case 2:
                            pictureBox2.Image = Image.FromFile(path + "\\Marth.jpg");
                            break;
                        case 3:
                            pictureBox2.Image = Image.FromFile(path + "\\Falco.jpg");
                            break;
                        case 4:
                            pictureBox2.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                    //contents of variable c
                    switch (c)
                    {
                        case 1:
                            pictureBox3.Image = Image.FromFile(path + "\\Yoshi.jpg");
                            break;
                        case 2:
                            pictureBox3.Image = Image.FromFile(path + "\\Marth.jpg");
                            break;
                        case 3:
                            pictureBox3.Image = Image.FromFile(path + "\\Falco.jpg");
                            break;
                        case 4:
                            pictureBox3.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }
                    //contents of variable d
                    switch (d)
                    {
                        case 1:
                            pictureBox4.Image = Image.FromFile(path + "\\Yoshi.jpg");
                            break;
                        case 2:
                            pictureBox4.Image = Image.FromFile(path + "\\Marth.jpg");
                            break;
                        case 3:
                            pictureBox4.Image = Image.FromFile(path + "\\Falco.jpg");
                            break;
                        case 4:
                            pictureBox4.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;
                    }
                    //contents of variable f
                    switch (f)
                    {
                        case 1:
                            pictureBox5.Image = Image.FromFile(path + "\\Yoshi.jpg");
                            break;
                        case 2:
                            pictureBox5.Image = Image.FromFile(path + "\\Marth.jpg");
                            break;
                        case 3:
                            pictureBox5.Image = Image.FromFile(path + "\\Falco.jpg");
                            break;
                        case 4:
                            pictureBox5.Image = Image.FromFile(path + "\\smashBall.jpg");
                            break;

                    }

                }
                else
                {
                    timer1.Enabled = false; //stop the timer
                    m = 0; //reset timer to 0

                    //if a == b == c == d == f, then player wins
                    if (a == b && a == c && a == d && a == f)
                    {
                        if (a == 1) //yoshi
                        {
                            userCreditTotal += 10.00;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $10.00!");
                        }
                        else if (a == 2) //Marth
                        {
                            userCreditTotal += 15.00;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $15.00!");
                        }
                        else if (a == 3) //Falco
                        {
                            userCreditTotal += 20.00;
                            ThreadHelperClass.SetText(this, textLabel, "You Won $20.00!");
                        }
                        else //(a == 4) //SmashBall
                        {
                            userCreditTotal += 200.00;
                            ThreadHelperClass.SetText(this, textLabel, "JACKPOT! $200.00!");
                        }

                       
                    }
                    // otherwise, player loses
                    else
                    {
                        ThreadHelperClass.SetText(this, textLabel, "No luck, try again");
                    }
                }
            } //end 5slot    
            
        }//end timer_Click


        /*  SpinButton_Click()
         * 
         *   About:
         *      This method is run when the spin button is clicked. Simply allows the player to initiate the game, checking their 
         *      user credit total to track if it's a game over. 
         * 
         *      Also updates various Labels and elements of the form, such as playerGroupBox to lock player into saving the game via 
         *      "cashing out". 
         */
        private void SpinButton_Click(object sender, EventArgs e)
        {
            playerGroupBox.Visible = false;

            if (userCreditTotal < 1.00)
            {
                textLabel.Text = "GAME OVER: Add Credits to play";
                playerGroupBox.Visible = false;
            }
            else //if userCreditTotal > 1.00, game will continue
            {
                userCreditTotal -= 1.00;
                textLabel.Visible = false;
                creditsLabel.Text = "$" + userCreditTotal.ToString();

                if (gameType == "3Slot")
                {

                    pictureBox2.Image = Image.FromFile(path + "\\backGround.jpg");
                    pictureBox4.Image = Image.FromFile(path + "\\backGround.jpg");
                }

                timer1.Enabled = true;
            }

        }


        /*  SwitchGameButton_Click()
         *  
         *   About:
         *      Button that allows the user to switch between 3 slot and 5 slot game modes.
         * 
         */
        private void SwitchGameButton_Click(object sender, EventArgs e)
        {
            if (gameType == "3Slot") //change to 5
            {
                modeLabel.Text = "Currently playing: 5Slot";
                gameType = "5Slot";
                pictureBox2.Image = Image.FromFile(path + "\\smashBall.jpg");
                pictureBox4.Image = Image.FromFile(path + "\\smashBall.jpg");

            }
            else //if gameType is 5Slot -> change to 3slot
            {
                modeLabel.Text = "Currently playing: 3Slot";
                gameType = "3Slot";
                pictureBox2.Image = Image.FromFile(path + "\\backGround.jpg");
                pictureBox4.Image = Image.FromFile(path + "\\backGround.jpg");

            }
        }


        /*  selectUserButton_Click()
         *  
         *   About:
         *         This method occurs when the user selects a name from the combobox dropdown and clicks the select user button.
         *      The program will update the current player information as well as form elements to indicate who the current player is.
         * 
         * 
         */
        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null || comboBox.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("No user was selected...");
                return;
            }
            else
            {
                currUser = keyList[comboBox.SelectedIndex].ToString();
                creditsLabel.Text = "$" + valueList[comboBox.SelectedIndex].ToString();
                userCreditTotal = Double.Parse(valueList[comboBox.SelectedIndex].ToString());
                userkeyIndex = comboBox.SelectedIndex.ToString();
                groupBox1.Text = "[" + currUser + "] Credits:";
            }
        }


        /*  AddTenDollarsButton_Click()
         *  
         *   About:
         *          Essentially this is just a button placed into the program to allow demonstration of credits. This button adds $10 
         *          to the selected players credits, so that if a player experiences a game over, they can "insert" $10 as credits.
         * 
         */
        private void AddTenDollarsButton_Click(object sender, EventArgs e)
        {
            userCreditTotal += 10.00;
            creditsLabel.Text = "$" + userCreditTotal.ToString();
        }

        /*  ExitButton_Click()
         *  
         *   About:
         *          Terminates the program.
         * 
         */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*  NewUserButton_Click()
         * 
         *   About:
         *         This method is used to create a new player user. If the user tries to enter a blank line as a user, the program asks the user to enter a name.
         *         To add a new player, the list of keys for players are searched. If the desired name taken from the textbox already exists, the program informs the user
         *         that the name is taken.
         *         
         *         If a name doesn't exist yet, currUser is set to the new name and the new name is given a credit total and both are added to their
         *         prospective keyList and valueList Lists to store their values in the pool of Users.
         */
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            Boolean playerExists = false;

            if (userTextBox.Text == "" || userTextBox.Text == "guest") //empty textbox
            {
                MessageBox.Show("Must enter a valid name...please enter a valid user name");
                return;
            }

            //searches and checks keyList for existing user name
            foreach (string player in keyList)
            {
                if (userTextBox.Text == player)
                {
                    playerExists = true;
                }
            } 
            
            if (playerExists)
            {
                MessageBox.Show("This name has already been entered...Please enter a new new.");
                return;
            }
            else //name in textbox doesn't exist yet
            {
                currUser = userTextBox.Text;
                userCreditTotal = 10.0;
                creditsLabel.Text = "$" + userCreditTotal;
                groupBox1.Text = "[" + currUser + "] Credits: ";
                keyList.Add(currUser);
                valueList.Add(userCreditTotal);
                comboBox.Items.Add(currUser);
                WriteFile(keyList, valueList);
                userTextBox.Text = "";
            }

        }


        /*  GuestButton_Click()
         * 
         *   About:
         *          Allows the player to anonymously play as "guest". The credits of guest are not recorded or saved into the playerbase.
         */
        private void GuestButton_Click(object sender, EventArgs e)
        {
            currUser = "guest";
            userCreditTotal = 0.0;
            creditsLabel.Text = "$" + userCreditTotal;
            groupBox1.Text = "[Guest] Credits:";

        }


        /*  CashOutButton_Click()
         * 
         *   About:
         *          This method is used to end the game of a user in session. It reenables the user to have access to select another player name, create a new name,
         *          or select guest. If the current user is not playing as a guest, their credits will be updated in valueList; The attributes of the user are then reset
         * 
         */
        private void CashOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out of this player profile!");
            playerGroupBox.Visible = true;

            //then add credits to user record
            if (currUser != "guest")
            {
                //save score
                valueList[int.Parse(userkeyIndex)] = userCreditTotal;
                WriteFile(keyList, valueList);
            }
               //reset scores
            currUser = "guest";
            groupBox1.Text = "[Guest] Credits:";
            creditsLabel.Text = "$0.0";
            userCreditTotal = 0.0;
        }


        /*  ReadFile()
         * 
         *   About:
         *          Reads "playerList.txt", which stores all the names and credit values of existing players. Using a streamReader, each newline
         *          is read and splits the string at '|'. The indices of split are put into a Dictionary<string,double> playerInfo and the items of
         *          the combobox are read into the form element.
         *          
         *          After each line is read, two lists KeyList and valueList are created to store playerInfo.Keys and playerInfo.Values.
         */
        private void ReadFile()
        {
            string S;
            string [] splitStr;
            
            using (StreamReader SR = new StreamReader(path + "\\PlayerList.txt"))
            {
                S = SR.ReadLine();
                while (S != null)
                {
                    splitStr = S.Split('|');
                    playerInfo.Add(splitStr[0], Double.Parse(splitStr[1]));
                    comboBox.Items.Add(splitStr[0]);
                    S = SR.ReadLine();
                }
            }

            //split sorted keys and values into separate Lists
            keyList = new List<string>(playerInfo.Keys); 
            valueList = new List<double>(playerInfo.Values);

        }


        /*  WriteFile()
         * 
         *   About:
         *          WriteFile() simply rewrites over the existing file "PlayerList.txt" with the current updated KeyList and valueList as a pair on each line, separated
         *          by '|'. 
         * 
         */
        private void WriteFile(List<string> keyList, List<double> valueList)
        {
            using (StreamWriter SW = File.CreateText(path + "\\PlayerList.txt"))
            {
                for(int i = 0; i < keyList.Count; i++)
                {
                    SW.WriteLine(keyList[i] + "|" + valueList[i]);
                }
            }
        }
    }//end form1 Class



    /* CLASS: ThreadHelperClass
      * 
      * Purpose:
      *      Using Delegates "setTextCallBack" and "SetImageVisCallBack", This threadHelperClass
      *      allows the program to access the ".Text" and ".Visible" form properties and change them to new values.
      *      This is necessary due to the limitations of accessibility while the form is running the Timer1_Tick() event.  
      * 
      * Methods:
      *      SetText() - will set the ctrl.Text property to a new string value.
      *      SetImageVisibility() - will set the ctrl.Visible property to a new boolean value.
      * 
      */
    public static class ThreadHelperClass
    {
        delegate void SetTextCallBack(Form f, Control ctrl, string text);
        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Visible = true;
                ctrl.Text = text;
            }
        }
        delegate void SetImageVisCallBack(Form f, Control ctrl, Boolean b);
        public static void SetImageVisibility(Form form, Control ctrl, Boolean b)
        {
            if (ctrl.InvokeRequired)
            {
                SetImageVisCallBack d = new SetImageVisCallBack(SetImageVisibility);
            }
            else
            {
                ctrl.Visible = true;
            }
        }
    }//End ThreadHelperClass


}
