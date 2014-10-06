using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class HomeworkEntry
    {

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Owner { get; private set; }
        public string Subject { get; private set; }
        public DateTime Expires { get; private set; }
        public string Content { get; private set; }

        public HomeworkEntry(int id, string title, string owner, string subject, DateTime expires, string content)
        {
            this.Id = id;
            this.Title = title;
            this.Owner = owner;
            this.Expires = expires;
            this.Content = content;
            this.Subject = subject;
        }

    }
}
