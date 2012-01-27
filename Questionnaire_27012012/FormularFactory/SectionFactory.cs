using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : ISectionaFactory
    {
        public IQuestionFacrory QuestionFactory { get; set; }

        public ISection CreateSection(StringReader sr)
        {
            var readLine = sr.ReadLine();
            string[] splitLine = readLine.Split();
            ISection section = new Section();
            section.Name = splitLine[0];
            for (int i = 0; i < Convert.ToInt16(splitLine[1]); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(readLine));
            }

            return section;
        }
    }
}
