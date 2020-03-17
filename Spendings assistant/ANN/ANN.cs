using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant.ANN
{
    class ANN
    {
        int nInputs; //Number of inputs at the input layer
        int nOutputs; //Number of outputs at the output layer
        int nHidden; //Number of hidden layers
        int nNPerHidden; //Number of neurons per hidden layer
        double alpha; /*Value that controls how much an input is going to affect the overall network
                      (i.e.: how fast your network is going to learn)*/
        List<Layer> layers = new List<Layer>(); //The list of layers in the network

        public ANN(int nI, int nO, int nH, int nPH, double a)
        {
            //Set up parameters for ANN
            nInputs = nI;
            nOutputs = nO;
            nHidden = nH;
            nNPerHidden = nPH;
            alpha = a;

            if (nHidden > 0) //if the number of hidden layers is more than 0(i.e. we are using hidden layers)
            {
                layers.Add(new Layer(nNPerHidden, nInputs)); //Add an input layer with nNPerHidden neurons and nInputs inputs

                for (int i = 0; i < nHidden; i++) //foreach hidden layer we want
                {
                    //Add a new layer with nNPerHidden neurons and nNPerHidden inputs
                    layers.Add(new Layer(nNPerHidden, nNPerHidden)); 
                }
                //Add an output player with the specified number of outputs and inputs
                layers.Add(new Layer(nOutputs, nInputs));
            }
            else
            {
                //Just create an output layer with nOutputs neurons and nInputs inputs
                layers.Add(new Layer(nOutputs, nInputs));
            }
        }

        public List<double> Train(List<double> inputValues, List<double> desiredOutput) 
        {
            List<double> outputValues = new List<double>();
            outputValues = CalcOutput(inputValues, desiredOutput);
            UpdateWeights(outputValues, desiredOutput);
            return outputValues;
        }

        public List<double> CalcOutput(List<double> inputVals, List<double> desiredOutput) 
        {
            List<double> inputs = new List<double>(); //Create a list to keep track of inputs
            List<double> outputValues = new List<double>(); //Create a list to keep track of outputs
            int currentInput = 0;

            //If the number of inputs received do not match the number of inputs in the layer
            if (inputVals.Count != nInputs) 
            {
                return outputValues; //return the output values
            }

            inputs = new List<double>(inputVals); //initialize the inputs list with the inputs received
            for (int i = 0; i < nHidden + 1; i++) //for each layer in the network, input and output included (hence the reason for 'nHidden + 1')
            {
                //If we are past the input layer, set the inputs to the outputs of the previous layer
                if (i > 0)
                {
                    inputs = new List<double>(outputValues);
                }
                outputValues.Clear(); //Clear the outputs so we are ready for the next layer iteration

                for (int j = 0; j < layers[i].nNeurons; j++) //for each neuron in the layer
                {
                    double N = 0;
                    layers[i].neurons[j].inputs.Clear(); //Clear the neurons list of inputs

                    for (int k = 0; k < layers[i].neurons[j].nInputs; k++) //For each input of the neuron
                    {
                        layers[i].neurons[j].inputs.Add(inputs[currentInput]); //Add the outputs from the previous layer to the neurons list of inputs
                        N += layers[i].neurons[j].weights[k] * inputs[currentInput]; //Calculate N as the product of the neurons weight and input
                        currentInput++;
                    }

                    N -= layers[i].neurons[j].bias; //Decrement N by the neurons stored bias

                    if (i == nHidden) //if we are at the output layer
                        layers[i].neurons[j].output = Sigmoid(N); //calculate the neurons output as the result of Sigmoid of N
                    else //otherwise
                        layers[i].neurons[j].output = TanH(N); //Calculate the neurons output as the result of TanH of N

                    outputValues.Add(layers[i].neurons[j].output); //Add the neurons newly calculated output to the list of output values
                    currentInput = 0; //Set iterator equal to 0
                }
            }
            return outputValues; //Return the output
        }

        public List<double> CalcOutput(List<double> inputVals) 
        {
            List<double> inputs = new List<double>();
            List<double> outputValues = new List<double>();
            int currentInput = 0;

            if (inputVals.Count != nInputs)
            {
                return outputValues;
            }

            inputs = new List<double>(inputVals);
            for (int i = 0; i < nHidden + 1; i++)
            {
                if (i > 0)
                {
                    inputs = new List<double>(outputValues);
                }
                outputValues.Clear();

                for (int j = 0; j < layers[i].nNeurons; j++)
                {
                    double N = 0;
                    layers[i].neurons[j].inputs.Clear();

                    for (int k = 0; k < layers[i].neurons[j].nInputs; k++)
                    {
                        layers[i].neurons[j].inputs.Add(inputs[currentInput]);
                        N += layers[i].neurons[j].weights[k] * inputs[currentInput];
                        currentInput++;
                    }

                    N -= layers[i].neurons[j].bias;

                    if (i == nHidden)
                        layers[i].neurons[j].output = Sigmoid(N);
                    else
                        layers[i].neurons[j].output = TanH(N);

                    outputValues.Add(layers[i].neurons[j].output);
                    currentInput = 0;
                }
            }

            return outputValues;
        }

        void UpdateWeights(List<double> outputs, List<double> desiredOutputs) 
        {
            double error; //Create a reference to the error of a neuron
            for (int i = nHidden; i >= 0; i--) //foreach layer, starting from the output layer (backpropagation)
            {
                for (int j = 0; j < layers[i].nNeurons; j++) //foreach neuron in the layer
                {
                    if (i == nHidden) //If we are at the output layer
                    {
                        error = desiredOutputs[j] - outputs[j]; //Compute the error as the difference between the neurons output and its desired output
                        layers[i].neurons[j].errorGradient = outputs[j] * (1 - outputs[j]) * error; //Compute the neurons gradient using the delta rule
                        //Link: https://en.wikipedia.org/wiki/Delta_rule
                    }
                    else
                    {
                        //Compute the neurons errorgradient using the deltarule, but with the neurons own output instead
                        layers[i].neurons[j].errorGradient = layers[i].neurons[j].output * (1 - layers[i].neurons[j].output);
                        double errorGradSum = 0; //Create a reference to the error accumulated through the network
                        for (int p = 0; p < layers[i+1].nNeurons; p++) //For each neuron in the previous layer
                        {
                            //Increment the accumulated error by the errorgradient of the neurons multiplied by the neurons weight
                            errorGradSum += layers[i + 1].neurons[p].errorGradient * layers[i + 1].neurons[p].weights[j];
                        }
                        layers[i].neurons[j].errorGradient *= errorGradSum; //Multiply the neurons errorgradient by the accumulated error
                    }
                    for (int k = 0; k < layers[i].neurons[j].nInputs; k++) //For each input of the neuron
                    {
                        if (i == nHidden) //If we are at the output layer
                        {
                            error = desiredOutputs[j] - outputs[j]; //Compute the error as the difference between the neurons output and its desired output
                            layers[i].neurons[j].weights[k] += alpha * layers[i].neurons[j].inputs[k] * error; //Add the product of the learning rate, one of the neurons inputs and the error to the neurons weight
                        }
                        else 
                        {
                            //Add the product of the learning rate, one of the neurons input and the neurons errorgradient to the neurons weight
                            layers[i].neurons[j].weights[k] += alpha * layers[i].neurons[j].inputs[k] * layers[i].neurons[j].errorGradient;
                        }
                        layers[i].neurons[j].bias += alpha * -1 * layers[i].neurons[j].errorGradient; //Compute the neurons bias as the product of -alpha and the neurons errorgradient
                    }
                }
            }
        }
        //Link to a full list of activation functions:
        //https://en.wikipedia.org/wiki/Activation_function

        double TanH(double value) 
        {
            double k = (double)Math.Exp(-2 * value);
            return 2 / (1.0 + k) - 1;
        }

        double Sigmoid(double value) //Aka logistic softstep
        {
            double k = (double)Math.Exp(value);
            return k / (1.0f + k);
        }
    }

}
