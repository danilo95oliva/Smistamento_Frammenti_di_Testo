using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smistamento_Frammenti_di_Testo
{
    interface InterazioneDirectory
    {
        string[] leggi(string path, string regola);
        bool creaDir(string path);
    }
}
