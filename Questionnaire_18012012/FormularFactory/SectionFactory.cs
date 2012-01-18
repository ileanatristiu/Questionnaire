using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : ISectionFactory
    {
    
        public IQuestionFactory Question { get; set; }

        public ISection CreateSection(StringReader sr)
        {
            ISection section = new Section();
            string line = sr.ReadLine();
            string[] splitLine = line.Split();
            section.Name = splitLine[0];
            for (int i = 0; i < Convert.ToInt16(splitLine[1]); i++)
            {
                section.Questions.Add(Question.CreateQuestion(line));
            }

            return section;
        }
    }
}
