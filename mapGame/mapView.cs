using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapGame
{
    public partial class mapView : Form
    {
        //Creating the continents
        Continent Namerica = new Continent();
        Continent Samerica = new Continent();
        Continent Africa = new Continent();
        Continent Europe = new Continent();
        Continent Asia = new Continent();
        Continent Australia = new Continent();

        //Various Variables
        int playerTurn = 1;
        int attacking = 0;
        double turnNo = 0;
        int p1Power = 0;
        int p2Power = 0;
        int p1TempMod = 0;
        int p2TempMod = 0;
        bool turnFinished = false;

        public mapView()
        {
            InitializeComponent();
            
        }

        //Re-counting and updating scores. Really should've used a database...
        public void updateScores()
        {
            int p1Resources=0;
            int p2Resources=0;
            int p1Controlled = 0;
            int p2Controlled = 0;
            if (Namerica.owner==1)
            {
                p1Resources = p1Resources + Namerica.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Namerica.owner==2)
            {
                p2Resources = p2Resources + Namerica.resources;
                p2Controlled = p2Controlled + 1;
            }

            if (Africa.owner == 1)
            {
                p1Resources = p1Resources + Africa.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Africa.owner == 2)
            {
                p2Resources = p2Resources + Africa.resources;
                p2Controlled = p2Controlled + 1;
            }

            if (Samerica.owner == 1)
            {
                p1Resources = p1Resources + Samerica.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Samerica.owner == 2)
            {
                p2Resources = p2Resources + Samerica.resources;
                p2Controlled = p2Controlled + 1;
            }

            if (Asia.owner == 1)
            {
                p1Resources = p1Resources + Asia.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Asia.owner == 2)
            {
                p2Resources = p2Resources + Asia.resources;
                p2Controlled = p2Controlled + 1;
            }

            if (Europe.owner == 1)
            {
                p1Resources = p1Resources + Europe.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Europe.owner == 2)
            {
                p2Resources = p2Resources + Europe.resources;
                p2Controlled = p2Controlled + 1;
            }

            if (Australia.owner == 1)
            {
                p1Resources = p1Resources + Australia.resources;
                p1Controlled = p1Controlled + 1;
            }
            else if (Australia.owner == 2)
            {
                p2Resources = p2Resources + Australia.resources;
                p2Controlled = p2Controlled + 1;
            }
            p1Power = p1Resources - p1TempMod;
            p2Power = p2Resources - p2TempMod;
            OutputBox.Text = "Turn "+turnNo+"\nPlayer 1 - Power: "+p1Power+"\nPlayer 2 - Power: "+p2Power+"\n\n"+OutputBox.Text;
            
            //Check Win Condition
            if (p1Controlled == 0 && turnNo >= 5)
            {
                OutputBox.Text = "Player 2 Wins!\n\n" + OutputBox.Text;
                winLabel.Text = "Player 2 Wins!";
                winTime();
            }
            if (p2Controlled == 0 && turnNo >= 5)
            {
                OutputBox.Text = "Player 1 Wins!\n\n" + OutputBox.Text;
                winLabel.Text = "Player 1 Wins!";
                winTime();
            }
        }
        
        //Yay you won
        public void winTime()
        {
            winLabel.Visible = true;
            NamericaButton.Visible = false;
            SamericaButton.Visible = false;
            AfricaButton.Visible = false;
            EuropeButton.Visible = false;
            AsiaButton.Visible = false;
            AustraliaButton.Visible = false;
            saveButton.Visible = true;
            passButton.Visible = false;
            

        }
        //When turn is over 
        public void endTurn()
        {
            turnFinished = false;
            updateScores();
            turnNo=turnNo+0.5;
            turnCounter.Text = "Turn " + turnNo;
            attackCheck.Checked = false;
            
            //If land has not been defended, pass it to the other player
            if (Namerica.turnsInvaded != 0)
            {
                if(Namerica.turnsInvaded==3)
                {
                    if (Namerica.owner == 1)
                    {
                        Namerica.owner = 2;
                        OutputBox.Text = "Player 2 conquers North America!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Namerica.owner = 1;
                        OutputBox.Text = "Player 1 conquers North America!\n\n" + OutputBox.Text;
                    }
                    NamericaText.Text = "Controlled by " + Namerica.owner + " w/ " + Namerica.resources + " resources";
                    Namerica.turnsInvaded = 0;
                }
                else
                {
                    Namerica.turnsInvaded++;
                    OutputBox.Text = 4-Namerica.turnsInvaded+ " turn(s) until North America falls!\n\n" + OutputBox.Text;
                }
            }
            if (Samerica.turnsInvaded != 0)
            {
                if (Samerica.turnsInvaded == 3)
                {
                    if (Samerica.owner == 1)
                    {
                        Samerica.owner = 2;
                        OutputBox.Text = "Player 2 conquers South America!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Samerica.owner = 1;
                        OutputBox.Text = "Player 1 conquers South America!\n\n" + OutputBox.Text;
                    }
                    SamericaText.Text = "Controlled by " + Samerica.owner + " w/ " + Samerica.resources + " resources";
                    Samerica.turnsInvaded = 0;
                }
                else
                {
                    Samerica.turnsInvaded++;
                    OutputBox.Text = 4 - Samerica.turnsInvaded + " turn(s) until South America falls!\n\n" + OutputBox.Text;
                }
            }
            if (Africa.turnsInvaded != 0)
            {
                if (Africa.turnsInvaded == 3)
                {
                    if (Africa.owner == 1)
                    {
                        Africa.owner = 2;
                        OutputBox.Text = "Player 2 conquers Africa!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Africa.owner = 1;
                        OutputBox.Text = "Player 1 conquers Africa!\n\n" + OutputBox.Text;
                    }
                    AfricaText.Text = "Controlled by " + Africa.owner + " w/ " + Africa.resources + " resources";
                    Africa.turnsInvaded = 0;
                }
                else
                {
                    Africa.turnsInvaded++;
                    OutputBox.Text = 4 - Africa.turnsInvaded + " turn(s) until Africa falls!\n\n" + OutputBox.Text;
                }
            }
            if (Europe.turnsInvaded != 0)
            {
                if (Europe.turnsInvaded == 3)
                {
                    if (Europe.owner == 1)
                    {
                        Europe.owner = 2;
                        OutputBox.Text = "Player 2 conquers Europe!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Europe.owner = 1;
                        OutputBox.Text = "Player 1 conquers Europe!\n\n" + OutputBox.Text;
                    }
                    EuropeText.Text = "Controlled by " + Europe.owner + " w/ " + Europe.resources + " resources";
                    Europe.turnsInvaded = 0;
                }
                else
                {
                    Europe.turnsInvaded++;
                    OutputBox.Text = 4 - Europe.turnsInvaded + " turn(s) until Europe falls!\n\n" + OutputBox.Text;
                }
            }
            if (Asia.turnsInvaded != 0)
            {
                if (Asia.turnsInvaded == 3)
                {
                    if (Asia.owner == 1)
                    {
                        Asia.owner = 2;
                        OutputBox.Text = "Player 2 conquers Asia!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Asia.owner = 1;
                        OutputBox.Text = "Player 1 conquers Asia!\n\n" + OutputBox.Text;
                    }
                    AsiaText.Text = "Controlled by " + Asia.owner + " w/ " + Asia.resources + " resources";
                    Asia.turnsInvaded = 0;
                }
                else
                {
                    Asia.turnsInvaded++;
                    OutputBox.Text = 4 - Asia.turnsInvaded + " turn(s) until Asia falls!\n\n" + OutputBox.Text;
                }
            }
            if (Australia.turnsInvaded != 0)
            {
                if (Australia.turnsInvaded == 3)
                {
                    if (Australia.owner == 1)
                    {
                        Australia.owner = 2;
                        OutputBox.Text = "Player 2 conquers Australia!\n\n" + OutputBox.Text;
                    }
                    else
                    {
                        Australia.owner = 1;
                        OutputBox.Text = "Player 1 conquers Australia!\n\n" + OutputBox.Text;
                    }
                    AustraliaText.Text = "Controlled by " + Australia.owner + " w/ " + Australia.resources + " resources";
                    Australia.turnsInvaded = 0;
                }
                else
                {
                    Australia.turnsInvaded++;
                    OutputBox.Text = 4 - Australia.turnsInvaded + " turn(s) until Australia falls!\n\n" + OutputBox.Text;
                }
            }

            //Once past turn 4.5, invasions become available
            if (turnNo >= 5)
            {
                attackCheck.Visible = true;
                invadeLabel.Visible = false;
            }

            //Switch turn
            if (playerTurn == 1)
            {
                playerTurn = 2;
                turnText.Text = "Player 2's Turn";
                powerLabel.Text = "Power - " + p2Power;
            }
            else
            {
                playerTurn = 1;
                turnText.Text = "Player 1's Turn";
                powerLabel.Text = "Power - " + p1Power;
            }
        }

        private void NamericaButton_Click(object sender, EventArgs e)
        {
            if(turnFinished==false)
            { 
            //Case 1: Claim land
            if (Namerica.owner == 0)
            {
                Namerica.owner = playerTurn;
                NamericaText.Text = "Controlled by " + Namerica.owner;
                OutputBox.Text = "Player " + playerTurn + " claims North America!\n\n" + OutputBox.Text;
                turnFinished = true;
            }
            else if (attacking != 1)
            {
                if (Namerica.invaded == false)
                {
                    //Case 2: Gain Resources
                    if (Namerica.owner == playerTurn)
                    {
                        Namerica.resources++;
                        turnFinished = true;
                    }
                }
                //Case 3: Defend land
                else
                {
                    if (playerTurn == 1 && p1Power >= Namerica.resources)
                    {
                        p1TempMod = p1TempMod + Namerica.resources;
                        Namerica.invaded = false;
                        OutputBox.Text = "Player " + playerTurn + " holds North America!\n\n" + OutputBox.Text;
                        Namerica.turnsInvaded = 0;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Namerica.resources)
                    {
                        p2TempMod = p2TempMod + Namerica.resources;
                        Namerica.invaded = false;
                        OutputBox.Text = "Player " + playerTurn + " holds North America!\n\n" + OutputBox.Text;
                        Namerica.turnsInvaded = 0;
                        turnFinished = true;
                    }
                }

            }
            //Case 4: Invade Land
            else if (Namerica.owner != playerTurn)
            {
                if (playerTurn == 1 && p1Power >= Namerica.resources * 2)
                {
                    Namerica.invaded = true;
                    OutputBox.Text = "Player " + playerTurn + " invades North America!\n\n" + OutputBox.Text;
                    p1TempMod = p1TempMod + Namerica.resources;
                    Namerica.turnsInvaded = 1;
                    OutputBox.Text = 4 - Namerica.turnsInvaded + " turn(s) until North America falls!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                if (playerTurn == 2 && p2Power >= Namerica.resources * 2)
                {
                    Namerica.invaded = true;
                    OutputBox.Text = "Player " + playerTurn + " invades North America!\n\n" + OutputBox.Text;
                    p2TempMod = p2TempMod + Namerica.resources;
                    Namerica.turnsInvaded = 1;
                    OutputBox.Text = 4 - Namerica.turnsInvaded + " turn(s) until North America falls!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }

            }

            //Post move
            if (Namerica.invaded == true)
            {
                NamericaText.Text = "Controlled by " + Namerica.owner + " w/ " + Namerica.resources + " resources\n being invaded";
            }
            else
            {
                NamericaText.Text = "Controlled by " + Namerica.owner + " w/ " + Namerica.resources + " resources";
            }
        }
        }

        private void EuropeButton_Click(object sender, EventArgs e)
        {
            if (turnFinished == false)
            {
                //Case 1: Claim land
                if (Europe.owner == 0)
                {
                    Europe.owner = playerTurn;
                    EuropeText.Text = "Controlled by " + Europe.owner;
                    OutputBox.Text = "Player " + playerTurn + " claims Europe!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                else if (attacking != 1)
                {
                    if (Europe.invaded == false)
                    {
                        //Case 2: Gain Resources
                        if (Europe.owner == playerTurn)
                        {
                            Europe.resources++;
                            turnFinished = true;
                        }
                    }
                    //Case 3: Defend land
                    else
                    {
                        if (playerTurn == 1 && p1Power >= Europe.resources)
                        {
                            p1TempMod = p1TempMod + Europe.resources;
                            Europe.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Europe!\n\n" + OutputBox.Text;
                            Europe.turnsInvaded = 0;
                            turnFinished = true;
                        }
                        if (playerTurn == 2 && p2Power >= Europe.resources)
                        {
                            p2TempMod = p2TempMod + Europe.resources;
                            Europe.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Europe!\n\n" + OutputBox.Text;
                            Europe.turnsInvaded = 0;
                            turnFinished = true;
                        }
                    }
                }
                //Case 4: Invade Land
                else if (Europe.owner != playerTurn)
                {
                    if (playerTurn == 1 && p1Power >= Europe.resources * 2)
                    {
                        Europe.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Europe!\n\n" + OutputBox.Text;
                        p1TempMod = p1TempMod + Europe.resources;
                        Europe.turnsInvaded = 1;
                        OutputBox.Text = 4 - Europe.turnsInvaded + " turn(s) until Europe falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Europe.resources * 2)
                    {
                        Europe.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Europe!\n\n" + OutputBox.Text;
                        p2TempMod = p2TempMod + Europe.resources;
                        Europe.turnsInvaded = 1;
                        OutputBox.Text = 4 - Europe.turnsInvaded + " turn(s) until Europe falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                }

                //Post Move
                if (Europe.invaded == true)
                {
                    EuropeText.Text = "Controlled by " + Europe.owner + " w/ " + Europe.resources + " resources\n being invaded";
                }
                else
                {
                    EuropeText.Text = "Controlled by " + Europe.owner + " w/ " + Europe.resources + " resources";
                }
                
            }
        }
        private void SamericaButton_Click(object sender, EventArgs e)
        {
            if (turnFinished == false)
            {
                //Case 1: Claim land
                if (Samerica.owner == 0)
                {
                    Samerica.owner = playerTurn;
                    SamericaText.Text = "Controlled by " + Samerica.owner;
                    OutputBox.Text = "Player " + playerTurn + " claims South America!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                else if (attacking != 1)
                {
                    if (Samerica.invaded == false)
                    {
                        //Case 2: Gain Resources
                        if (Samerica.owner == playerTurn)
                        {
                            Samerica.resources++;
                            turnFinished = true;
                        }
                    }
                    //Case 3: Defend land
                    else
                    {
                        if (playerTurn == 1 && p1Power >= Samerica.resources)
                        {
                            p1TempMod = p1TempMod + Samerica.resources;
                            Samerica.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds South America!\n\n" + OutputBox.Text;
                            Samerica.turnsInvaded = 0;
                            turnFinished = true;
                        }
                        if (playerTurn == 2 && p2Power >= Samerica.resources)
                        {
                            p2TempMod = p2TempMod + Samerica.resources;
                            Samerica.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds South America!\n\n" + OutputBox.Text;
                            Samerica.turnsInvaded = 0;
                            turnFinished = true;
                        }
                    }
                }
                //Case 4: Invade Land
                else if (Samerica.owner != playerTurn)
                {
                    if (playerTurn == 1 && p1Power >= Samerica.resources * 2)
                    {
                        Samerica.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades South America!\n\n" + OutputBox.Text;
                        p1TempMod = p1TempMod + Samerica.resources;
                        Samerica.turnsInvaded = 1;
                        OutputBox.Text = 4 - Samerica.turnsInvaded + " turn(s) until South America falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Samerica.resources * 2)
                    {
                        Samerica.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades South America!\n\n" + OutputBox.Text;
                        p2TempMod = p2TempMod + Samerica.resources;
                        Samerica.turnsInvaded = 1;
                        OutputBox.Text = 4 - Samerica.turnsInvaded + " turn(s) until South America falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                }

                //Post Move
                if (Samerica.invaded == true)
                {
                    SamericaText.Text = "Controlled by " + Samerica.owner + " w/ " + Samerica.resources + " resources\n being invaded";
                }
                else
                {
                    SamericaText.Text = "Controlled by " + Samerica.owner + " w/ " + Samerica.resources + " resources";
                }
                
            }
        }
        private void AfricaButton_Click(object sender, EventArgs e)
        {
            if (turnFinished == false)
            {
                //Case 1: Claim land
                if (Africa.owner == 0)
                {
                    Africa.owner = playerTurn;
                    AfricaText.Text = "Controlled by " + Africa.owner;
                    OutputBox.Text = "Player " + playerTurn + " claims Africa!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                else if (attacking != 1)
                {
                    if (Africa.invaded == false)
                    {
                        //Case 2: Gain Resources
                        if (Africa.owner == playerTurn)
                        {
                            Africa.resources++;
                            turnFinished = true;
                        }
                    }
                    //Case 3: Defend land
                    else
                    {
                        if (playerTurn == 1 && p1Power >= Africa.resources)
                        {
                            p1TempMod = p1TempMod + Africa.resources;
                            Africa.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Africa!\n\n" + OutputBox.Text;
                            Africa.turnsInvaded = 0;
                            turnFinished = true;
                        }
                        if (playerTurn == 2 && p2Power >= Africa.resources)
                        {
                            p2TempMod = p2TempMod + Africa.resources;
                            Africa.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Africa!\n\n" + OutputBox.Text;
                            Africa.turnsInvaded = 0;
                            turnFinished = true;
                        }
                    }
                }
                //Case 4: Invade Land
                else if (Africa.owner != playerTurn)
                {
                    if (playerTurn == 1 && p1Power >= Africa.resources * 2)
                    {
                        Africa.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Africa!\n\n" + OutputBox.Text;
                        p1TempMod = p1TempMod + Africa.resources;
                        Africa.turnsInvaded = 1;
                        OutputBox.Text = 4 - Africa.turnsInvaded + " turn(s) until Africa falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Africa.resources * 2)
                    {
                        Africa.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Africa!\n\n" + OutputBox.Text;
                        p2TempMod = p2TempMod + Africa.resources;
                        Africa.turnsInvaded = 1;
                        OutputBox.Text = 4 - Africa.turnsInvaded + " turn(s) until Africa falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                }

                //Post Move
                if (Africa.invaded == true)
                {
                    AfricaText.Text = "Controlled by " + Africa.owner + " w/ " + Africa.resources + " resources\n being invaded";
                }
                else
                {
                    AfricaText.Text = "Controlled by " + Africa.owner + " w/ " + Africa.resources + " resources";
                }
               
            }
        }
        private void AsiaButton_Click(object sender, EventArgs e)
        {
            if (turnFinished == false)
            {
                //Case 1: Claim land
                if (Asia.owner == 0)
                {
                    Asia.owner = playerTurn;
                    AsiaText.Text = "Controlled by " + Asia.owner;
                    OutputBox.Text = "Player " + playerTurn + " claims Asia!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                else if (attacking != 1)
                {
                    if (Asia.invaded == false)
                    {
                        //Case 2: Gain Resources
                        if (Asia.owner == playerTurn)
                        {
                            Asia.resources++;
                            turnFinished = true;
                        }
                    }
                    //Case 3: Defend land
                    else
                    {
                        if (playerTurn == 1 && p1Power >= Asia.resources)
                        {
                            p1TempMod = p1TempMod + Asia.resources;
                            Asia.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Asia!\n\n" + OutputBox.Text;
                            Asia.turnsInvaded = 0;
                            turnFinished = true;
                        }
                        if (playerTurn == 2 && p2Power >= Asia.resources)
                        {
                            p2TempMod = p2TempMod + Asia.resources;
                            Asia.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Asia!\n\n" + OutputBox.Text;
                            Asia.turnsInvaded = 0;
                            turnFinished = true;
                        }
                    }
                }
                //Case 4: Invade Land
                else if (Asia.owner != playerTurn)
                {
                    if (playerTurn == 1 && p1Power >= Asia.resources * 2)
                    {
                        Asia.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Asia!\n\n" + OutputBox.Text;
                        p1TempMod = p1TempMod + Asia.resources;
                        Asia.turnsInvaded = 1;
                        OutputBox.Text = 4 - Asia.turnsInvaded + " turn(s) until Asia falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Asia.resources * 2)
                    {
                        Asia.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Asia!\n\n" + OutputBox.Text;
                        p2TempMod = p2TempMod + Asia.resources;
                        Asia.turnsInvaded = 1;
                        OutputBox.Text = 4 - Asia.turnsInvaded + " turn(s) until Asia falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                }

                //Post Move
                if (Asia.invaded == true)
                {
                    AsiaText.Text = "Controlled by " + Asia.owner + " w/ " + Asia.resources + " resources\n being invaded";
                }
                else
                {
                    AsiaText.Text = "Controlled by " + Asia.owner + " w/ " + Asia.resources + " resources";
                }
               
            }
        }
        private void AustraliaButton_Click(object sender, EventArgs e)
        {
            if (turnFinished == false)
            {
                //Case 1: Claim land
                if (Australia.owner == 0)
                {
                    Australia.owner = playerTurn;
                    AustraliaText.Text = "Controlled by " + Australia.owner;
                    OutputBox.Text = "Player " + playerTurn + " claims Australia!\n\n" + OutputBox.Text;
                    turnFinished = true;
                }
                else if (attacking != 1)
                {
                    if (Australia.invaded == false)
                    {
                        //Case 2: Gain Resources
                        if (Australia.owner == playerTurn)
                        {
                            Australia.resources++;
                            turnFinished = true;
                        }
                    }
                    //Case 3: Defend land
                    else
                    {
                        if (playerTurn == 1 && p1Power >= Australia.resources)
                        {
                            p1TempMod = p1TempMod + Australia.resources;
                            Australia.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Australia!\n\n" + OutputBox.Text;
                            Australia.turnsInvaded = 0;
                            turnFinished = true;
                        }
                        if (playerTurn == 2 && p2Power >= Australia.resources)
                        {
                            p2TempMod = p2TempMod + Australia.resources;
                            Australia.invaded = false;
                            OutputBox.Text = "Player " + playerTurn + " holds Australia!\n\n" + OutputBox.Text;
                            Australia.turnsInvaded = 0;
                            turnFinished = true;
                        }
                    }
                }
                //Case 4: Invade Land
                else if (Australia.owner != playerTurn)
                {
                    if (playerTurn == 1 && p1Power >= Australia.resources * 2)
                    {
                        Australia.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Australia!\n\n" + OutputBox.Text;
                        p1TempMod = p1TempMod + Australia.resources;
                        Australia.turnsInvaded = 1;
                        OutputBox.Text = 4 - Australia.turnsInvaded + " turn(s) until Australia falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                    if (playerTurn == 2 && p2Power >= Australia.resources * 2)
                    {
                        Australia.invaded = true;
                        OutputBox.Text = "Player " + playerTurn + " invades Australia!\n\n" + OutputBox.Text;
                        p2TempMod = p2TempMod + Australia.resources;
                        Australia.turnsInvaded = 1;
                        OutputBox.Text = 4 - Australia.turnsInvaded + " turn(s) until Australia falls!\n\n" + OutputBox.Text;
                        turnFinished = true;
                    }
                }

                //Post Move
                if (Australia.invaded == true)
                {
                    AustraliaText.Text = "Controlled by " + Australia.owner + " w/ " + Australia.resources + " resources\n being invaded";
                }
                else
                {
                    AustraliaText.Text = "Controlled by " + Australia.owner + " w/ " + Australia.resources + " resources";
                }
               
            }
        }
        //When someone decides to attack
        private void attackCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(attackCheck.Checked==true)
            {
                attacking = 1;
            }
            else
            {
                attacking = 0;
            }
        }

        private void mapView_Load(object sender, EventArgs e)
        {

        }

        //Saves the game log to a text file
        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Saves");
            File.WriteAllText(@"Saves\game " + DateTime.Today.ToString("dd_MMM_yy") + " " + DateTime.Now.ToString("HH.mm.ss") + ".txt", OutputBox.Text);
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            endTurn();
        }

        private void InvadeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
