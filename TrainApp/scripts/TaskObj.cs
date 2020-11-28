using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainApp.scripts
{
   public class TaskObj
    {
        int id_master;
        DateTime deadline;
        string fdeadline;
        string date;
        public string autor;
        string priority;
        string reaction;
        int id_com;
        string comment;

        public TaskObj(string fdeadline1, string date1,string autor1,string priority1)
        {
            fdeadline = fdeadline1;
            date = date1;
            autor = autor1;
            priority = priority1;
        }
    }
}
