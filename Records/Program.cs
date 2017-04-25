//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author: David Mulligan
// Date: 11 - 4 - 17
// ------------------------------------------------------------------------------
// Program Description:
// ``````````````````````````````````````````
//
//
//
//
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Net;

namespace Records
{
    class Program
    {
        public enum MenuOption
        {
            PlayerReport,
            ScoreAnalysis,
            Search,
            Exit
        }

        static void Main(string[] args)
        {
            Web client;

           // Menu();
        }

        static string TextFromWeb()
        {
            string url = "https://drive.google.com/file/d/0B9M4ONs3jnvPUElVbE5IZG1qUzQ/view?usp=sharing";

            var webRequest = WebRequest.Create(url);

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
            }

            var url = "https://www.google.com.vn/s?hl=vi&gs_nf=1&tok=i-GIkt7KnVMbpwUBAkCCdA&cp=5&gs_id=n&xhr=t&q=thanh&pf=p&safe=off&output=search&sclient=psy-ab&oq=&gs_l=&pbx=1&bav=on.2,or.r_gc.r_pw.r_cp.r_qf.&fp=be3c25b6da637b79&biw=1366&bih=362&tch=1&ech=5&psi=8_pDUNWHFsbYrQeF5IDIDg.1346632409892.1";

            var textFromFile = (new WebClient()).DownloadString(url);

        }

        #region Menu Section
  /*      static int Menu()
        {
            string selectionString;
            bool correctInput = false;
            MenuOption selectionOption;

            Console.Clear();

            Console.WriteLine("Please select an option");

            Console.WriteLine();

            Console.WriteLine("1. Player Report");
            Console.WriteLine("2. Score Analysis Report");
            Console.WriteLine("3. Search for a Player");
            Console.WriteLine("4. Exit");

            selectionString = Console.ReadLine();
            correctInput = OptionCheck(selectionString);
            if (correctInput)
            {
                selectionOption = (MenuOption)Enum.Parse(typeof(MenuOption), selectionString); // Converts the End User's String choice into an Enum('MenuOption') format

                MenuSelection(selectionOption);
            }

            else
            {
                selectionOption = (MenuOption)Enum.Parse(typeof(MenuOption), Menu().ToString);
            }

            Console.ReadKey();
         */   return selectionOption;

        }

     #region Menu Child Functions

        static bool OptionCheck(string option)
        {
            bool isGood = false;

            if(option.Equals("1") || option.Equals("2") || option.Equals("3") || option.Equals("4"))
            {
                isGood = true;
            }

            return isGood;
        }

            static void MenuSelection(MenuOption choice)
            {
                Console.WriteLine("You chose {0}", choice);
            }
        #endregion // Child functions

        #endregion
    }
}