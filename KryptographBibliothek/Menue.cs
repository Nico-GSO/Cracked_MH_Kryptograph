﻿using System;
using Figgle;
using System.IO;
using System.Collections;


namespace KryptographBibliothek
{
    public class Menue
    {
        public static void MainMenue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            bool Exit = false;            
            Console.WriteLine("progammiert von Deniz Dersim Kest\n\n\n");
            Console.WriteLine();
            Console.WriteLine(FiggleFonts.Slant.Render("Cracked MH"), "\n");
            Console.WriteLine("Drücken sie eine beliebige Taste um fortzufahren");
            bool flag=false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.ReadKey();
                Console.Clear();
                //ASCII art Logo wird erzeugt.  
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Kryptograph"));
                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");
                //Beschreibung der Software.               
                //Eingabeaufforderung 
                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");
                string dateipfad = Console.ReadLine();                       
                switch (dateipfad)
                {
                    case "exit":
                        Exit = true;
                        break;                   
                    default:
                        flag = Pfadprüfer(dateipfad);
                        if(flag)
                        {
                         //Kons...ChiffeEinlesen(pfad);
                        }                     
                        break;
                }
                Console.WriteLine("Ist der Text eine die auf Englisch entschlüsselt werden soll?" +
                    "\n wenn ja, geben sie ja ein");
                var textenglisch = Console.ReadLine();
                if(textenglisch == ja)
                
            } while (!flag);
            do
            {
             
            } while (!flag);
            if (Exit)
                Environment.Exit(0);
        }
        public static bool Pfadprüfer(string pfad)
        {
            if (File.Exists(pfad))
            {
                Console.WriteLine("der Pfad '{0}'existiert.", pfad);
                return true;
            }
            else
            {
                Console.WriteLine("{0} ist kein richtig angegebener Pfad.", pfad);
                return false;
            }


        }
    }
}