using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetworks
{
    class Network
    {
        public List<Layer> Layers { get; set; }

        // train the neural network
        public void Train(List<TestModel> tests)
        {
            double sumOfErrors = 0;

            // calculating error for each testmodel
            foreach (TestModel t in tests)
            {
                Layers[0].Neurons[0].input = t.neuron1Input;
                Layers[0].Neurons[1].input = t.neuron2Input;
            }

            // mean square function
            sumOfErrors = sumOfErrors / 2;
        }

        #region Helper Functions
        public double GetOutput()
        {
            return Layers[Layers.Count - 1].Output;
        }

        private void GradientDescent()
        {

        }
        #endregion
    }
}
