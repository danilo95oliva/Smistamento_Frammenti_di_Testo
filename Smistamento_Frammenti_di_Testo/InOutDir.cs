using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smistamento_Frammenti_di_Testo
{
    class InOutDir : InterazioneDirectory
    {
        public string[] leggi(string path, string regole)
        {
            try
            {
                return Directory.GetFiles(@path, regole);
            }catch(Exception e)
            {
                throw e;
            }
        }

        public bool creaDir(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
