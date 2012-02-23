using System.IO;
using System.Text.RegularExpressions;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public override IBaseFactory ChildFactory { get; set; }

        public override Base Create(StringReader input)
        {
            // FT Numele
            var readLine = input.ReadLine();
            var match = Regex.Match(readLine, @"(\w*)\s(\w*)");

            return new FreeTextQuestion { Name = match.Groups[2].Value };
        }
    }
}