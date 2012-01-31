using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : ISectionFactory
    {
        public IQuestionFactory QuestionFactory { get; set; }

        public ISection CreateSection(StringReader sr)
        {
            string[] line = sr.ReadLine().Split();
            ISection section = new Section();
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(sr));
            }
            section.Name = line[0];

            return section;
        }
    }
}
