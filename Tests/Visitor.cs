using System.Linq;
using DesignPatterns.Behavioral.Visitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Visitor
    {
        [TestMethod]
        public void Tests()
        {
            var list = new WordsList(new[] {"Pie", "tomato"});
            list.Add("Pieapple");

            var linkedList = new WordsLinkedList(new[] {"Pie", "Tomato"});
            linkedList.AddLast("Pieapple");

            var search1 = new LikeSearcher("Pie");
            list.Browse(search1);
            CollectionAssert.AreEqual(new[] {"Pie", "Pieapple"}, search1.Matches.ToArray());

            var search2 = new LikeSearcher("Pie");
            linkedList.Browse(search2);
            CollectionAssert.AreEqual(new[] { "Pie", "Pieapple" }, search2.Matches.ToArray());
        }
    }
}
