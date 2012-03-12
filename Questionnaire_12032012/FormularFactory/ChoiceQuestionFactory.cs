using System;
using Formular;

namespace FormularFactory
{
    public class ChoiceQuestionFactory<T> : IChoiceQuesitonFactory
        where T : ChoiceQuestion, new()
    {
        public Base Create(string input)
        {
            string[] line = input.Split();
            var question = new T { Name = line[1] };
            for (int i = 1; i <= Convert.ToInt16(line[2]); i++)
            {
                question.Items.Add(new PossibleAnswer { Name = line[i + 2] });
            }

            return question;
        }
    }
}