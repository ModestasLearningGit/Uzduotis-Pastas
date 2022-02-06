using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastasFull
{
    internal class User
    {
        public string Vardas { get; set; }
        public string Adresas { get; set; }
        public string Kodas { get; set; }
        public string suma1 { get; set; }
        public string suma2 { get; set; }

        public User()
        {

            Vardas = "";
            Adresas = "";
            Kodas = "";
            suma1 = "";
            suma2 = "";
        }
        public User(string RowData)
        {
            string[] data = RowData.Split(';');
            Vardas = data[0];
            Adresas = data[1];
            Kodas = data[2];
            suma1 = data[3];
            suma2 = data[4];
        }
        public User(string one, string two, string three, string four, string five)
        {

            Vardas = one;
            Adresas = two;
            Kodas = three;
            suma1 = four;
            suma2 = five;
        }
        public override string ToString()
        {
            string str = $"{Vardas} {Adresas} {Kodas} {suma1} {suma2}";

            return str;
        }

    }
}

