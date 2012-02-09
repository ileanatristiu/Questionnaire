using System;
using System.IO;
using Formular;
using Ninject;

namespace FormularFactory
{
    public class SectionFactory : ISectionFactory
    {
        [Inject]
        public IQuestionFactory QuestionFactory { get; set; }

        public ISection createSection(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            ISection section = new Section();
            section.Name = line[0];
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(input));
            }

            return section;
        }
    }
}