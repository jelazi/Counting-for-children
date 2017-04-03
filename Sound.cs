using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace pocitani
{



    class Sound
    {
        static Random nh = new Random(); // nahodne

        static bool sound = true;
        

        public static bool setSound ()
        {
            return sound;
        }

        public static void changesound ()
        {
            if (sound == true)
            {
                sound = false;
            }
            else
            {
                sound = true;
            }
        }
        

        public static void soundoff ()
        {
            sound = false;
        }
        
        public static void soundon ()
        {
            sound = true;
        }

        private static string GetAppDir
        {
            get

            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                return fi.DirectoryName;
            }
        }

        public static void PlaySoundFromSubDir(string subDir)
        {
            string dir = GetAppDir + String.Format(@"\sounds\{0}\", subDir);
            string[] files = Directory.GetFiles(dir);
            int i = nh.Next(0, files.Count());
            string fn = files[i];
            if (sound == true)
            {
                PlaySound(fn);
            }
            
        }



        public static void PlaySound(string path)
        {
            SoundPlayer sp = new SoundPlayer(path);
            try
            {
                if (sound == true)
                {
                    sp.Play();
                }
                
            }
            catch { }
        }



        
        

    }
    }

