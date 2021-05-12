using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_V2
{
    public class WorkWithFile
    {
        private readonly string path;

        public WorkWithFile(string path)
        {
            this.path = path;
        }
        public int QntLine()
        {
            int index = 0;
            int x = -1;
            int qnt = -1;

            string text = File.ReadAllText(path);

            while (index != -1)
            {
                index = text.IndexOf(" ", x + 1);
                x = index;
                qnt++;
            }
            return qnt;
        }

        public TrafficPolicePost[] WriteToFile()
        {
            List<TrafficPolicePost> postsList = new List<TrafficPolicePost>();
            string text = "";
            text = File.ReadAllText(path);
            string[] predls = text.Split(' ').Where(x => x != null && x.Length > 0).ToArray();

            for (int i = 0; i < predls.Length; i++)
                postsList.Add(new TrafficPolicePost(predls[i]));
            
            return postsList.ToArray();
        }
    }
}
