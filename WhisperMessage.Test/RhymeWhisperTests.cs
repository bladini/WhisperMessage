﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace WhisperMessage.Test
{
    [TestClass]
    public class RhymeWhisperTests
    {
        IWhisperString stringManipulator = new RhymeWhisper();

        [TestMethod]
        public void RhymeWhisperReturnsRhyme()
        {
            string value = "pappa";
            string[] expected = { "kappa", "nappa", "trappa" };

            string actual = stringManipulator.ManipulateMessage(value);

            Assert.IsTrue(expected.Contains(actual));
        }

        [TestMethod]
        public void RhymeWhisperReturnsMessageWithNullInput()
        {
            string value = null;

            string actual = stringManipulator.ManipulateMessage(value);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void RhymeWhisperReturnsMessageWithEmptyInput()
        {
            string value = string.Empty;
            string expected = string.Empty;

            string actual = stringManipulator.ManipulateMessage(value);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RhymeWhisperReturnsMessageWithWhitespaceInput()
        {
            string value = " ";
            string expected = " ";

            string actual = stringManipulator.ManipulateMessage(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
