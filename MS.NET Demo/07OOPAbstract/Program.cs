namespace OOPAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PDF obj = new PDF();
            //obj.GenerateReport();

            while (true)
            {
                Console.WriteLine("1.PDF 2.DOCX 3.XML 4.TXT");
                int ch = Convert.ToInt32(Console.ReadLine());
                ReportFactory reportFactory = new ReportFactory();
                IReport somereport = reportFactory.getSomeChoice(ch);
                somereport.GenerateReport();
                Console.WriteLine("Do you want to continue ? (y/n)");
                String ans = Console.ReadLine();
                if(ans == "n")
                {
                    break;
                }

            }

        }
        public interface IReport
        {
            void GenerateReport();
        }

        public abstract class Report :IReport
        {
            protected abstract void Parse();
            protected abstract void Validate();
            protected abstract void Save();
            public virtual void GenerateReport()
            {
                Parse();
                Validate();
                Save();
            }
        }

        public abstract class SpecialReport : Report
        {
            protected abstract void Revalidate();
            public override void GenerateReport()
            {
                Parse();
                Validate();
                Revalidate();
                Save();
            }
        }

        public class ReportFactory
        {
            public Report getSomeChoice(int ch)
            {
                Report report = null;
                switch (ch)
                {
                    case 1:
                        report = new PDF();
                        break;
                    case 2:
                        report = new Docx();
                        break;
                    case 3:
                        report = new XML();
                        break;
                    case 4:
                        report = new TXT();
                        break;
                    default:
                        report = null;
                        break;
                }
                return report;

            }
        }
        public class PDF :Report
        {
            protected override void Parse()
            {
                Console.WriteLine("in parse method of pdf");
            }
            protected override void Validate()
            {
                Console.WriteLine("in validate method of pdf");
            }
            protected override void Save()
            {
                Console.WriteLine("pdf is saved");
            }
        }
        public class Docx :Report
        {
            protected override void Parse()
            {
                Console.WriteLine("in parse method of docx");
            }
            protected override void Validate()
            {
                Console.WriteLine("in validate method of docx");
            }
            protected override void Save()
            {
                Console.WriteLine("docx is saved");
            }
        }
        public class TXT : Report
        {
            protected override void Parse()
            {
                Console.WriteLine("in parse method of txt");
            }
            protected override void Validate()
            {
                Console.WriteLine("in validate method of txt");
            }
            protected override void Save()
            {
                Console.WriteLine("txt is saved");
            }
        }

        public class XML : SpecialReport
        {
            protected override void Parse()
            {
                Console.WriteLine("in parse method of xml");
            }
            protected override void Validate()
            {
                Console.WriteLine("in validate method of xml");
            }
            protected override void Revalidate()
            {
                Console.WriteLine("in revalidate method of xml");
            }
            protected override void Save()
            {
                Console.WriteLine("xml is saved");
            }
        }
    }
}
