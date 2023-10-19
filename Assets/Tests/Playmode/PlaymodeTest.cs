using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using NUnit.Framework;
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
        }
    }
}