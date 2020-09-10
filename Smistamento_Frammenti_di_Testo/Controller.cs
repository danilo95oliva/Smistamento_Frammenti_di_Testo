using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smistamento_Frammenti_di_Testo
{
    class Controller
    {
        private string SUCCESSO = "Esecuzione terminata con successo!";
        private string FALLIMENTO = "Si è verificato un'errore durante l'esecuzione, verificare di aver inserito path di destinazione e partenza correttamente.";
        private Smista smista;
        public Controller(string pathPart, string pathDest)
        {
            smista = new Smista(pathPart, pathDest);
        }

        public string esegui()
        {
            if (smista.esegui())
            {
                return SUCCESSO;
            }
            else
            {
                return FALLIMENTO;
            }
        }
    }
}
