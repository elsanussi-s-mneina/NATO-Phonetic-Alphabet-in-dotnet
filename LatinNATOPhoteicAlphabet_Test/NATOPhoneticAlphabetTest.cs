using NUnit.Framework;
using static NATOPhoneticAlphabet.NATOPhoneticAlphabet;

namespace LatinNATOPhoneticAlphabet.Test
{
    [TestFixture]
    public class NATOPhoneticAlphabetTest
    {
        [Test]
        public void SpellText_LowercaseA_ShouldBeAlpha()
        {
            Assert.AreEqual("Alpha", SpellText("a"));
        }

        [Test]
        public void SpellText_UppercaseA_ShouldBeAlpha()
        {
            Assert.AreEqual("Alpha", SpellText("A"));
        }

        [Test]
        public void SpellText_LowercaseB_ShouldBeBravo()
        {
            Assert.AreEqual("Bravo", SpellText("b"));
        }

        [Test]
        public void SpellText_UppercaseB_ShouldBeBravo()
        {
            Assert.AreEqual("Bravo", SpellText("B"));
        }

        [Test]
        public void SpellText_LowercaseC_ShouldBeCharlie()
        {
            Assert.AreEqual("Charlie", SpellText("c"));
        }

        [Test]
        public void SpellText_UppercaseC_ShouldBeCharlie()
        {
            Assert.AreEqual("Charlie", SpellText("C"));
        }

        [Test]
        public void SpellText_LowercaseD_ShouldBeDelta()
        {
            Assert.AreEqual("Delta", SpellText("d"));
        }

        [Test]
        public void SpellText_UppercaseD_ShouldBeDelta()
        {
            Assert.AreEqual("Delta", SpellText("D"));
        }

        [Test]
        public void SpellText_LowercaseE_ShouldBeEcho()
        {
            Assert.AreEqual("Echo", SpellText("e"));
        }

        [Test]
        public void SpellText_UppercaseE_ShouldBeEcho()
        {
            Assert.AreEqual("Echo", SpellText("E"));
        }

        [Test]
        public void SpellText_LowercaseF_ShouldBeFoxtrot()
        {
            Assert.AreEqual("Foxtrot", SpellText("f"));
        }

        [Test]
        public void SpellText_UppercaseF_ShouldBeFoxtrot()
        {
            Assert.AreEqual("Foxtrot", SpellText("F"));
        }

        [Test]
        public void SpellText_LowercaseG_ShouldBeGolf()
        {
            Assert.AreEqual("Golf", SpellText("g"));
        }

        [Test]
        public void SpellText_UppercaseG_ShouldBeGolf()
        {
            Assert.AreEqual("Golf", SpellText("G"));
        }

        [Test]
        public void SpellText_LowercaseH_ShouldBeHotel()
        {
            Assert.AreEqual("Hotel", SpellText("h"));
        }

        [Test]
        public void SpellText_UppercaseH_ShouldBeHotel()
        {
            Assert.AreEqual("Hotel", SpellText("H"));
        }

        [Test]
        public void SpellText_LowercaseI_ShouldBeIndia()
        {
            Assert.AreEqual("India", SpellText("i"));
        }

        [Test]
        public void SpellText_UppercaseI_ShouldBeIndia()
        {
            Assert.AreEqual("India", SpellText("I"));
        }

        [Test]
        public void SpellText_LowercaseJ_ShouldBeJuliett()
        {
            Assert.AreEqual("Juliett", SpellText("j"));
        }

        [Test]
        public void SpellText_UppercaseJ_ShouldBeJuliett()
        {
            Assert.AreEqual("Juliett", SpellText("J"));
        }

        [Test]
        public void SpellText_LowercaseK_ShouldBeKilo()
        {
            Assert.AreEqual("Kilo", SpellText("k"));
        }

        [Test]
        public void SpellText_UppercaseK_ShouldBeKilo()
        {
            Assert.AreEqual("Kilo", SpellText("K"));
        }

        [Test]
        public void SpellText_LowercaseL_ShouldBeLima()
        {
            Assert.AreEqual("Lima", SpellText("l"));
        }

        [Test]
        public void SpellText_UppercaseL_ShouldBeLima()
        {
            Assert.AreEqual("Lima", SpellText("L"));
        }

        [Test]
        public void SpellText_LowercaseM_ShouldBeMike()
        {
            Assert.AreEqual("Mike", SpellText("m"));
        }

