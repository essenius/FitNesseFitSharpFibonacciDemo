﻿// Copyright 2013-2020 Rik Essenius
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System;

namespace ExtendedMath
{
    public static class Functions
    {
        /// <returns>
        ///     The Fibonacci number at index factor. Throws ArgumentOutOfRange with negative inputs, and OVerflow if the result is too
        ///     large for an int
        /// </returns>
        /// <remarks>a Fibonacci number is defined as the sum of the previous two Fibonacci numbers, with 0 and 1 returning themselves</remarks>
        /// <param name="factor">the index of the Fibonacci number to be calculated</param>
        public static int Fibonacci(int factor)
        {
            if (factor < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(factor), "Input should be 0 or positive");
            }

            if (factor < 2) return factor;

            var previousNumber = 1;
            var currentNumber = 1;
            for (var i = 2; i < factor; i++)
            {
                // throw overflow exception if needed
                var nextNumber = checked(previousNumber + currentNumber);
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }
            return currentNumber;
        }
    }
}
