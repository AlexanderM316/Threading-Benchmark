using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OSproj
{
    public partial class Form1 : Form
    {
        Thread t, t1, t0, timer, z3, o3, tw3, th3, timer4, timerocta, octa0, octa1, octa2, octa3, octa4, octa5, octa6, octa7;

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timerocta = new Thread(timero);
            timerocta.Start();
            octa0 = new Thread(oc0);
            octa0.Start();
            octa1 = new Thread(oc1);
            octa1.Start();
            octa2 = new Thread(oc2);
            octa2.Start();
            octa3 = new Thread(oc3);
            octa3.Start();
            octa4 = new Thread(oc4);
            octa4.Start();
            octa5 = new Thread(oc5);
            octa5.Start();
            octa6 = new Thread(oc6);
            octa6.Start();
            octa7 = new Thread(oc7);
            octa7.Start();
        }

        //long timet2 = 0;

        public Form1()
        {
            InitializeComponent();


        }

        void single()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            UseWaitCursor = true;
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                    if (f)
                    {
                        //print(i);
                        listBox1.Invoke((Action)delegate
                        {
                            listBox1.Items.Add(i.ToString());
                        });
                        count += 1;
                    }


                    i += 1;
                
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            listBox1.Invoke((Action)delegate
            {
                label3.Text = elapsedMs.ToString() +" ms";
            });
            UseWaitCursor = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer4 = new Thread(timerw4);
            timer4.Start();
            z3 = new Thread(z_3);
            z3.Start();
            o3 = new Thread(o_3);
            o3.Start();
            tw3 = new Thread(tw_3);
            tw3.Start();
            th3 = new Thread(th_3);
            th3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //timer = new Thread(timerw);
            //timer.Start();
            t = new Thread(single);
            t.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            timer = new Thread(timerw);
            timer.Start();
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            t0 = new Thread(zero);
            t0.Start();
            t1 = new Thread(one);
            t1.Start();
            //watch.Stop();
           // var elapsedMs = watch.ElapsedMilliseconds;
            //label4.Text = elapsedMs.ToString();
            /* while (true)
             {
                 if (t1.IsAlive == false)
                 {
                     watch.Stop();
                     var elapsedMs = watch.ElapsedMilliseconds;
                     label4.Text = elapsedMs.ToString();
                     break;
                 }
                 Thread.Sleep(1);
             }*/
        }
        void zero()
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();

            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i2 = i2 / 2;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
            //watch.Stop();
            //var elapsedMs = watch.ElapsedMilliseconds;
           // timet2 += elapsedMs;
            //listBox1.Invoke((Action)delegate
            //{
                //long time = long.Parse(label4.Text.ToString());
               // long total = time + elapsedMs;
                //label4.Text = timet2.ToString() + " ms";
            //});
        }
        void one()
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();

            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 / 2;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
           // watch.Stop();
           // var elapsedMs = watch.ElapsedMilliseconds;
           // timet2 += elapsedMs;
            //listBox1.Invoke((Action)delegate
           // {
               // long time = long.Parse(label4.Text.ToString());
                //long total = time + elapsedMs;
               // label4.Text = timet2.ToString() + " ms";
            //});
        }
        void timerw()
        {
            UseWaitCursor = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (true)
            {
                if(t0.IsAlive == false && t1.IsAlive == false)
                {
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    listBox1.Invoke((Action)delegate
                    {

                        label4.Text = elapsedMs.ToString() + " ms";
                        
                    });
                    UseWaitCursor = false;
                    break;
                }
            }
        }
        void z_3()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i2 = i2 / 4;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void o_3()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 / 4;
            i2 = i2 / 2;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }
        void tw_3()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 / 2;
            i2 = i2 - i2 / 4;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void th_3()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 - i2 / 4;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void timerw4()
        {
            UseWaitCursor = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (true)
            {
                if (z3.IsAlive == false && o3.IsAlive == false && tw3.IsAlive ==false && th3.IsAlive == false)
                {
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    listBox1.Invoke((Action)delegate
                    {

                        label5.Text = elapsedMs.ToString() + " ms";
                        
                    });
                    UseWaitCursor = false;
                    break;
                }
            }
        }

        void oc0()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i2 = i2 / 8;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void oc1()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 / 8;
            i2 = i2*2 / 8;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }
        void oc2()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2 *2/ 8;
            i2 = i2 *3/ 8;

            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void oc3()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2*3 / 8;
            i2 = i2*4 / 8;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void timero()
        {
            UseWaitCursor = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (true)
            {
                if (octa0.IsAlive == false && octa1.IsAlive == false && octa3.IsAlive == false && octa4.IsAlive == false && octa5.IsAlive == false && octa6.IsAlive == false && octa7.IsAlive == false)
                {
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    listBox1.Invoke((Action)delegate
                    {

                        label6.Text = elapsedMs.ToString() + " ms";
                        
                    });
                    UseWaitCursor = false;
                    break;
                }
            }
        }

        void oc4()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2*4/ 8;
            i2 = i2*5 / 8;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }


        void oc5()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2*5 / 8;
            i2 = i2*6 / 8;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }


        void oc6()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2*6 / 8;
            i2 = i2*7 / 8;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }

        void oc7()
        {
            int i, i2, n, count = 0;
            bool f;


            i = int.Parse(textBox1.Text.ToString());
            i2 = int.Parse(textBox2.Text.ToString());
            i = i2*7 / 8;
            i2 = i2 ;


            while (i < i2)
            {

                n = i - 1;
                f = true;
                while (n > 1)
                {
                    if (i % n == 0)
                    {
                        f = false;

                    }
                    n -= 1;
                }
                if (f)
                {
                    //print(i);
                    listBox1.Invoke((Action)delegate
                    {
                        listBox1.Items.Add(i.ToString());
                    });
                    count += 1;
                }


                i += 1;

            }
        }
    }
}
