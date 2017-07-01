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

namespace SharpNeat.Network
{
    /// <summary>
    /// Interface for neural network activation functions. An activation function simply takes a single input 
    /// value and produces a single output value. IActivationFunction allows for activation functions to be 
    /// plugged in to neural network implementations. Typical activation functions would be a sigmoid or step 
    /// function.
    /// 
    /// The Calculate method has two overloads, one for each of the data types double and float, this allows
    /// an IActivationFunction object to be plugged in to neural network classes that are written to operate
    /// with either of those two data types. Typically the choice of which neural network implementation and
    /// floating point precision to use is part of the setting up and design of a problem domain and experiment.
    /// For some problem domains the extra precision of a double may be unnecessary.
    /// </summary>
    public interface IActivationFunction
    {
        /// <summary>
        /// Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
        /// is using.
        /// </summary>
        string FunctionId { get; }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        double Calculate(double x);
    }
}
