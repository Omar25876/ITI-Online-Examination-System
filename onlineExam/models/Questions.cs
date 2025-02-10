using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExam
{
    internal class Questions
    {
        private int qID;
        private int grade;
        private int modelAswer;
        private string question;
        public Questions(int id,int g,int ans ,string q) 
        {
            qID = id;
            grade = g;
            modelAswer = ans;
            question = q;
        }
        public int QID
        {
            get { return qID; }
            set { qID = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public int Grade
        {
            get { return grade; }
        }
        
        public int ModelAswer
        {
            get { return modelAswer; }
        }

    }
}
