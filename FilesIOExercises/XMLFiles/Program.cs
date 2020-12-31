using System;
using System.Xml;

namespace XMLFiles
{
    class Program
    {

        struct User

        {
            public string FirstName;
            public string LastName;
            public string Profession;
            public Address Address;
        }

        struct Address

        {
            public string Street;
            public string City;
            public string State;
            public string Zip;
        }

        static void Main(string[] args)
        {
            /*
             * 1. Create a text file anywhere on your computer with the following contents:
             * 2. Read this XML file into memory using any function in the System.XML namespace. Use structs to store the information for each user, and use an array to store all the users. Print out the user information to ensure your code works.
             * 3. Make some changes to the users in memory (for example, change the last name of the first user or add a city to the second user’s address)
             * 4. Write these new users out to xml using any function in the System.XML namespace. Write to a different file, do not overwrite the existing one. Open the file in a text editor to make sure your changes were saved correctly.
             */

            string xmlPath = @"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/XMLFiles/xmlFile.txt";

            // create the xml document
            var xmlDocMy = new XmlDocument();
            xmlDocMy.Load(xmlPath);

            // get all the user nodes
            var userNodes = xmlDocMy.SelectNodes("//User");

            // create an array to hold all the users
            var users = new User[userNodes.Count];

            // parse each user into a user object
            int userIndex = 0;

            foreach (XmlElement element in userNodes)

            {
                // parse the user fields

                var user = new User();

                user.FirstName = element.GetAttribute("FirstName");

                if (element.HasAttribute("LastName"))
                    user.LastName = element.GetAttribute("LastName");

                user.Profession = element.GetAttribute("Profession");

                // parse the address fields

                var addressElement = (XmlElement)element.FirstChild;
                var address = new Address();

                address.Street = addressElement.GetAttribute("Street");
                address.City = addressElement.GetAttribute("City");
                address.State = addressElement.GetAttribute("State");
                address.Zip = addressElement.GetAttribute("Zip");

                // assign the address to the current user

                user.Address = address;

                // add the current user to the array

                users[userIndex] = user;
                Console.WriteLine(users[userIndex].Address.Street);

                userIndex++;


            }

            users[1].Address.City = "Gothem city";
            Console.WriteLine(users[1].Address.City);
            
            // Create a new file in C:\\ dir  
            XmlTextWriter textWriter = new XmlTextWriter(@"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/XMLFiles/xmlFile2.txt", null );
            textWriter.WriteStartDocument();
            textWriter.WriteComment("new XML file");

            textWriter.WriteStartElement("Users");

            foreach(var user in users)
            {
                textWriter.WriteStartElement("User");
                textWriter.WriteAttributeString("FirstName", user.FirstName);
               
                textWriter.WriteAttributeString("LastName", user.LastName);
                textWriter.WriteAttributeString("Profession", user.FirstName);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Address");
                textWriter.WriteAttributeString("Street", user.Address.Street);
                textWriter.WriteAttributeString("City", user.Address.City);
                textWriter.WriteAttributeString("State", user.Address.State);
                textWriter.WriteAttributeString("Zip", user.Address.Zip);
                textWriter.WriteEndElement();


            }

            textWriter.WriteEndDocument();
            textWriter.Close();


            //second way of writing in xml documents

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Users");
            xmlDoc.AppendChild(rootNode);

            foreach (var user in users)
            {
                XmlNode userNode = xmlDoc.CreateElement("User");
                XmlAttribute firstName = xmlDoc.CreateAttribute("FirstName");
                firstName.Value = user.FirstName;
                userNode.Attributes.Append(firstName);
                rootNode.AppendChild(userNode);
            
                XmlAttribute lastName = xmlDoc.CreateAttribute("LastName");
                lastName.Value = user.LastName;
                userNode.Attributes.Append(lastName);
                //rootNode.AppendChild(userNode);

                XmlAttribute profession = xmlDoc.CreateAttribute("Profession");
                profession.Value = user.Profession;
                userNode.Attributes.Append(profession);
                //rootNode.AppendChild(userNode);

                XmlNode address = xmlDoc.CreateElement("Address");
                userNode.AppendChild(address);

                XmlAttribute street = xmlDoc.CreateAttribute("Street");
                street.Value = user.Address.Street;
                address.Attributes.Append(street);

                XmlAttribute city = xmlDoc.CreateAttribute("City");
                city.Value = user.Address.City;
                address.Attributes.Append(city);

                if (user.Address.State != "")
                {
                    XmlAttribute state = xmlDoc.CreateAttribute("State");
                    state.Value = user.Address.State;
                    address.Attributes.Append(state);
                }
                if (user.Address.Zip != "")
                {
                    XmlAttribute zip = xmlDoc.CreateAttribute("Zip");
                    zip.Value = user.Address.Zip;
                    address.Attributes.Append(zip);

                }
            }
            xmlDoc.Save(@"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/XMLFiles/xmlFile9.txt");



        }
    }
}
