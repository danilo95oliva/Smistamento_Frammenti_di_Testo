using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smistamento_Frammenti_di_Testo
{
    class Smista
    {
        private InterazioneFile file;
        private InterazioneDirectory dir;
        private string pathPartenza;
        private string pathDestinazione;


        public Smista(string pathP, string pathD)
        {
            file = new InOutFile();
            dir = new InOutDir();
            pathPartenza = pathP;
            pathDestinazione = pathD;


        }

        public bool esegui()
        {
            try
            {
                if (Directory.Exists(pathPartenza))
                {
                    string[] listaFile = dir.leggi(pathPartenza, "*.txt");
                    foreach (string f in listaFile)
                    {
                        if(!analizzaFile(f)) return false;
                    }
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool analizzaFile(string f)
        {
            try
            {
                string nuovoFile = pathDestinazione + "\\";
                if (File.Exists(f) && Directory.Exists(pathDestinazione))
                {
                    string[] contenuto = file.leggi(f);
                    for (int i = 0; i < contenuto.Length; i++)
                    {
                        if (identificatore(contenuto[i]))
                        {
                            nuovoFile += estrai(contenuto[i]);
                            string testo = estraiTesto(contenuto, i);
                            file.scrivi(nuovoFile, testo);
                            nuovoFile = pathDestinazione + "\\";
                        }
                    }
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public string estraiTesto(string[] contenuto, int i)
        {
            string risultato = "";
            i = i + 1;
            while (i < contenuto.Length && !identificatore(contenuto[i]))
            {
                risultato += contenuto[i] + "\n";
                i++;
            }
            return risultato;
        }

        public bool identificatore(string str)
        {
            if (str[0] == '-' && str[1] == '>')
            {
                return true;
            }
            return false;
        }

        public string estrai(string s)
        {
            return s.Substring(2);
        }
    }
}
