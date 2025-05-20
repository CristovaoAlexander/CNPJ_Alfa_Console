using Projeto_Zero.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Zero.Services
{
    public class Calcula : InterfaceValores
    {
        public int Soma(int A, int B)
        {
            var soma = A + B;
            return soma;
        }

        public int SomaDuplica(int A, int B)
        {
            var duplica = 2 * (A + B);
            return duplica;
        }
    }
}
