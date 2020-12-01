
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

using Spectre.Console;


namespace Kiosk{
    public class InputReader{

        private Collection<Question> questions;
         JsonTextReader reader;

        public InputReader(string path){
            string rawText = System.IO.File.ReadAllText(path);
            reader = new JsonTextReader(new StringReader(rawText));
            questions =  new Collection<Question>();
    }

    public void readFile(){
        // while(reader.Read()){
            
        //     questions.Add(new Question(reader.TokenType.ToString, ));
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