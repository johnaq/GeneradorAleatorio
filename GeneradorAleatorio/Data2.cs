using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio
{
    public class Data2
    {
        [DisplayName("N")]
        public int Id { get; set; }

        [DisplayName("X0")]
        public string? X0 { get; set; }

        [DisplayName("X1")]
        public string? X1 { get; set; }

        [DisplayName("X0 * X1")]
        public string? Xn2 { get; set; }

        [DisplayName("Cifras centrales")]
        public string? XnCentrales { get; set; }

        [DisplayName("Número")]
        public double Numero { get; set; }


    }
}
