using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    public static class PetFromCsv
    {
        public static Pet ConverteDoTexto(this string? line)
        {

            if (line is null) throw new ArgumentNullException("Null String");
            if (line == "") throw new ArgumentException("Invalid String");

            string[] propriedades = line?.Split(';');
            if (propriedades.Length != 3) throw new ArgumentOutOfRangeException("Insufficient Number Of Arguments");

            bool valido = Guid.TryParse(propriedades[0], out Guid petId);
            if (!valido) throw new ArgumentException("Invalid Guid");
            valido = int.TryParse(propriedades[2], out int numeroTipoPet);
            if (!valido || (numeroTipoPet != 0 && numeroTipoPet != 1)) throw new ArgumentException("Invalid Pet Type");


            return new Pet(petId, propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
