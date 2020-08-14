// Copyright 2013-2020 Rik Essenius
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System;
using ExtendedMath;

namespace ExtendedMathTest
{
    public class FibonacciFixture
    {
        /// <summary>The input for the Fibonacci calculation</summary>
        public int InputValue { set; private get; }

        /// <returns>The Fibonacci number with index as per input value, i.e. 0 => 0, 1 => 1, 2 => 1, 3 => 2, 8 => 21, etc.</returns>
        /// <remarks>Returns exception type if an exception was thrown</remarks>
        public object Fibonacci()
        {
            try
            {
                return Functions.Fibonacci(InputValue);
            }
            catch (Exception e)
            {
                return e.GetType();
            }
        }
    }
}
