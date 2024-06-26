﻿using System.Security.Cryptography;
using System.Text;

namespace ApiUsuariosUeceMy.Infra.Utils;

public static class GerarHash
{
    public static string GerarCodigo(this string? valor)
    {
        var hash = SHA1.Create();
        var enconding = new ASCIIEncoding();
        var array = enconding.GetBytes(valor);

        array = hash.ComputeHash(array);
        var strHexa = new StringBuilder();

        foreach (var item in array)
        {
            strHexa.Append(item.ToString("X2"));
        }

        return strHexa.ToString();
    }
}
