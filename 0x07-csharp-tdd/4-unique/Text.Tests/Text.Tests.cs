using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void UniqueChar_Empty()
        {
            string s = "";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void UniqueChar_Lol()
        {
            string s = "wwwwwwwwwwwwwwwwwwwwwwwww";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void UniqueChar_String()
        {
            string s = "abcdefghijklmnopqrstuvwxyzabcdfghijkzxywvutsrponlm";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(4));
        }
        
    }
}
