using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierSuarezHuacon24.models
{
    class QuestionModel
    {

        private String question;
        private String[] answers;
        private int value;

        public QuestionModel(string question, string[] answers, int value)
        {
            this.question = question;
            this.answers = answers;
            this.value = value;
        }

        public int Value { get => value; set => this.value = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public string Question { get => question; set => question = value; }
    }
}
