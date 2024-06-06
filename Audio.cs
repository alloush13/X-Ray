using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NAudio.Wave;
namespace XRay
{
    internal class Audio
    {

        public static Boolean stop =false;
        public static Boolean isRecording = false;

        public static void record(String audioFile)
        {
            isRecording = true;
           


            Task.Run(() =>
            {

                using (var waveIn = new WaveInEvent())
                {
                    waveIn.WaveFormat = new WaveFormat(44100, 1);
                    WaveFileWriter waveFileWriter = null;
                    waveIn.DataAvailable += (sender, e) =>
                    {

                        if (waveFileWriter == null)
                        {
                            waveFileWriter = new WaveFileWriter(audioFile, waveIn.WaveFormat);
                        }

                        waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
                    };
                    waveIn.StartRecording();

                    while (true)
                    {
                        if (!isRecording)
                        {
                            waveIn.StopRecording();
                            waveFileWriter?.Dispose();
                            break;
                        }

                        Thread.Sleep(1000);
                    }


                }


            });




        }

        public static void stopRecording()
        {
            isRecording = false;
        }
        public static void stopSound()
        {
            stop = true;
        }
        public static  void playSound(string audioFile)
        {
            Audio.stopSound();
            Thread.Sleep(1000);
            stop = false;
            Task.Run(() =>
            {
               
                if (File.Exists(audioFile))
                {
                    using (var audioFileReader = new MediaFoundationReader(audioFile))
                    using (var wasapiOut = new WasapiOut())
                    {
                        wasapiOut.Init(audioFileReader);
                        wasapiOut.Play();
                        while (wasapiOut.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(1000);
                            if (stop) break;

                        }
                    }
                }
            });


        }



    }
}
