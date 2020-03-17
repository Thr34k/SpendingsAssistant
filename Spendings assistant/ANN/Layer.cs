using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant.ANN
{
    class Layer
    {
        public int nNeurons; //Number of neurons in the layer
        public List<Neuron> neurons = new List<Neuron>(); //The actual list of neurons

        public Layer(int _nNeurons, int _nNeuronInputs) //Params: number of neurons and number of inputs for the neuron
        {
            nNeurons = _nNeurons; //Set the number of neurons
            for (int i = 0; i < _nNeurons; i++) //For each neuron
            {
                neurons.Add(new Neuron(_nNeuronInputs)); //Create a new neuron and add it to the layers list
            }
        }
    }
}
