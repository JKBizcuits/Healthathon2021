using System;
using System.Collections.Generic;
using System.Text;
using Extreme.Mathematics.Calculus;
using Extreme.Mathematics;


namespace HackHealth2021
{
    class Calculator
    {

        DateTime today = DateTime.Today;
        double seconds;
        double constant = 3600;
        double deltaSecond = 1;
        double bright;
        double final;
        SimpsonIntegrator simpson = new SimpsonIntegrator();


        public Calculator(DateTime today)
        {

        }

        public double brightness(double b, double t)
        {
            double result = 0;

            return result;
        }

        public double accelleration(double b, double t)
        {
            double result = 0;
            return result;
        }

        public double angle(double b, double t)
        {
            double result = 0;
            return result;
        }


        public double app(double b, double t)
        {
            double result = 0;
            return result;
        }

        public double theEnd()
        {
            return final;
        }
    }
}
