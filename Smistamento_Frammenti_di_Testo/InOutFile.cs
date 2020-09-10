using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Smistamento_Frammenti_di_Testo
{
    class InOutFile : InterazioneFile
     {
        public string[] leggi(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool scrivi(string path, string testo)
        {
            try
            {
                File.WriteAllText(path, testo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
