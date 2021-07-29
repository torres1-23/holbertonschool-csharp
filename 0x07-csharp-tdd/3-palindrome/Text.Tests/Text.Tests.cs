using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void IsPalindrome_Symbols()
        {
            string test = "!?. :;";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_Panama()
        {
            string test = "A man, a plan, a canal: Panama.";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_Abaj()
        {
            string test = "ABAJABAJ";
            Assert.That(Text.Str.IsPalindrome(test), Is.False);
        }
        [Test]
        public void xempty()
        {
            string s = "";
            
            bool result = Text.Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
    }
}
