using _27DBAttributeLib;
using System.Reflection;

namespace _25ReflectionCreateTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assembly = @"D:\Shreyas\MS.NET\MS.NET Demo\26EmpLib\bin\Debug\net6.0\26EmpLib.dll";
            Assembly asm = Assembly.LoadFrom(assembly);
            Type[] types = asm.GetTypes();

            string MySQL = "create table";
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                if (type.IsPublic)
                {
                    Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                    for (int j = 0; j < allAttributes.Length; j++)
                    {
                        Attribute attributeOfClasses = allAttributes[j];
                        if (attributeOfClasses is Table)
                        {
                            Table currentTable = attributeOfClasses as Table;

                            MySQL += currentTable.TableName + " ( ";

                            Console.WriteLine(MySQL);
                        }
                    }
                    PropertyInfo[] allProperties = type.GetProperties();
                    for (int j = 0; j < allProperties.Length; j++)
                    { 
                        PropertyInfo propertyInfo = allProperties[j];
                        Attribute[] attributeOfProperties = propertyInfo.GetCustomAttributes().ToArray();

                        for (int k = 0; k < attributeOfProperties.Length; k++)
                        {
                            Attribute propAttribute = attributeOfProperties[k];

                            if (propAttribute is Column)
                            {
                                Column column = propAttribute as Column;
                                MySQL = MySQL + column.ColumnName + " " + column.ColumnType + ",";
                                Console.WriteLine(MySQL);
                            }

                        }
                    }
                }
            }

            MySQL = MySQL.TrimEnd(',') + ");";
            Console.WriteLine(MySQL);

            string filepath = @"D:\Shreyas\MS.NET\MS.NET Demo\25ReflectionCreateTable\MySqlQuery\script.sql";
            using (StreamWriter writer = File.AppendText(filepath))
            {
                writer.WriteLine(MySQL);
                Console.WriteLine("MySQL script writing task done !");
            }
        }
    }
}

          
