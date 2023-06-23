using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name, params string[] allNames)
        {
            //Check if all are Upper
            //else check which ones are upper and store them
            //
            
            string greet = "";

            if (name == null || name == "")
            {
                return "Hello, Chief.";
            }

            

            if (CheckShouting(name, allNames))
            {
                if (allNames.Length == 1)
                {
                    greet = $"Hello, {name} and {allNames[0]}.";
                }
                else if (allNames.Length > 0)
                {
                    greet = $"HELLO, {name}";
                    var nameCount = allNames.Length;

                    foreach (var names in allNames)
                    {
                        if (names != allNames[nameCount - 1])
                        {
                            greet += $", {names}";
                        }
                        else
                        {
                            greet += $", and {names}.";
                        }
                    }
                }
                else
                {
                    greet = $"HELLO, {name}.";
                }

                greet = greet.ToUpper();
            }
            else
            {
                if (allNames.Length == 1)
                {
                    greet = $"Hello, {name} and {allNames[0]}.";
                }
                else if (allNames.Length > 0)
                {
                    var upperList = CheckingUpper(name, allNames);

                    greet = $"Hello, {name}";
                    var nameCount = allNames.Length;

                    if (upperList.Count <= 0)
                    {
                        foreach (var names in allNames)
                        {

                            if (names != allNames[nameCount - 1])
                            {
                                greet += $", {names}";
                            }
                            else
                            {
                                greet += $", and {names}.";
                            }
                        }

                    }
                    else
                    {
                        foreach (var names in allNames)
                        {
                            if (upperList.Contains(names))
                            {
                                continue;
                            }
                            if (names == allNames[nameCount-1])
                            {
                                greet += $", {names}";
                            }

                        }
                        foreach (var names in upperList)
                        {
                            if (names != upperList[upperList.Count - 1])
                            {
                                greet += $", {names}";
                            }
                            else
                            {
                                greet += $", AND {names}.";
                            }
                        }
                    }
                }
                else
                {
                    greet = $"Hello, {name}.";
                }


            }

            return greet;

     
        }

        public List<String> CheckingUpper(string name,string[] allNames)
        {
            var allUpper = new List<String>();
            if(name == name.ToUpper())
            {
                allUpper.Add(name);
            }
            foreach (var names in allNames)
            {
                if(names == names.ToUpper())
                {
                    allUpper.Add(names);
                }
            }

            return allUpper;
        }

        public bool CheckShouting(string? name, params string[] allNames)
        {
            if (name == name.ToUpper())
            {
                foreach (var names in allNames)
                {
                    if (names != names.ToUpper())
                    {
                        break;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;

            }
            else
            {
                return false;
            }
            
        }

       
    }
}