using CodeKata.Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests.Solutions
{
    /// <summary>
    /// Karata Chop Tests.
    /// </summary>
    [TestClass]
    public class KarateChopTests
    {
        /// <summary>
        /// Returneds the index of the results are zero.
        /// </summary>
        [TestMethod]
        public void ReturnedResultsAreZeroIndex()
        {
            Assert.AreEqual(0, KarateChop.Chop(1, new int[] { 1 }));
            Assert.AreEqual(0, KarateChop.Chop(1, new int[] { 1, 3, 5 }));
            Assert.AreEqual(0, KarateChop.Chop(1, new int[] { 1, 3, 5, 7 }));
        }

        /// <summary>
        /// Determines whether this instance [can find targets].
        /// </summary>
        [TestMethod]
        public void CanFindTargets()
        {
            Assert.AreEqual(1,  KarateChop.Chop(3, new int[] { 1, 3, 5 }));
            Assert.AreEqual(2,  KarateChop.Chop(5, new int[] { 1, 3, 5 }));
            Assert.AreEqual(1,  KarateChop.Chop(3, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(2,  KarateChop.Chop(5, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(3,  KarateChop.Chop(7, new int[] { 1, 3, 5, 7 }));
        }

        /// <summary>
        /// Determines whether this instance [can handle empty arrays].
        /// </summary>
        [TestMethod]
        public void CanHandleEmptyArrays()
        {
            Assert.AreEqual(-1, KarateChop.Chop(3, new int[] { }));
        }

        /// <summary>
        /// Determines whether this instance [can identify not found targets].
        /// </summary>
        [TestMethod]
        public void CanIdentifyNotFoundTargets()
        {
            Assert.AreEqual(-1, KarateChop.Chop(3, new int[] { 1 }));
            Assert.AreEqual(-1, KarateChop.Chop(0, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, KarateChop.Chop(2, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, KarateChop.Chop(4, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, KarateChop.Chop(6, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, KarateChop.Chop(0, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, KarateChop.Chop(2, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, KarateChop.Chop(4, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, KarateChop.Chop(6, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, KarateChop.Chop(8, new int[] { 1, 3, 5, 7 }));
        }
    }
}