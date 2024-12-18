namespace _09OOPNotepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notepad notepad = new Notepad(null);
            SpellCheckFactory factory = new SpellCheckFactory();
            ISpellChecker spellChecker = factory.getSomeSpellChecker("sp");
            Notepad notepad2 = new Notepad(spellChecker);
            notepad2.spellcheck();

            //Notepad notepad3 = new Notepad("Hindi");
            HindiSpellChecker hindiSpellChecker = new HindiSpellChecker();
            Notepad notepad3 = new Notepad(hindiSpellChecker);
            notepad3.spellcheck();


        }
        public interface ISpellChecker
        {
            void DoSpellCheck();
        }

        public class Notepad
        {
            ISpellChecker _checker;
            SpellCheckFactory checkFactory = new SpellCheckFactory();
            public Notepad (ISpellChecker checker)
            {
                if(checker == null)
                {
                    _checker = checkFactory.getSomeSpellChecker("en");
                }
                else
                {
                    _checker = checker;
                }
            }
            public void spellcheck()
            {
                _checker.DoSpellCheck();
            }

            public void cut()
            {

            }
            public void paste()
            {

            }

        }
        public class SpellCheckFactory
        {
            public ISpellChecker getSomeSpellChecker(string lang)
            {
                ISpellChecker _checker = null;
                switch (lang)
                {
                    case "en":
                        _checker = new EnglishSpellChecker();
                        break;
                    case "gr":
                        _checker = new GermanSpellChecker();
                        break;
                    case "sp":
                        _checker = new SpanishSpellChecker();
                        break;
                    default:
                        _checker = new EnglishSpellChecker();
                        break;
                }
                return _checker;
            }
        }
        public class EnglishSpellChecker :ISpellChecker
        {
            public void DoSpellCheck()
            {
                Console.WriteLine("English spell check done");
            }
           
        }
        public class HindiSpellChecker :ISpellChecker
        {
            public void DoSpellCheck()
            {
                Console.WriteLine("HINDI spell check done");
            }
        }
        public class GermanSpellChecker : ISpellChecker
        {
            public void DoSpellCheck()
            {
                Console.WriteLine("German spell check done"); 
            }
        }
        public class SpanishSpellChecker : ISpellChecker
        {
            public void DoSpellCheck()
            {
                Console.WriteLine("Spanish spell check done");
            }
        }

    }
}
