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
                double Ypred = CostFunction(Layers[0].Output);

                // if error is less than 
                if ((t.Y - Ypred) > 0.001 || (t.Y - Ypred) < -0.001)
                    return;
                double error = Math.Pow((t.Y - Ypred), 2);
                sumOfErrors += error;
            }

            // mean square function
            sumOfErrors = sumOfErrors / 2;
        }

        #region Helper Functions
        public double GetOutput()
        {
            return Layers[Layers.Count - 1].Output;
        }

        private double CostFunction(double y)
        {
            return (1 / (1 + Math.Exp(-y)));
        }

        private void GradientDescent()
        {

        }
        #endregion
    }
}
