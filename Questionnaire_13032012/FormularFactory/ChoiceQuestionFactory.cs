using System;
using Formular;

namespace FormularFactory
{
    public abstract class ChoiceQuestionFactory<T> : IChoiceQuestionFactory
        where T : ChoiceQuestion, new()
    {
        public ChoiceQuestion CreateChoiceQuestion(string input)
        {
            string[] strings = input.Split();
            var choiceQuestion = new T { Name = strings[1] };
            for (int i = 1; i <= Convert.ToInt16(strings[2]); i++)
            {
                choiceQuestion.Items.Add(new PossibleAnswer { Name = strings[2 + i] });
            }

            return choiceQuestion;
        }
    }
}