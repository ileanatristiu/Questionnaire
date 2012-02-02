using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : ISectionFactory
    {
        public IQuestionFactory QuestionFactory { get; set; }

        public ISection CreateSection(StringReader input)
        {
            ISection section = new Section();
            string[] line = input.ReadLine().Split();
            section.Name = line[0];
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(input));
            }

            return section;
        }
    }
}
