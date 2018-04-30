using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetworks
{
    class Neuron
    {
        // input to a neuron 
        // it could be the output of another neuron or output of a layer
        public int input { private get; set; }

        // weight of the neuron
        // the importance of the neuron increases with its weight
        public double weight { private get; set; } = 0.01;

        // output of the neuron
        // input x weight
        public double output
        {
            get
            {
                return input * output;
            }
        }
    }
}
