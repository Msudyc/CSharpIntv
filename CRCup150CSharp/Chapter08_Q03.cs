/* Question 8.3
 
Design a musical jukebox using OOP. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q03
    {
        public class Jukebox
        {
            private CDPlayer player;
            private User user;
            private List<CD> cdCollection;
            private SongSelector ts;

            public Jukebox(
                CDPlayer player, 
                User user, 
                SongSelector s, 
                List<CD> cdCollection)
            {
                this.player = player;
                this.user = user;
                this.ts = s;
                this.cdCollection = cdCollection;
            }

            public Song GetCurrentSong()
            {
                return ts.GetCurrentSong();
            }

            public void SetUser(User u)
            {
                this.user = u;
            }
        }

        public class SongSelector
        {
            public Song GetCurrentSong()
            {
                throw new NotImplementedException();
            }
        }

        public class CDPlayer
        {
            private Playlist p;
            private CD c;

            public CDPlayer(CD c, Playlist p)
            {
                this.c = c;
                this.p = p;
            }

            public void PlaySong(Song s)
            {
            }

            public Playlist GetPlaylist()
            {
                return this.p;
            }

            public CD GetCD()
            {
                return this.c;
            }

            public void SetCD(CD c)
            {
                this.c = c;
            }
        }

        public class Playlist
        {
            private Song song;
            private Queue<Song> queue = new Queue<Song>();

            public Playlist(Song song)
            {
                this.song = song;
            }

            public void QueueSong(Song s)
            {
                this.queue.Enqueue(s);
            }

            public Song GetNextToPlay()
            {
                return this.queue.Peek();
            }
        }

        public class CD
        {
        }

        public class Song
        {
        }

        public class User
        {
            public string Name { get; set; }
            public long ID { get; set; }
            public static User AddUser(string name, long id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
