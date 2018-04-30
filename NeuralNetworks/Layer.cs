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

        // each layer has error 
        // in order to eliminate error we calculate cost function
        // and an average is taken at layer level
        public double CostFunction
        {
            get
            {
                return (1 / (1 + Math.Exp(-Output))) / Neurons.Count;
            }
        }
    }
}
