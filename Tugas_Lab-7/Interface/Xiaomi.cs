using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_7.Interface
{
    class Xiaomi : IHandphone, ILokasi
    {
        public void Buatan()
        {
            Console.WriteLine("Hp Xiaomi adalah Hp Buatan dari Negara Tiongkok ");
        }
        public void Kota()
        {
            Console.WriteLine("Hp Xiaomi adalah Hp Buatan dari Kota Ying Mansion, Bejing ");
        }
    }
}
