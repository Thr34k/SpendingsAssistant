using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant.ANN
{

    class Neuron
    {
        public int nInputs; //number of inputs for the neuron
        public double bias; //Bias of the neuron
        public double output; //output of the neuron
        public double errorGradient; 
        public List<double> weights = new List<double>(); //The list of weights of the neuron
        public List<double> inputs = new List<double>(); //The list of inputs comming into the neuron

        public Neuron(int _nInputs)
        {
            float weightRange = (float)2.4 / (float)nInputs;
            Random rndWRange = new Random();
            bias = rndWRange.Next((int)-weightRange, (int)weightRange); //Set the initial bias to a random value
            nInputs = _nInputs; // Set the number of inputs

            for (int i = 0; i < _nInputs; i++) //for each input
            {
                Random rndWeight = new Random();
                weights.Add(rndWeight.Next((int)-weightRange, (int)weightRange)); //Add a randomlu initialized weight to the neurons list of weights
            }

        }
    }
}
