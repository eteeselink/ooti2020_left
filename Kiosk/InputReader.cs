using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;


namespace Kiosk{
    public class InputReader{

        private Collection<Input> questions = new Collection<Input>();

        public InputReader(string path){
            // string rawText = System.IO.File.ReadAllText(path);
            string jsonString = File.ReadAllText(path);
            JsonTextReader reader = new JsonTextReader(new StringReader (jsonString));

            while(reader.read()){
                reader.TokenType;
                //populate the content of the file
                //stil working on it
            }
    }
    }

}