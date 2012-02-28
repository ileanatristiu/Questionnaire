using System;
using Formular;

namespace FormulatFactory
{
    public class SingleChoiceQuestionFactory : BaseFactory<SingleChoiceQuestion>, ISingleChoiceQuestionFactory
    {
        public Base Create(string[] line)
        {
            var singleChoiceQuestion = new SingleChoiceQuestion();

            for (int i = 1; i <= Convert.ToInt16(line[2]); i++)
            {
                singleChoiceQuestion.Items.Add(new PossibleAnswer { Name = line[2 + i] });
            }

            return singleChoiceQuestion;
        }
    }
}