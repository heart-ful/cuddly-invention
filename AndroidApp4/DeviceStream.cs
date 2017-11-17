using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Java.Util;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace AndroidApp4
{
    //The purpose of most buffers is to act as a holding area,
    //enabling the CPU to manipulate data before transferring it to a device.
    //a stream is a sequence of data elements made available over time
    public abstract class Stream: MarshalByRefObject
    {
        //Stream is the abstract base class of all streams.A stream is an abstraction of a sequence of bytes, 
        //such as a file, an input/output device, an inter-process communication pipe, or a TCP/IP socket. 
        //Stream has some methods which cannot be implemented in the base class
        //we'll declare a child, who inherit from stream and will implement those methods

        //What can I do with this class?
        //Read: get data from the stream , turn it to bytes and add them to an array 
        //Write: transfer bytes from array to streams 
        //Seek : to find and change the length of the stream

        //gets a value indicating whether the current stream supports reading.
        public abstract Boolean CanRead { get; }

        //gets a value indicating whether the current stream supports seeking.
        public abstract Boolean CanSeek { get; }

        //get the length of stream and displays it 
        public abstract Int64 Length { get; }

    }
    class DeviceStream : Stream
    {
        public override bool CanRead => throw new NotImplementedException();

        public override bool CanSeek => throw new NotImplementedException();

        public override long Length => throw new NotImplementedException();

        //NOW THE METHODS!!!!

        //to begin an read operation.

        //the textview that will 

        //As i click on a button that says show data 
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string filename = @"c:\Temp\userinputlog.txt"; //this can be the socket or device 
            byte[] result; //where the data goes in the meantime

            using (FileStream SourceStream = File.Open(filename, FileMode.Open)) //filename can be replaced by socket 
            {
                result = new byte[SourceStream.Length];
                await SourceStream.ReadAsync(result, 0, (int)SourceStream.Length);
            }

            // graph instead of userinput UserInput.Text = System.Text.Encoding.ASCII.GetString(result);
        }




        //to begin a write method, ie adding what i read to a page 
        public virtual void  WriteFileAsync()
        {
            StreamWriter writer = new StreamWriter(@"name of page that will display it ");
            writer.WriteLine("the data in bytes");
            writer.Close();
           
        }
    }


}