        [Test]
        public void SpellText_UppercaseM_ShouldBeMike()
        {
            Assert.AreEqual("Mike", SpellText("M"));
        }

        [Test]
        public void SpellText_LowercaseN_ShouldBeNovember()
        {
            Assert.AreEqual("November", SpellText("n"));
        }

        [Test]
        public void SpellText_UppercaseN_ShouldBeNovember()
        {
            Assert.AreEqual("November", SpellText("N"));
        }

        [Test]
        public void SpellText_LowercaseO_ShouldBeOscar()
        {
            Assert.AreEqual("Oscar", SpellText("o"));
        }

        [Test]
        public void SpellText_UppercaseO_ShouldBeOscar()
        {
            Assert.AreEqual("Oscar", SpellText("O"));
        }

        [Test]
        public void SpellText_LowercaseP_ShouldBePapa()
        {
            Assert.AreEqual("Papa", SpellText("p"));
        }

        [Test]
        public void SpellText_UppercaseP_ShouldBePapa()
        {
            Assert.AreEqual("Papa", SpellText("P"));
        }

        [Test]
        public void SpellText_LowercaseQ_ShouldBeQuebec()
        {
            Assert.AreEqual("Quebec", SpellText("q"));
        }

        [Test]
        public void SpellText_UppercaseQ_ShouldBeQuebec()
        {
            Assert.AreEqual("Quebec", SpellText("Q"));
        }

        [Test]
        public void SpellText_LowercaseR_ShouldBeRomeo()
        {
            Assert.AreEqual("Romeo", SpellText("r"));
        }

        [Test]
        public void SpellText_UppercaseR_ShouldBeRomeo()
        {
            Assert.AreEqual("Romeo", SpellText("R"));
        }

        [Test]
        public void SpellText_LowercaseS_ShouldBeSierra()
        {
            Assert.AreEqual("Sierra", SpellText("s"));
        }

        [Test]
        public void SpellText_UppercaseS_ShouldBeSierra()
        {
            Assert.AreEqual("Sierra", SpellText("S"));
        }

        [Test]
        public void SpellText_LowercaseT_ShouldBeTango()
        {
            Assert.AreEqual("Tango", SpellText("t"));
        }

        [Test]
        public void SpellText_UppercaseT_ShouldBeTango()
        {
            Assert.AreEqual("Tango", SpellText("T"));
        }

        [Test]
        public void SpellText_LowercaseU_ShouldBeUniform()
        {
            Assert.AreEqual("Uniform", SpellText("u"));
        }

        [Test]
        public void SpellText_UppercaseU_ShouldBeUniform()
        {
            Assert.AreEqual("Uniform", SpellText("U"));
        }

        [Test]
        public void SpellText_LowercaseV_ShouldBeVictor()
        {
            Assert.AreEqual("Victor", SpellText("v"));
        }

        [Test]
        public void SpellText_UppercaseV_ShouldBeVictor()
        {
            Assert.AreEqual("Victor", SpellText("V"));
        }

        [Test]
        public void SpellText_LowercaseW_ShouldBeWhiskey()
        {
            Assert.AreEqual("Whiskey", SpellText("w"));
        }

        [Test]
        public void SpellText_UppercaseW_ShouldBeWhiskey()
        {
            Assert.AreEqual("Whiskey", SpellText("W"));
        }

        [Test]
        public void SpellText_LowercaseX_ShouldBeXray()
        {
            Assert.AreEqual("X-ray", SpellText("x"));
        }

        [Test]
        public void SpellText_UppercaseX_ShouldBeXray()
        {
            Assert.AreEqual("X-ray", SpellText("X"));
        }

        [Test]
        public void SpellText_LowercaseY_ShouldBeYankee()
        {
            Assert.AreEqual("Yankee", SpellText("y"));
        }

        [Test]
        public void SpellText_UppercaseY_ShouldBeYankee()
        {
            Assert.AreEqual("Yankee", SpellText("Y"));
        }

        [Test]
        public void SpellText_LowercaseZ_ShouldBeZulu()
        {
            Assert.AreEqual("Zulu", SpellText("z"));
        }

        [Test]
        public void SpellText_UppercaseZ_ShouldBeZulu()
        {
            Assert.AreEqual("Zulu", SpellText("Z"));
        }

    }
}
