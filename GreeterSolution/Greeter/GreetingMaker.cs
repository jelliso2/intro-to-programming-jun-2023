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

        public string Greet( params string?[]? allNames)
        {
            string greet = "Hello";

            if (allNames == null)
            {
                return "Hello, Chief.";
            }

            var isUppercase = allNames.All(names => names.ToUpper() == names);
            var someUpper = !isUppercase && allNames.Any(n => n.ToUpperInvariant() == n);

            if (isUppercase)
            {
                foreach( var name in allNames )
                {
                    if (allNames.Length > 1)
                    {
                        if (name != allNames[allNames.Count() - 1])
                        {
                            greet += $", {name} ";
                        }
                        else
                        {
                            greet += $"and {name}";
                        }
                    }
                    else
                    {
                        greet += $", {name}.";
                    }
                    
                }

                return greet.ToUpper();
            }
            else if(someUpper)
            {
                var upperNames = allNames.Where(names => names.ToUpper() == names).ToList();
                var lowerNames = allNames.Except(upperNames);
                
                    foreach (var name in lowerNames)
                    {
                        greet += $", {name}";
                    }
                    greet += " AND";
                    foreach (var name in upperNames)
                    {
                        greet += $" {name}.";
                    }
                return greet;
            }
            else
            {
                if (allNames.Length > 1)
                {
                    foreach (var name in allNames)
                    {
                        if (name != allNames[allNames.Length - 1])
                        {
                            greet += $", {name}";
                        }
                        else
                        {
                            greet += $" and {name}.";
                        }

                    }
                }
                else
                {
                    greet = $"Hello, {allNames[0]}.";
                }


                return greet;
                
            }

            #region old code

            //if (CheckShouting(allNames))
            //{
            //    if (allNames.Length == 1)
            //    {
            //        greet = $"Hello, {name} and {allNames[0]}.";
            //    }
            //    else if (allNames.Length > 0)
            //    {
            //        greet = $"HELLO, {name}";
            //        var nameCount = allNames.Length;

            //        foreach (var names in allNames)
            //        {
            //            if (names != allNames[nameCount - 1])
            //            {
            //                greet += $", {names}";
            //            }
            //            else
            //            {
            //                greet += $", and {names}.";
            //            }
            //        }
            //    }
            //    else
            //    {
            //        greet = $"HELLO, {name}.";
            //    }

            //    greet = greet.ToUpper();
            //}
            //else
            //{
            //    if (allNames.Length == 1)
            //    {
            //        greet = $"Hello, {name} and {allNames[0]}.";
            //    }
            //    else if (allNames.Length > 0)
            //    {
            //        var upperList = CheckingUpper(name, allNames);

            //        greet = $"Hello, {name}";
            //        var nameCount = allNames.Length;

            //        if (upperList.Count <= 0)
            //        {
            //            foreach (var names in allNames)
            //            {

            //                if (names != allNames[nameCount - 1])
            //                {
            //                    greet += $", {names}";
            //                }
            //                else
            //                {
            //                    greet += $", and {names}.";
            //                }
            //            }

            //        }
            //        else
            //        {
            //            foreach (var names in allNames)
            //            {
            //                if (upperList.Contains(names))
            //                {
            //                    continue;
            //                }
            //                if (names == allNames[nameCount-1])
            //                {
            //                    greet += $", {names}";
            //                }

            //            }
            //            foreach (var names in upperList)
            //            {
            //                if (names != upperList[upperList.Count - 1])
            //                {
            //                    greet += $", {names}";
            //                }
            //                else
            //                {
            //                    greet += $", AND {names}.";
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        greet = $"Hello, {name}.";
            //    }


            //}

            //return greet;
            #endregion


        }



        public List<String> CheckingUpper(string[] allNames)
        {
            var allUpper = new List<String>();
            
            foreach (var names in allNames)
            {
                if(names == names.ToUpper())
                {
                    allUpper.Add(names);
                }
            }

            return allUpper;
        }

        public bool CheckShouting(params string[] allNames)
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
            
        }

       
    }
