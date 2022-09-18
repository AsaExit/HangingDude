using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangingDude
{
    internal class HangingDude
    {
        // lista med dina hemliga ord
        List<string> wordsList = new List<string> { "", "cat", "", "muis", "", "waterrugby", "", "canada" };
    
        //string av randomWord;
        //char gissa bokstäver(guessedLetter;)
        // string gissa hela ordet;
        // stringbuilder hela ordet så du får en ny => new StringBuilder();
        // behöver en stringbuilder för att checka av ordet StringBuilder checkWord = new StringBuilder();
        // En interger för att Index i det hemliga ordet
        // en interger för hur många gissnigar som är kvar
        // en boolom du vill fortsätta spelet = true;
        // char fort sätta spela "spelaigen" playagain;


        public void RunHangingDude()
        {
            do
            {
                GamePresentation();
                RandomSecretWord();
                GuessWordWithLines();
                ChooseLetterAndCheck();
                PlayAgain();
                ResetVariables();
            } while (spelaigen == 'y');

        }

        public void ResetVariables()
        {

            // gissat ord.Clear();
            // kontrollerat ord.Clear();
            // gissnigar kvar = 10;
            // om fortsätta speletifConti => true;
        }
        public String RandomSecretWord()
        {
            Random random = new Random();

           
            // hämta och "skapar" hemliga ordet

        }

        public void PlayAgain()
        {
            Console.WriteLine("***************");
            Console.WriteLine("---------------");
            /*spelaigen= 'x';
            while (spelaigen != 'y' && spelaigen != 'n')
            {
                Console.WriteLine(" Play again??? (y/n)");
                spelaigen = Console.ReadKey(true).KeyChar;
            }
            Console.Clear();*/

        }
        public void GuessWordWithLines()
        {
            //gissa ordet med.Append('_', randomWord.Length);
      

        }


        public void GamePresentation()
        {

            Console.WriteLine("  *** Welcome to Hanging your Dude Game ***                 ");
            Console.WriteLine("  You have to guess the secret word in 10 chances");

        }

        public void ChooseLetterAndCheck()
        {

            while ()
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("******Choose a letter or the hole word******");
                    // gissa hela ordet
                } while ();

                if ()
                {
                    // gissa bokstav = gissa hela ordet[0]; Och dessa metoder körs
                    CheckLetterInSecretWord();
                    CheckWin();
                }
                else
                {
                    CheckWin();
                }

            }
        }



        public void CheckWin()
        {
            
        }
        public void CheckLetterInSecretWord()
        {

            // Checka av hela ordet innehåller de gissade bokstäverna
            if (/*.ToString().Contains())*/)
            {
                Console.WriteLine("Bra jobbat");
                while (/*checkWord.ToString().Contains(guessedLetter)*/)
                {
                    // Ett exempel 
                    /*indexInSecretWord = checkWord.ToString().IndexOf(guessedLetter);
                    checkWord[indexInSecretWord] = '_';
                    guessedWord[indexInSecretWord] = guessedLetter;*/

                }
            }
            else
            {
                if (/* villkor för fel gissning Inte stämmer=> !*/)
                {
                   
                    Console.WriteLine("Wrong letter, try again");

                }
                else { Console.WriteLine("you have already tried with this letter, try again"); }

            }

            Console.WriteLine(/*Skriva ut det gissade ordet*/);
        }
    }

}
