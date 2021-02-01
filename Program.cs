﻿using rpi_rgb_led_matrix_sharp;
using System;
using System.Diagnostics;

namespace LEDMatrixDemo
{
    class Program
    {
        static int Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("waiting for debugger to attach...");
                if (Debugger.IsAttached) break;
                System.Threading.Thread.Sleep(1000);
            }

            var options = new RGBLedMatrixOptions
            {
                Rows = 64,
                Cols = 64,
                GpioSlowdown = 4,
                Brightness = 100,
                ChainLength = 1, 
                LimitRefreshRateHz = 60
            };

            var matrix = new RGBLedMatrix(options);
            var canvas = matrix.CreateOffscreenCanvas();

            for (var i = 0; i < 1000; ++i)
            {
                canvas.Fill(new Color(255, 255, 255));
                //for (var y = 0; y < canvas.Height; ++y)
                //{
                //    for (var x = 0; x < canvas.Width; ++x)
                //    {
                //        canvas.SetPixel(x, y, new Color(i & 0xff, x, y));
                //    }
                //}
                //canvas.DrawCircle(canvas.Width / 2, canvas.Height / 2, 6, new Color(0, 0, 255));
                //canvas.DrawLine(canvas.Width / 2 - 3, canvas.Height / 2 - 3, canvas.Width / 2 + 3, canvas.Height / 2 + 3, new Color(0, 0, 255));
                //canvas.DrawLine(canvas.Width / 2 - 3, canvas.Height / 2 + 3, canvas.Width / 2 + 3, canvas.Height / 2 - 3, new Color(0, 0, 255));

                //canvas = matrix.SwapOnVsync(canvas);
            }

            Console.WriteLine("Done.");
            return 0;
        }
    }
}