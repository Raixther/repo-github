using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QFM
{
    class Command
    {
        private string command_type;

        private string target;

        private string second_target;

        private string[] ParseInput(string input)
        {

         string separator = @"\s+";

         string[] split_input =   Regex.Split(input, separator);

         return split_input;
        }
      public  Command (string input)
         {
          string[] parsed_input = ParseInput(input);

            command_type = parsed_input[0];

            if (parsed_input.Length == 3)
            {
                target = parsed_input[1];

                second_target = parsed_input[2];
            }
            else if(parsed_input.Length==2)
            {
                target = parsed_input[1];
            }
          
        }

        public  void  Exec()
        {
            switch (command_type)
            {        
                case "open":

                    Browser.Open(target);

                     break;

                case "deletedir":

                    Manager.DeleteDirectory(target);

                    break;
          
                case "deletef":

                    Manager.DeleteFile(target);

                    break;

                case "copydir":

                    Manager.DirectoryCopy(target, second_target);

                        break;

                case "copyf":

                    Manager.FileCopy(target, second_target);

                    break;

            
                case "return":

                    Browser.MoveBack();

                    break;



               


            }
        }

    }
}

