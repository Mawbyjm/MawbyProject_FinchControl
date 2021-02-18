﻿using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Mawby, John
    // Dated Created: 2/18/2021
    // Last Modified: 2/21/2021
    //
    // **************************************************

    class Program
    {
       
        /// first method run when the app starts up
     
        static void Main(string[] args)
        {
            SetTheme();
            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// setup the console theme

        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }


        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************

        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                
                // get user menu choice
                
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice
                
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW


        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************

        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show ");

                // get user menu choice
                
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance");
                Console.WriteLine("\tc) Mixing It Up");
                //Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Return to Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice
                
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound (finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance (finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp (finchRobot);
                        break;

                    //case "d":

                       // break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
    
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 200; lightSoundLevel = lightSoundLevel + 10)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(30);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(30);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(30);
            }

            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            DisplayMenuPrompt("Talent Show ");
        }
        
        static void TalentShowDisplayDance (Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Dance");

            Console.WriteLine("The Finch will now begin to dance!");

            DisplayContinuePrompt();
            Console.WriteLine();

            Console.WriteLine("\tThe Path");
            finchRobot.setMotors(-220, 255);
            finchRobot.wait(250);
            finchRobot.setMotors(190, 190);
            finchRobot.wait(100);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(250);
            finchRobot.setMotors(100, 190);
            finchRobot.wait(1000);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(1000);
            finchRobot.setMotors(75, 75);
            finchRobot.wait(1000);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(250);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(250);
            finchRobot.setMotors(255, 255);
            finchRobot.wait(1000);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(200);
            finchRobot.setMotors(255, 255);
            finchRobot.wait(200);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(200);
            finchRobot.setMotors(255, 255);
            finchRobot.wait(700);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(500);
            finchRobot.setMotors(255, 255);
            finchRobot.wait(200);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(200);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(250);
            finchRobot.setMotors(255, 255);
            finchRobot.wait(250);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(1000);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(600);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(600);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(600);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(600);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(600);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(600);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(600);
            finchRobot.setMotors(0, 0);
        }

        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Mixing It Up");

            Console.WriteLine("The Finch Robot will now show up its talent!");

            Console.WriteLine();
            DisplayContinuePrompt();

            finchRobot.noteOn(100);
            finchRobot.setLED(0, 255, 0);
            finchRobot.wait(500);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(4000);
            finchRobot.wait(500);

            finchRobot.setLED(255, 255, 255);
            finchRobot.wait(500);

            finchRobot.setMotors(-100, 255);
            finchRobot.wait(500);

            finchRobot.setLED(50, 0, 255);
            finchRobot.setMotors(-90, -90);
            finchRobot.wait(500);

            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(800);

            finchRobot.noteOn(7000);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(250);

            finchRobot.setMotors(150, 150);
            finchRobot.wait(1100);

            finchRobot.noteOn(10000);
            finchRobot.setLED(55, 200, 0);
            finchRobot.wait(500);

            finchRobot.setMotors(-255, 255);
            finchRobot.wait(250);

            finchRobot.setMotors(90, 90);
            finchRobot.wait(1000);

            finchRobot.noteOn(8000);

            finchRobot.setLED(0, 150, 200);
            finchRobot.wait(700);

            finchRobot.noteOn(1000);

            finchRobot.setMotors(-222, -222);
            finchRobot.wait(250);

            finchRobot.noteOn(500);

            finchRobot.setMotors(100, 100);
            finchRobot.wait(2827);

            finchRobot.noteOn(5874);
            finchRobot.wait(800);

            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            DisplayMenuPrompt("Talent Show");
        }

        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************

        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************

        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            // reset finch robot
            
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE


        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************

        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();
            Console.WriteLine("\tThis application will allow you to control various finctions of the Finch Robot.");

            DisplayContinuePrompt();
        }


        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************

        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }


        /// display continue prompt

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// display menu prompt

        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// display screen header

        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
