using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor {
    class Program {
        static void Main(string[] args) {
            ArquivoBloqueado bloqueado = new ArquivoBloqueado();
            int op = 0;
            while (op != 4) {
                Console.Write("\n>>> Menu - Fornecedor Bloqueado <<<\n" + "1- Inserir CNPJ\n" +
                    "2- Localizar Fornecedor Bloqueado\n" + "3- Liberar CNPJ\n" +
                    "4- Voltar ao Menu Principal\n\n" + "Digite sua escolha: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        bloqueado.InserirNoArquivo();
                        break;
                    case 2:
                        bloqueado.LocalizarNoArquivo();
                        break;
                    case 3:
                        bloqueado.Liberar();
                        break;
                }
            }
        }
    }
}
