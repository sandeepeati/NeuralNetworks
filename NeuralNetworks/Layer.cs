using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetworks
{
    class Layer
    {
        public List<Neuron> Neurons { get; set; }

        public double Output
        {
            get
            {
                return Output;
            }

            private set
            {
                foreach (var neuron in Neurons)
                {
                    Output += neuron.output;
                }
            }
        }
    }
}
