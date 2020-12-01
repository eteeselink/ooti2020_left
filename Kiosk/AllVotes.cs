// using Spectre.Console;
// using System.Collections.Generic;

// namespace Kiosk
// {
//     class AllVotesSubmit
//     {
//         static void Main(string[] args)
//         {
//             Dictionary<int, string> raw_answers = new Dictionary<int, string>();

//             var survey = new Survey();
//             var question = survey.GetQuestion();

//             var prompt = new TextPrompt<string>(question.Question);
//             foreach(var a in question.Answers) {
//                 prompt.AddChoice(a);
//             }
//             var answer = AnsiConsole.Prompt(prompt);

//             raw_answers.Add(1, answer);

            
    
//         }
//     }
// }