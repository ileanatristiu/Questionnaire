using System;
using Formular;

namespace FormularFactory
{
    public abstract class ChoiceQuestionFactory<T> : IChoiceQuestionFactory
        where T : ChoiceQuestion, new()
    {
        public ChoiceQuestion Create(string line)
        {
            var question = new T();
            string[] split = line.Split();
            for (int i = 1; i <= Convert.ToInt16(split[2]); i++)
            {
                question.Items.Add(new PossibleAnswer { Name = split[2 + i] });
            }

            return question;
        }
    }
}