using System;
using Formular;

namespace FormularFactory
{
    public class SingleChoiceQuestionFactory : ChoiceQuestionFactory
    {
        public override IChoiceQuestion CreateChoiceQuestion(string input)
        {
            SingleChoiceQuestion singleChoiceQuestion = new SingleChoiceQuestion();
            string[] splitInput = input.Split();
            for (int i = 1; i <= Convert.ToInt16(splitInput[2]); i++)
            {
                singleChoiceQuestion.PossibleAnswers.Add(splitInput[i + 2]);
            }

            return singleChoiceQuestion;
        }
    }
}
