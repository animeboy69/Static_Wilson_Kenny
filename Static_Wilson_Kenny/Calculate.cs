using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Wilson_Kenny
{
    class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // INTEGERS
        /// <summary>
        /// Tell what number the user puts
        /// </summary>
        /// <param name="x">number that is put will the x </param>
        /// <param name="y">number that is put will the y </param>
        /// <returns></returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }


        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        // FLOATERS
        /// <summary>
        /// Tells the user what the x and y is when you add the two numbers
        /// </summary>
        /// <param name="x">the number that the user puts in there</param>
        /// <param name="y">number that the user puts</param>
        /// <returns></returns>
        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Sub(float x, float y)
        {
            return x - y;
        }


        public static float Mult(float x, float y)
        {
            return x * y;
        }

        public static float Div(float x, float y)
        {
            return x / y;

        }
    }
}
