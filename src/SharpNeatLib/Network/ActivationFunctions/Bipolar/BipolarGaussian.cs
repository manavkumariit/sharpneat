/* ***************************************************************************
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

using System;

namespace SharpNeat.Network
{
    /// <summary>
    /// Bipolar Gaussian activation function. Output range is -1 to 1, that is, the tails of the Gaussian
    /// distribution curve tend towards -1 as abs(x) -> Infinity and the Gaussian peak is at y = 1.
    /// </summary>
    public class BipolarGaussian : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new BipolarGaussian();

        /// <summary>
        /// Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
        /// is using.
        /// </summary>
        public string FunctionId
        {
            get { return this.GetType().Name; }
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        public double Calculate(double x)
        {
            return (2.0 * Math.Exp(-Math.Pow(x * 2.5, 2.0))) - 1.0;
        }
    }
}
