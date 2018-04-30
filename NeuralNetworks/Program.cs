using System;

namespace NeuralNetworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neural Network for a  simple \"AND\" Function");

            // for a simple AND function we need three neurons one of which is a bias neuron

            #region formation of a simple neural network
            // bias neuron
            // the weight of the bias neuron is always 1
            Neuron _biasNeuron = new Neuron();
            _biasNeuron.weight = 1;
            _biasNeuron.input = 1;

            Neuron _neuron1 = new Neuron();
            Neuron _neuron2 = new Neuron();

            //forming a layer out of the three neurons
            Layer _inputLayer = new Layer();
            _inputLayer.Neurons.Add(_biasNeuron);
            _inputLayer.Neurons.Add(_neuron1);
            _inputLayer.Neurons.Add(_neuron2);

            // creating a network out of layers
            // functions are applied over network
            Network _network = new Network();
            _network.Layers.Add(_inputLayer);
            #endregion
        }
    }
}
