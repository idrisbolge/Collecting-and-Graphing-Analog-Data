using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Multimetre_ve_Osiloskop
{
    class Baglantilar
    {




        public static bool state = false;
        public string serialNumber;
        public ConcurrentQueue<string> kuyruk = new ConcurrentQueue<string>();

        FirebaseConnection con = new FirebaseConnection();
        public async void login()
        {
            int x = -1;
            while (state)
            {
                con.client = new FireSharp.FirebaseClient(con.config);
                con.response = await con.client.GetAsync(serialNumber);

                ReceivingData rc = con.response.ResultAs<ReceivingData>();

                if (x != int.Parse(rc.indexNo.ToString()))
                {
                    kuyruk.Enqueue(rc.Value.ToString());
                }
                x = int.Parse(rc.indexNo.ToString());
            }
        }





        //private string result;

        //public void SeriConnect(string port)
        //{
        //    Form1 form = new Form1();
        //    form.serialPort1.PortName = port;
        //    form.serialPort1.BaudRate = 9600;
        //    form.serialPort1.Open();
        //}


        //public void data_received()
        //{
        //    Form1 form = new Form1();

        //    var indata = form.serialPort1.ReadChar();
        //    if (indata != 13 && indata != 10)
        //        result += Convert.ToChar(indata);
        //    else
        //    {
        //        if (result != null)
        //            kuyruk.Enqueue(result.ToString());
        //        result = null;
        //    }


        //}
    }
}
