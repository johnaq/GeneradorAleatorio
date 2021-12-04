using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio
{
    public class Data
    {
        [DisplayName("N")]
        public int Id { get; set; }

        [DisplayName("Xn^2")]
        public string? Xn2 { get; set; }

        [DisplayName("Cifras centrales")]
        public string? XnCentrales { get; set; }

        [DisplayName("Número")]
        public double Numero { get; set; }


    }
}
