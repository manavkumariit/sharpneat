﻿/* ***************************************************************************
 * This file is part of SharpNEAT - Evolution of Neural Networks.
 * 
 * Copyright 2004-2016 Colin Green (sharpneat@gmail.com)
 *
 * SharpNEAT is free software; you can redistribute it and/or modify
 * it under the terms of The MIT License (MIT).
 *
 * You should have received a copy of the MIT License
 * along with SharpNEAT; if not, see https://opensource.org/licenses/MIT.
 */

namespace SharpNeat.Network
{
    /// <summary>
    /// Leaky rectified linear activation unit (ReLU).
    /// Shifted on the x-axis so that x=0 gives y=0.5, in keeping with the logistic sigmoid.
    /// </summary>
    public class LeakyReLUShifted : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new SReLU();

        public string FunctionId => this.GetType().Name;

        public double Calculate(double x)
        {
            const double a = 0.001;
            const double offset = 0.5;

            double y;
            if (x+offset > 0.0) {
                y = x+offset;
            } else {
                y = (x+offset) * a;
            }
            return y;
        }
    }
}
