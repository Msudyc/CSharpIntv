/* Question 8.9
 
Explain the data structures and algorithms that you would use to design an in-memory file system. 
Illustrate with an example in code where possible. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q09
    {
        public abstract class Entry
        {
            protected Directory Parent { get; set; }
            protected string Name { get; set; }
            protected long Created { get; set; }
            protected long LastUpdated { get; set; }
            protected long LastAccessed { get; set; }

            public bool Delete()
            {
                throw new NotImplementedException();
            }

            public string GetFullPath()
            {
                throw new NotImplementedException();
            }

            public abstract int Size();            
        }

        public class File : Entry
        {
            private string Content { get; set; }
            private int size = 0;

            public string GetContent()
            {
                return this.Content;
            }

            public void SetContent(string content)
            {
                this.Content = content;
            }

            public override int Size()
            {
                return this.size;
            }
        }

        public class Directory : Entry
        {
            protected List<Entry> contents = new List<Entry>();

            public override int Size()
            {
                int size = 0;
                foreach (Entry e in contents)
                    size += e.Size();
                return size;
            }

            public void AddEntry(Entry e)
            {
                this.contents.Add(e);
            }

            public bool DeleteEntry(Entry e)
            {
                return this.contents.Remove(e);
            }
        }
    }
}
