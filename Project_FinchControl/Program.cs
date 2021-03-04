using System;
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

            //Declare and instantiate an object

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
                    // method that returns a value

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        LightAlarmDisplayMenuScreen(finchRobot);
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
                Console.WriteLine("\tq) Return to Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice

                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "d":

                        break;

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
                finchRobot.noteOn(lightSoundLevel * 75);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(30);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(30);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(30);
            }

            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            DisplayContinuePrompt();
            Console.Clear();

            #region Play Song

            //Validate user input with a feedback message: string value
            // use "or" operator in an if else statment

            string userRespons;
            bool validRespons;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to hear the Finch play a song?");
                Console.WriteLine("Respond with a for 'yes' or for 'no'.");

                userRespons = Console.ReadLine();

                Console.WriteLine();

                if (userRespons == "yes" || userRespons == "no")
                {
                    validRespons = true;
                    Console.WriteLine("Your response was: {0}", userRespons);
                }

                else
                {
                    validRespons = false;
                    Console.WriteLine();
                    Console.WriteLine("Please enter a yes or no.");
                }

            } while (!validRespons);


            if (userRespons == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("The Finch will begin to play Pachebel.");

                DisplayContinuePrompt();

                finchRobot.noteOn(1047);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(500);
                finchRobot.noteOn(880);
                finchRobot.wait(500);
                finchRobot.noteOn(659);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(523);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(500);
                finchRobot.noteOn(880);
                finchRobot.wait(500);
                finchRobot.noteOn(659);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(523);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(500);
                finchRobot.noteOn(880);
                finchRobot.wait(500);
                finchRobot.noteOn(659);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(523);
                finchRobot.wait(500);
                finchRobot.noteOn(698);
                finchRobot.wait(500);
                finchRobot.noteOn(784);
                finchRobot.wait(800);

                finchRobot.noteOff();

                DisplayMenuPrompt("Talent Show ");
            }

            else if (userRespons == "no")
            {
                Console.WriteLine();
                Console.WriteLine("I am sorry you did not want to hear The Finch sing.");

                DisplayMenuPrompt("Talent Show ");
            }
            #endregion
        }

        static void TalentShowDisplayDance(Finch finchRobot)
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

        #region DATA RECORDER

        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;

            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder ");

                // get user menu choice

                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Return to Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice

                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayShowData(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);
        }


        // display temps to console
        static void DataRecorderDisplayShowData(double[] temperatures)
        {
            DisplayScreenHeader("Show Data");

            DataRecorderDisplayTable(temperatures);

            Console.WriteLine();
            Console.WriteLine();

            DisplayDataRecorderConvertCelsiusToFahrenheit(temperatures);

            DisplayContinuePrompt();
        }

        //convert C to F and display F temps
        static void DisplayDataRecorderConvertCelsiusToFahrenheit(double[] temperatures)
        {
            //convert C to F
            // First multiple C by 1.8 then add 32
            int i;
            for (i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] *= 1.8;
                temperatures[i] += 32;
            }

            //display table headers

            Console.WriteLine(
                "Recording #".PadLeft(15) +
                "Temp (°F)".PadLeft(15)
                );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );

            //display table data

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                    (index + 1).ToString().PadLeft(15) +
                    temperatures[index].ToString("n2").PadLeft(15)
                    );
            }

            double sum = 0;
            double average = 0;
            int inter;

            for (inter = 0; inter < temperatures.Length; inter++)
            {
                sum = sum + temperatures[inter];
            }

            average = sum / inter;

            Console.WriteLine();
            Console.WriteLine("The average temperature is: " + average.ToString("n2") + " °F");

        }

        //display C temps
        static void DataRecorderDisplayTable(double[] temperatures)
        {
            //display table headers

            Console.WriteLine(
                "Recording #".PadLeft(15) +
                "Temp (°C)".PadLeft(15)
                );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );

            //display table data

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                    (index + 1).ToString().PadLeft(15) +
                    temperatures[index].ToString("n2").PadLeft(15)
                    );
            }
            double sum = 0;
            double average = 0;
            int inter;

            for (inter = 0; inter < temperatures.Length; inter++)
            {
                sum = sum + temperatures[inter];
            }

            average = sum / inter;

            Console.WriteLine();
            Console.WriteLine("The average temperature is: " + average.ToString("n2") + " °C");
        }

        //get C temps from user
        static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];

            DisplayScreenHeader("Get Data");

            Console.WriteLine($"\tNumber of data points: " + numberOfDataPoints);
            Console.WriteLine($"\tData point frequency: " + dataPointFrequency);
            Console.WriteLine();
            Console.WriteLine("\tThe Finch Robot is ready to begin recording temperatures.");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\t Reading {index + 1}: {temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }

            DisplayContinuePrompt();
            DisplayScreenHeader("Get Data");

            Console.WriteLine();
            Console.WriteLine("\tTable of Temperatures");
            Console.WriteLine();
            DataRecorderDisplayTable(temperatures);
           
            DisplayContinuePrompt();

            return temperatures;
        }

        //get frequency
        static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;

            DisplayScreenHeader("Data Point Frequency");

            Console.Write("Please enter the frequency that data will be recorded:");
            Console.WriteLine();

            // validation

            bool validResponse;

            do
            {

                Console.WriteLine("Enter the frequency of data points.");
                validResponse = double.TryParse(Console.ReadLine(), out dataPointFrequency);

                Console.WriteLine();
                
                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a double (0.5, 1.0, 2.3).");

                }

            } while (!validResponse);

            Console.WriteLine("Data Point Frequency: " + dataPointFrequency);

            DisplayContinuePrompt();

            return dataPointFrequency;
        }

        //get number of data points
        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;

            DisplayScreenHeader(" Nummber of Data Points");

            Console.WriteLine("Enter the number of data points that you want to record: ");

            // Validate user input

            bool validResponse;

            do
            {
                validResponse = int.TryParse(Console.ReadLine(), out numberOfDataPoints);

                Console.WriteLine();
                
                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter an interger (1, 5, 12).");
                }
                
            } while (!validResponse);

            Console.WriteLine($"Number of Data Points: {numberOfDataPoints}");

            DisplayContinuePrompt();

            return numberOfDataPoints;
        }


        #endregion

        #region LIGHT ALARM SYSTEM

        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;
            int temperatureValue = 0;

            bool quitMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Light Alarm Menu");


                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set Sensors to Monitor");
                Console.WriteLine("\tb) Set Range Type");
                Console.WriteLine("\tc) Set Minimum/Maximum Threshold Value");
                Console.WriteLine("\td) Set Time to Monitor");
                Console.WriteLine("\te) Set Alarm");
                Console.WriteLine("\tf) Set Minimum/Maximum Temperature Value");
                Console.WriteLine("\tg) Set Temperature Alarm");
                Console.WriteLine("\th) Set Light and Temperature Alarm");
                Console.WriteLine("\tq) Return to Main Menu");
                Console.Write("\t\tEnter Choice:");

                menuChoice = Console.ReadLine().ToLower();

                // process user menu choice
                
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                        break;

                    case "b":
                        rangeType = LightAlarmDisplaySetRangeType();
                        break;

                    case "c":
                        minMaxThresholdValue = LightAlarmDisplaySetMinimumMaximumThresholdValue(rangeType, finchRobot);
                        break;

                    case "d":
                        timeToMonitor = LightAlarmDisplaySetTimeToMonitor();
                        break;

                    case "e":
                        LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;
                    case "f":
                        temperatureValue = LightAlarmGetMinMaxTemperatureValue(rangeType, finchRobot);
                        break;
                    case "g":
                        LightAlarmSetTemperatureAlarm(finchRobot, rangeType, temperatureValue, timeToMonitor);
                        break;
                    case "h":
                        LightAlarmSetLightTemperatureAlarm(finchRobot, rangeType, sensorsToMonitor, minMaxThresholdValue, temperatureValue, timeToMonitor);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);
        }

        static void LightAlarmSetLightTemperatureAlarm(Finch finchRobot, string rangeType, string sensorsToMonitor, int minMaxThresholdValue, int temperatureValue, int timeToMonitor)
        {
            DisplayScreenHeader("Temperature and Light Alarm");

            Console.WriteLine($"\tTemperature to Monitor: {temperatureValue}");
            Console.WriteLine($"\tSensor(s) to Monitor: {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max Threshold Value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime To Monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any any to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;
            int elapsedTime = 0;
            double currentTemperature = 0;

            while (!thresholdExceeded && elapsedTime < timeToMonitor)
            {
                currentTemperature = finchRobot.getTemperature();

                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getLeftLightSensor() + finchRobot.getRightLightSensor()) / 2;
                        break;
                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentTemperature < temperatureValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentTemperature > temperatureValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                }

                finchRobot.wait(1000);
                elapsedTime++;
            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} or {temperatureValue} was exceeded.");
                finchRobot.noteOn(800);
                finchRobot.wait(2000);
                
                finchRobot.noteOff();
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value was not exceeded.");
            }
     
            DisplayMenuPrompt("Light Alarm");
        }

        static void LightAlarmSetTemperatureAlarm(Finch finchRobot, string rangeType, int temperatureValue, int timeToMonitor)
        {
            DisplayScreenHeader("Temperature Alarm");

            Console.WriteLine($"\tTemperature Set to Monitor: {temperatureValue}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tTime To Monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any any to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            bool thresholdExceeded = false;
            double currentTemperature = 0;
            int elapsedTime = 0;

           

            while (!thresholdExceeded && elapsedTime < timeToMonitor)
            {
                currentTemperature = finchRobot.getTemperature();

                switch (rangeType)
                {
                    case "minimum":
                        if (currentTemperature < temperatureValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentTemperature > temperatureValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                }

                finchRobot.wait(1000);
                elapsedTime++;
            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {temperatureValue} was exceeded by the currect temperature value of {currentTemperature}.");

                finchRobot.noteOn(800);
                finchRobot.wait(2000);
                finchRobot.noteOff();
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} temperature threshold value of {temperatureValue} was not exceeded.");
            }

            DisplayMenuPrompt("Light Alarm");
        }

        static int LightAlarmGetMinMaxTemperatureValue(string rangeType, Finch finchRobot)
        {
            int temperatureValue;
            bool validResponse;

            do
            {
                DisplayScreenHeader("Min/Max Temperature Value");

                Console.WriteLine($"\tAmbient Temperature value: {finchRobot.getTemperature()}");
                Console.WriteLine();

                Console.WriteLine($"\tEnter the {rangeType} temperature sensor value: ");

                validResponse = int.TryParse(Console.ReadLine(), out temperatureValue);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tPlease enter an integer.");

                    DisplayContinuePrompt();
                }

            } while (!validResponse);

            Console.WriteLine();
            Console.WriteLine("\tMin/Max temperature value set at: " + temperatureValue);

            DisplayMenuPrompt("Light Alarm");
            return temperatureValue;
        }

        static void LightAlarmSetAlarm(Finch finchRobot, string sensorsToMonitor, string rangeType, int minMaxThresholdValue, int timeToMonitor)
        {
       
            DisplayScreenHeader("Light Alarm");

            Console.WriteLine($"\tSensor(s) to Monitor: {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max Threshold Value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime To Monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any any to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;
            int elapsedTime = 0;
            double currentTemperature = 0;

            while (!thresholdExceeded && elapsedTime < timeToMonitor)
            {
                currentTemperature = finchRobot.getTemperature();

                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getLeftLightSensor() + finchRobot.getRightLightSensor()) / 2;
                        break;
                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                }

                finchRobot.wait(1000);
                elapsedTime++;
            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the currect light sensor value of {currentLightSensorValue}.");

                finchRobot.noteOn(800);
                finchRobot.wait(2000);
                finchRobot.noteOff();
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }

            DisplayMenuPrompt("Light Alarm");

        }

        static int LightAlarmDisplaySetTimeToMonitor()
        {
            int timeToMonitor;
            bool validResponse;

            do
            {
                DisplayScreenHeader("Time to Monitor");

                Console.Write("\tTime to Monitor (seconds):");
                validResponse = int.TryParse(Console.ReadLine(), out timeToMonitor);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tPlease enter a number.");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);

            Console.WriteLine();
            Console.WriteLine("\tTime to Monitor: " + timeToMonitor);

            DisplayMenuPrompt("Light Alarm");

            return timeToMonitor;
        }

        static int LightAlarmDisplaySetMinimumMaximumThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;
            bool validResponse;

            do
            {
                DisplayScreenHeader("Min/Max Threshold Value");

                Console.WriteLine($"\tLeft Light Sensor Ambient value: {finchRobot.getLeftLightSensor()}");
                Console.WriteLine($"\tRight Light Sensor Ambient value: {finchRobot.getRightLightSensor()}");
                Console.WriteLine();

                Console.WriteLine($"\tEnter the {rangeType} light sensor value: ");

                validResponse = int.TryParse(Console.ReadLine(), out minMaxThresholdValue);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tPlease enter a number.");
                    DisplayContinuePrompt();
                }

            } while (!validResponse);

            Console.WriteLine();
            Console.WriteLine("\tMin/Max Threshold Value set at: " + minMaxThresholdValue);

            DisplayMenuPrompt("Light Alarm");

            return minMaxThresholdValue;

        }

        static string LightAlarmDisplaySetRangeType()
        {

            string rangeType;
            string userResponse;

            do
            {
                DisplayScreenHeader("Range Type");

                Console.Write("\tRange Type: [minimum, maximum]");
                userResponse = Console.ReadLine().ToLower();
                rangeType = userResponse;

                if (userResponse != "minimum" && userResponse != "maximum")
                {
                    Console.WriteLine("\tPlease enter 'minimum' or 'maximum'");
                    DisplayContinuePrompt();
                }

            } while (rangeType != "minimum" && rangeType != "maximum");

            Console.WriteLine();
            Console.WriteLine("\tRange to Monitor: " + rangeType);

            DisplayMenuPrompt("Light Alarm");

            return rangeType;
        }

        static string LightAlarmDisplaySetSensorsToMonitor()
        {
            string sensorsToMonitor;
            string userResponse;

            do
            {
                DisplayScreenHeader("Sensors to Monitor");

                Console.Write("\tSensors to Monitor: [left, right, both]");
                userResponse = Console.ReadLine().ToLower();
                sensorsToMonitor = userResponse;

                if (userResponse != "left" && userResponse != "right" && userResponse != "both")
                {
                    Console.WriteLine("\tPlease enter 'left', 'right', or 'both'");
                    DisplayContinuePrompt();
                }

            } while (sensorsToMonitor != "left" && sensorsToMonitor != "right" && sensorsToMonitor != "both");

            Console.WriteLine();
            Console.WriteLine("\tSensor(s) set to monitor: " + sensorsToMonitor);

            DisplayMenuPrompt("Light Alarm");

            return sensorsToMonitor;

        }

        #endregion

        #region FINCH ROBOT MANAGEMENT (connect and disconnect)

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

        // Methods that DO NOT require arguments

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
