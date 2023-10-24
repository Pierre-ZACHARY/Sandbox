using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using NUnit.Framework;
using UnityEngine.Profiling;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlaymodeTest
    {
        [Test]
        public void PlaymodeTestSimplePasses()
        {
            // Use the Assert class to test conditions.

        }

        /// <summary>
        /// This is a summary description of the MyMethod.
        /// </summary>
        /// <returns>Description of the return value.</returns>
        public static int Factorial(int n)
        {
            CiProfiler.BeginSample("Factorial");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Profiler.EndSample();

            return result;
        }

        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityTest]
        public IEnumerator PlaymodeTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // yield to skip a frame
            yield return null;

            var p = new Process();
            p.StartInfo.FileName = "exportLegacy.exe";
            string command = Console.ReadLine();
            p.StartInfo.Arguments = " -cl " + command + " -role user";
            p.Start();

            // run factorial for 60 frames
            for(int i = 0; i<60; i++)
            {
                Factorial(1000000);
                yield return null;
            }
        }
    }

}