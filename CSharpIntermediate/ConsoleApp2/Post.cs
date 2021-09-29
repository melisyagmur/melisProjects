using System;

namespace StackOverFlow
{
    public class Post 
    {
        string _title;
        string _description;
        DateTime _date;
        int _vote;

        public string Title { get { return _title; }  set { _title = value; } }
        public string Desription { get { return _description; }  set { _description= value; } }
        public DateTime Date { get { return _date; }  set { _date = value; } }
        public int Vote { get {return _vote; }  private set { _vote = value; } }

        public Post()
        {
            Vote = 0;
        }

        public void UpVote()
        {
            Vote++;
        }
        public void DownVote()
        {
            Vote--;
        }
    }
}
