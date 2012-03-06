using System;
using Formular;

namespace FormularFactory
{
    public abstract class ChoiceQuestionFactory<T> : IChoiceQuestion
        where T : ChoiceQuestion, new()
    {
        public ChoiceQuestion Create(string input)
        {
            var strings = input.Split();
            var question = new T { Name = strings[1] };
            for (int i = 1; i <= Convert.ToInt16(strings[2]); i++)
            {
                question.Items.Add(new PossibleAnswer { Name = strings[i + 2] });
            }

            
            return question;
        }
    }
}