using Projeto_Zero.Entities;
using Projeto_Zero.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Zero.Controllres
{
    public class Controller
    {
        public void Processo()
        {
            try
            {
                var calcula = new Calcula();
                var entities = new Valores();
                entities.NumA = 3;
                entities.NumB = 15;

                Console.WriteLine("A : " + entities.NumA);
                Console.WriteLine("B : " + entities.NumB);

                var soma = calcula.Soma(entities.NumA, entities.NumB);
                Console.WriteLine("soma : " + soma);

                var ss = calcula.SomaDuplica(entities.NumA, entities.NumB);
                Console.WriteLine("som duplica : " + ss);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("erro :" + e.Message);
            }
            
        }  
        
        public void RetornoCNPJ(string? cnpjBase)
        {
            try
            {
                //string cnpjBase = "12AB56CD0001"; // 12 caracteres alfanuméricos
                string digitosVerificadores = CnpjValidator.CalcularDigitosVerificadoresPorAscii(cnpjBase);

                Console.WriteLine($"Dígitos verificadores: {digitosVerificadores}");
                Console.WriteLine($"CNPJ completo: {cnpjBase.ToUpperInvariant()}{digitosVerificadores}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("erro :" + e.Message);
            }
            finally
            {
                Console.WriteLine("processo executado .. ");
            } 
            
        }
    }
}
