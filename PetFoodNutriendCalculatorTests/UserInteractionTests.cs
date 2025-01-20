﻿using PetFoodNutrientCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculatorTests
{

    [TestClass]
    public class UserInteractionTests
    {
        [TestMethod]
        public void Start_ShouldAcceptValidInput1()
        {
            // Arrange
            var userInteraction = new UserInteraction();
            var input = new StringReader("1\n");
            Console.SetIn(input);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            userInteraction.Start();

            // Assert
            StringAssert.Contains(output.ToString(), "Valitse 1 mikäli haluat lisätä lemmikin.");
            StringAssert.Contains(output.ToString(), "Valitse 2 mikäli haluat valita lemmikin listalta");
            StringAssert.Contains(output.ToString(), "Valitse 3 mikäli haluat sulkea sovelluksen");
        }

        [TestMethod]
        public void Start_ShouldAcceptValidInput2()
        {
            // Arrange
            var userInteraction = new UserInteraction();
            var input = new StringReader("2\n");
            Console.SetIn(input);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            userInteraction.Start();

            // Assert
            StringAssert.Contains(output.ToString(), "Valitse 1 mikäli haluat lisätä lemmikin.");
            StringAssert.Contains(output.ToString(), "Valitse 2 mikäli haluat valita lemmikin listalta");
            StringAssert.Contains(output.ToString(), "Valitse 3 mikäli haluat sulkea sovelluksen");
        }

        [TestMethod]
        public void Start_ShouldAcceptValidInput3()
        {
            // Arrange
            var userInteraction = new UserInteraction();
            var input = new StringReader("3\n");
            Console.SetIn(input);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            userInteraction.Start();

            // Assert
            StringAssert.Contains(output.ToString(), "Valitse 1 mikäli haluat lisätä lemmikin.");
            StringAssert.Contains(output.ToString(), "Valitse 2 mikäli haluat valita lemmikin listalta");
            StringAssert.Contains(output.ToString(), "Valitse 3 mikäli haluat sulkea sovelluksen");
        }

        [TestMethod]
        public void Start_ShouldRejectInvalidInput()
        {
            // Arrange
            var userInteraction = new UserInteraction();
            var input = new StringReader("invalid\n3\n");
            Console.SetIn(input);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            userInteraction.Start();

            // Assert
            StringAssert.Contains(output.ToString(), "Syöte virheellinen, valitse kokonaisluku 1, 2 tai 3.");
        }
    }
}
