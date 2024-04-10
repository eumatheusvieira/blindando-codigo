using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int x, int y)
        {
            int res = x + y;
            historico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int Subtrair(int x, int y)
        {
            int res = x - y;
            historico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int Multiplicar(int x, int y)
        {
            int res = x * y;
            historico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int Dividir(int x, int y)
        {
            int res = x / y;
            historico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}