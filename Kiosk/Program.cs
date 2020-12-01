using Spectre.Console;
using System.Collections.Generic;
using System;

namespace Kiosk
{
    /// This is just an example program. The design is obviously horrible.
    /// You're expected to pretty much replace all the code during today. 
    ///
    /// It uses Spectre.Console, an easy library for simple console UI apps:
    /// https://spectresystems.github.io/spectre.console/
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> answers = new Dictionary<int, List<string>>();
            string filePath=AnsiConsole.Ask<string>("Please Enter the file path.");
    
            InputReader inputReader = new InputReader(filePath);
            
            //var survey = new Survey();
            //var question = survey.GetQuestion();
            
            var question = inputReader.GetQuestion();


            var prompt = new TextPrompt<string>(question.Question);
            foreach(var a in question.Answers) {
                prompt.AddChoice(a);
            }
            var answer = AnsiConsole.Prompt(prompt);

            List<string> lst_answ = new List<string>();
            lst_answ.Add(question.Question);
            lst_answ.Add(answer);

            answers.Add(1, lst_answ);
            Console.WriteLine(answers);
            if(answer == inputReader.GetCorrectAnswer()) {
                AnsiConsole.Markup("That's [underline green]correct[/]!");
            }
              



            
            // var prompt = new TextPrompt<string>(question.Question);
            // foreach(var a in question.Answers) {
            //     prompt.AddChoice(a);
            // }
            // var answer = AnsiConsole.Prompt(prompt);

            // if(answer == survey.GetCorrectAnswer()) {
            //     AnsiConsole.Markup("That's [underline green]correct[/]!");
            // }
            // else {
            //     AnsiConsole.Markup("That's [underline red]wrong[/]!");
            // }

        }
    }
}
