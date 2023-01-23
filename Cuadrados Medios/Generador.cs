using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrados_Medios
{
    public class Generador
    {
        public List<float> Aleatorios { get; set; }
        public int N { get; set; }  
        public float Semilla { get; set; }  
        public int D { get; set; }
        public Generador(float semilla, int n)
        {
            Aleatorios = new List<float>();
            Semilla = semilla;
            // semilla: 7370
            if (semilla < 1)
            {
                string semillaTexto = semilla.ToString();
                int pos = semillaTexto.IndexOf('.');
                semillaTexto = semillaTexto.Substring(pos, semillaTexto.Length - pos);
                D = semillaTexto.Length;
                Semilla = float.Parse(semillaTexto);
                N = n;  
                if (D < 3)
                {
                    float x0, x1;
                    x0 = Semilla;
                    string temp;
                    int longitud, tam;
                    for (int i = 0; i < N; i++) 
                    {
                        temp = Math.Pow(x0, 2).ToString();
                        longitud = temp.Length;
                        if (longitud % 2 == 1)
                        {
                            temp = "0" + temp;
                            longitud = temp.Length;
                        }
                        temp = temp.Substring((longitud/2)-2,4);
                        x1 = float.Parse();
                    }
                }

            }
            else
            {

            }
        }
    }
}
