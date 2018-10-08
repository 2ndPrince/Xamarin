using System;
using System.Collections.Generic;
using System.Text;

namespace YS1.Models
{
    class Stages
    {
        public int Cur_Stage { get; set; }                
        public string[] Mission_String { get; set; }

        public string User_String { get; set; }

        public Stages(int stage)
        {
            this.Cur_Stage = stage;
            Random random = new Random();
            string[] temp = new string[stage];
            for (int i = 0; i < stage; i++)
            {
                temp[i] = random.Next(1, 7).ToString();
            }
            Mission_String = temp;
        }       

        public bool CheckAnswer()
        {
            string answer = String.Join("", Mission_String);
            
            if (answer == User_String)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
