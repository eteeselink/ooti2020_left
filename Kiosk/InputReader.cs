
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

using Spectre.Console;


namespace Kiosk{
    public class InputReader{

        // private Collection<Input> questions = new Collection<Input>();

        public InputReader(string path){
            string rawText = System.IO.File.ReadAllText(path);
            string jsonString = File.ReadAllText(path);

            AnsiConsole.Markup(jsonString);
            // JsonTextReader reader = new JsonTextReader(new StringReader (jsonString));

            // while(reader.Read()){
            //     AnsiConsole.Markup(reader.TokenType.ToString());
                //populate the content of the file
                //stil working on it
            // }
    }

    public struct MultipleChoiceQuestion {
        public string Question { get; init; }
        public string[] Answers { get; init; }
    }

    public MultipleChoiceQuestion GetQuestion() {
            return new MultipleChoiceQuestion {
                Question = "What's your favorite color?",
                Answers = new[] { "Red", "Blue", "Green"}
            };
        }

        public string GetCorrectAnswer() {
            return "Blue";
        }

    }

}