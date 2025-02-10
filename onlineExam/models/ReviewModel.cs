using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExam
{
    public class ReviewModel
    {
        int qID;
        string question;
        int answer;
        int rAnswer;
        
        public ReviewModel(int qid,string q, int ans,int rAns)
        {
            qID = qid;
            question = q;
            answer = ans;
            rAnswer = rAns;
          
        }

        public int QID
        {
            get { return qID; }
        }
        public string Question
        {
            get { return question; }
        }
        public int Answer
        {
            get { return answer; }
        }
        public int RAnswer
        {
            get { return rAnswer; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            ReviewModel r = (ReviewModel)obj;
            return  question == r.question && answer == r.answer && rAnswer == r.rAnswer;
        }

        public override int GetHashCode()
        {
            int hashCode = 17;
            hashCode = hashCode * 23 + qID.GetHashCode();
            hashCode = hashCode * 23 + question.GetHashCode();
            hashCode = hashCode * 23 + answer.GetHashCode();
            hashCode = hashCode * 23 + rAnswer.GetHashCode();
        

            return hashCode;
        }

        public override string ToString()
        {
            return $"Question : {Question}\nAnswer : {answer} Right Answer : {rAnswer}\n";
        }
    }
}
