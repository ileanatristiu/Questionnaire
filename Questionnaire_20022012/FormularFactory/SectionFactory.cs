using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : ISectionFactory
    {
        public IQuestionFactory QuestionFactory { get; set; }

        public Base Create(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            var section = new Section { Name = line[0] };
            CreateSection(section, line[1]);

            return section;
        }

        private void CreateSection(Section section, string number)
        {
            for (int i = 0; i < Convert.ToInt16(number); i++)
            {
                section.Questions.Add(QuestionFactory.CreateQuestion(input));
            }
        }
    }

    public interface ISectionFactory : IBaseFactory
    {
    }
}