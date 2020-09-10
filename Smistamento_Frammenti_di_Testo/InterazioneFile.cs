using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smistamento_Frammenti_di_Testo
{
    interface InterazioneFile
    {
        string[] leggi(string path);
        bool scrivi(string path, string testo);
    }
}
