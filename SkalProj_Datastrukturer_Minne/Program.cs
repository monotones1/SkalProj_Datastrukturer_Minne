using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 

        //1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion
        //SVAR: Stacken sparas direkt till minnet och är väldigt snabbt. Minnesallokeringen sker när programmet kompileras.
        //Heapen är långsammare och allokeras medans programmet körs. Ett element i heapen har inget samband med andra element i heapen och kan accessas fritt.

        //2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?
        //SVAR= Stacken används för statisk minnesallokering för värdetyper och heapen används för dynamisk minnesallokering av referenstyper.
        //Tilldelning av en referensvariabel till en annan referensvariabel kopierar inte datat utan den gör en ny pointer till samma minnesallokering. 
        //Om man kopierar en värdetypsvariabel till en annan värdetypsvariabel kopieras däremot värdet direkt och båda variablerna fungerar oberoende av varandra.

        //3. Följande metoder(se bild nedan ) genererar olika svar.Den första returnerar 3, den
        //andra returnerar 4, varför?
        //Värdetyperna i första metoden läggs på stacken och blir nya instanser
        //Referenstyperna i andra exemplet skapar bara en till pointer till samma objekt och minnesadress 
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method until the user inputs something to exit to main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting \n(+, -, 0) of your choice"
                    + "\n+ listitem. Add to list"
                    + "\n- listitem. Remove from list"
                    + "\nc. Get list count and capacity"
                    + "\n0. Exit the application");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(input.Substring(2));
                        break;
                    case '-':
                        theList.Remove(input.Substring(2));
                        break;
                    case 'c':
                        Console.WriteLine($"Current count in the list: {theList.Count}");
                        Console.WriteLine($"Current capacity in the list: {theList.Capacity}\r\n");
                        break;
                    case '0':
                        Console.WriteLine("Ending application");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }

            //1.Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar.
            //2.När ökar listans kapacitet ? (Alltså den underliggande arrayens storlek)
            //Varje gång något läggs till 
            //3.Med hur mycket ökar kapaciteten?
            //Den ökar med fyra steg åt gången tills dessa 4 fyllts upp
            //4.Varför ökar inte listans kapacitet i samma takt som element läggs till ?
            //Vet ej, den gör någon form av omallokering
            //5.Minskar kapaciteten när element tas bort ur listan?
            //nej
            //6.När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
            //När det är många värden som ska försvinna eftersom stacken har ingen garbage collector, det är bara heapen som har.
}

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            /*Simulera följande kö på papper:
                a. ICA öppnar och kön till kassan är tom
                b. Kalle ställer sig i kön
                        Enqueue("Kalle");
                c. Greta ställer sig i kön
                        Enqueue("Greta");
                d. Kalle blir expedierad och lämnar kön
                        Dequeue("Kalle");
                e. Stina ställer sig i kön
                        Enqueue("Stina");
                f. Greta blir expedierad och lämnar kön
                        Dequeue("Greta");
                g. Olle ställer sig i kön
                        Enqueue("Olle");
                h. …
            */
            Queue<string> theQueue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting \n(+, -, 0) of your choice"
                    + "\n+ queueitem. Add to queue"
                    + "\n-. Remove from queue"
                    + "\nc. Get queue count and peek beginning of the queue"
                    + "\n0. Exit the application");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(input.Substring(2));
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case 'c':
                        Console.WriteLine($"Current count in the queue: {theQueue.Count}");
                        Console.WriteLine($"Current beginning of the queue: {theQueue.Peek()}\r\n");
                        break;
                    case '0':
                        Console.WriteLine("Ending application");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menu.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            /*Simulera följande kö på papper:
                a. ICA öppnar och kön till kassan är tom
                b. Kalle ställer sig i kön
                        Push Kalle;
                c. Greta ställer sig i kön
                        Push Greta -> poppar bort Kalle;
                d. Kalle blir expedierad och lämnar kön
                        Nej eftersom Greta nu står först...
                e. Stina ställer sig i kön
                        Stina hamnar först i kön
                f. Greta blir expedierad och lämnar kön
                        Nej eftersom Stina nu står först...
                g. Olle ställer sig i kön
                        osv
                h. …
            */
            Stack<string> theStack = new Stack<string>();
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting \n(+, -, 0) of your choice"
                    + "\n+ stackitem. Push to stack"
                    + "\n-. Pop from stack"
                    + "\nc. Get stack count and peek beginning of the stack"
                    + "\n0. Exit the application");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theStack.Push(input.Substring(2));
                        break;
                    case '-':
                        theStack.Pop();
                        break;
                    case 'c':
                        Console.WriteLine($"Current count in the stack: {theStack.Count}");
                        Console.WriteLine($"Current beginning of the stack: {theStack.Peek()}\r\n");
                        break;
                    case '0':
                        Console.WriteLine("Ending application");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
            */
            //1.Skapa med hjälp av er nya kunskap funktionalitet för att kontrollera en välformad
            //sträng på papper.Du ska använda dig av någon eller några av de datastrukturer vi
            //precis gått igenom.Vilken datastruktur använder du?

            //Jag använder en stack. Med den kan pusha vänsterparenteser ")" om det finns en högerparentes innan "(" och
            //för varje gång det finns en högerparentes innan så cancelerar den vänsterparentesen. Om det finns någon höger eller vänsterparentes kvar
            //när vi är klara så har något gått fel och det är en inkorrekt sträng.

            //2.Implementera funktionaliteten i metoden CheckParantheses . Låt programmet läsa
            //in en sträng från användaren och returnera ett svar som reflekterar huruvida
            //strängen är välformad eller ej.
            Stack<char> theCharacterStack = new Stack<char>();
            Console.WriteLine("Please navigate through the menu:"
            + "\n1. Insert a string for inspection"
            + "\n0. Exit the application");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);
            //int leftParenthesis = 0;
            //int rightParenthesis = 0;
            switch (nav)
            {
                case '1':
                    Console.WriteLine("Please insert the string you would like to inspect:");
                    string constrolString = Console.ReadLine();
                    foreach (var item in constrolString.ToCharArray())
                    {
                        if (item.ToString() == "(")
                        {
                            theCharacterStack.Push(item); 
                        }
                        if (item.ToString() == ")")
                        {
                            if (theCharacterStack.Count > 0)
                            {
                                theCharacterStack.Pop(); ;
                            }
                        }
                    }
                    if (theCharacterStack.Count > 0)
                    {
                        Console.WriteLine($"String is incorrect. I still have a {theCharacterStack.Peek()} in the Stack.\r\n");
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty so the string is correct.\r\n");
                    }
                    break;


                case '0':
                    Console.WriteLine("Ending application");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Navigator error. Did you read the instructions carefully?\r\n");
                    break;
            }
        }

    }
}

