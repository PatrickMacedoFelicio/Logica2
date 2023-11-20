using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// 1 passo : criar a lista com os atributos
namespace ListaCliente
{
    public class Cliente
    {
        public string nome;
        public int id;
        public double[]? valorproduto = new double[0];
        public string[]? nomeproduto = new string[0];
        public Cliente? prox;
        public Endereco? endereco;


    }
}
