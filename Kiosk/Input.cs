
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kiosk{
    public class Input {
    private string question;
    private Collection<string> answers = new Collection<string>();

    public string getQuestion(){
        return question;
    }
    
    public Collection<string> getAnswers(){
        return answers;
    }
    
    public void setQuestion(string question){
        this.question=question;
    }
    public void addAnswer(string answer){
        answers.Add(answer);
    }    
}
}

