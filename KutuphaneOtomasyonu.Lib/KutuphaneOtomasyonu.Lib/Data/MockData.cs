using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib.Data
{
    public class MockData
    {

        public Context context { get; set; }

        public MockData()
        {
            context = new Context();
    
            for (int i = 0; i < 10; i++)
            {
                context.Yazarlar.Add(new Yazar
                {
                    Ad = 

                });
            }



        }

        




}

