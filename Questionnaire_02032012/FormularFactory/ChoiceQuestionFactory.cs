using System;
using Formular;

namespace FormularFactory
{
    public abstract class ChoiceQuestionFactory<T> : IChoiceQuestionFactory
        where T : ChoiceQuestion, new()
    {
        public ChoiceQuestion Create(string input)
        {
            var question = new T();
            string[] line = input.Split();
            for (int i = 1; i <= Convert.ToInt16(line[2]); i++)
            {
                question.Items.Add(new PossibleAnswer { Name = line[i + 2] });
            }

            return question;
        }
    }
}