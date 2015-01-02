/*
The API: int read4(char *buf) reads 4 characters at a time from a file. 

The return value is the actual number of characters read. For example, 
it returns 3 if there is only 3 characters left in the file. 

By using the read4 API, implement the function int read(char *buf, int n)
that reads n characters from the file. 

Note:
 The read function may be called multiple times. 

// Forward declaration of the read4 API.
int read4(char *buf);

class Solution {
public:    
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read     
    int read(char *buf, int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex158
    {
        private char[] arr;
        private int pos;

        private char[] buffer = new char[4];
        private int offset = 0;
        private int bufsize = 0;

        public Ex158(char[] arr)
        {
            this.arr = arr;
        }

        public int Read(char[] buf, int n)
        {
            int readBytes = 0;
            bool eof = false;
            while (!eof && readBytes < n)
            {
                int sz = (this.bufsize > 0) ? this.bufsize : Read4(buffer);
                if (this.bufsize == 0 && sz < 4)
                    eof = true;

                int bytes = Math.Min(n - readBytes, sz);
                Array.Copy(
                    this.buffer, /* src */
                    this.offset, /* srcPos */
                    buf, /* dest */
                    readBytes, /* destPos */
                    bytes); /* length */
                this.offset = (this.offset + bytes) % 4;
                this.bufsize = sz - bytes;
                readBytes += bytes;
            }
            
            return readBytes;
        }

        private int Read4(char[] buf)
        {
            if (this.pos >= this.arr.Length)
                return 0;

            int bytes = Math.Min(this.arr.Length - this.pos, 4);
            Array.Copy(this.arr, this.pos, buf, 0, bytes);
            this.pos += bytes;
            return bytes;
        }
    }
}