using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Zero.Services
{
    public class CnpjValidator
    {
        public static string CalcularDigitosVerificadoresPorAscii(string? cnpjParcial)
        {
            if (string.IsNullOrWhiteSpace(cnpjParcial) || cnpjParcial.Length != 12)
                throw new ArgumentException("CNPJ parcial deve conter exatamente 12 caracteres.");

            // Transforma todas as letras em maiúsculas
            cnpjParcial = cnpjParcial.ToUpperInvariant();

            // Primeiro dígito verificador
            int primeiroDV = CalcularDigito(cnpjParcial, true);

            // Adiciona o primeiro dígito ao CNPJ parcial para calcular o segundo
            string cnpjComPrimeiroDV = cnpjParcial + primeiroDV;

            // Segundo dígito verificador
            int segundoDV = CalcularDigito(cnpjComPrimeiroDV, false);

            return $"{primeiroDV}{segundoDV}";
        }

        private static int CalcularDigito(string cnpj, bool primeiroDigito)
        {
            int[] pesos = primeiroDigito
                ? new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 }
                : new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                int valorAsciiMenos48 = cnpj[i] - 48;
                soma += valorAsciiMenos48 * pesos[i];
            }

            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }

}
