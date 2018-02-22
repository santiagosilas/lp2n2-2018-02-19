using System;
using Mail;
using Form;

// Exemplo com forte acoplamento.

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
           var form = new FormHandler();
           form.Handle("Casa");
        }
    }
}
