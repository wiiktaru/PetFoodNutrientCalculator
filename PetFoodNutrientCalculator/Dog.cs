﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    internal class Dog : Pet, IPet
    {
        public Dog(string name,double weight)
        {
            Name = name;
            Weight = weight;
            MetabolicWeight = CalculateMetabolicWeight(weight);
            
        }

        public double CalculateMetabolicWeight(double weight)
        {
            double result = Math.Pow(weight, COEFFICIENT_FOR_METABOLIC_WEIGHT);

            return result;
        }

        public int CalculateDailyEnergyRequirement()
        {
            throw new NotImplementedException();
        }

        public void CalculateNutrients()
        {
            throw new NotImplementedException();
        }
    }
}