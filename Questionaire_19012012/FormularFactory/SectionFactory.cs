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
            string line = sr.ReadLine();
            string[] splitLine = line.Split();
            ISection section = new Section();
            section.Name = splitLine[0];
            for (int i = 0; i < Convert.ToInt16(splitLine[1]); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(sr));
            }

            return section;
        }
    }
}
