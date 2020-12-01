
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kiosk{
    public class Question {
    public string question;
    public Collection<string> answers = new Collection<string>();
    public string rightAnswer;

    public Question(string q, Collection<string> a){
        question = q;
        answers = a;
    }

    public string getQuestion(){
        return question;
    }
    
    public Collection<string> getAnswers(){
        return answers;
    }

    public void setRightAnswer(string rightAnswer){
        this.rightAnswer = rightAnswer;
    }
    

}
}

