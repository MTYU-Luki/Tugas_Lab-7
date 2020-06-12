using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_7.Interface
{
    class Vivo : IHandphone, ILokasi
    {
        public void Buatan()
        {
            Console.WriteLine("Hp Vivo adalah Hp Buatan dari Negara Tiongkok ");
        }
        public void Kota()
        {
            Console.WriteLine("Hp Vivo adalah Hp Buatan dari Kota Dongguan");
        }
    }
}
