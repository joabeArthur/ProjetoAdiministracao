using System.Collections.Generic;
using System.Linq;
using LiteDBExample.Modelos;

namespace ProjetoAdiministracao;

public class Conversor : BaseControle
{
    public static List<Cliente> ConverterDividasParaClientes(List<Divida> dividas)
    {
        // Verifica se a lista de dívidas é nula ou vazia
        if (dividas == null || !dividas.Any())
        {
            return new List<Cliente>();
        }

        // Converte a lista de Divida para uma lista de Cliente
        List<Cliente> clientes = dividas.Select(divida => new Cliente
        {
            Id = divida.Id, // Exemplo de mapeamento
            Nome = divida.Nome,
            CPF = divida.CPF,
            Data = divida.Data,
            Valor = divida.Valor,
            }).ToList();

        return clientes;
    }

    internal void ConverterDividasParaClientes()
    {
        throw new NotImplementedException();
    }
}