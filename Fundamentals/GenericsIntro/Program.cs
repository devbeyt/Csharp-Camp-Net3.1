using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> languages = new MyList<string>();
            languages.Add("Html");
        }
    }
}
