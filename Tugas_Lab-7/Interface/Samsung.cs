using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_7.Interface
{
    class Samsung : IHandphone, ILokasi
    {
        public void Buatan()
        {
            Console.WriteLine("Hp Samsung adalah Hp Buatan dari Negara Korea Selatan ");
        }
        public void Kota()
        {
            Console.WriteLine("Hp Samsung adalah Hp Buatan dari Kota Seoul");
        }
    }
}
