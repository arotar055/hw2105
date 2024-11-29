namespace Academy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                AcademicGroup group = new AcademicGroup("Group A");
                group.AddStudent(new Student("Ivanov", 22, "Computer Science"));
                group.AddStudent(new Student("Petrov", 21, "Mathematics"));

                JsonSerialization.SaveToJson(group, "group.json");
                AcademicGroup loadedGroupJson = JsonSerialization.LoadFromJson("group.json");
                Console.WriteLine("Loaded from JSON:");
                Console.WriteLine(loadedGroupJson.GroupName);

                XmlSerialization.SaveToXml(group, "group.xml");
                AcademicGroup loadedGroupXml = XmlSerialization.LoadFromXml("group.xml");
                Console.WriteLine("Loaded from XML:");
                Console.WriteLine(loadedGroupXml.GroupName);
            }
        }
    }
    }


