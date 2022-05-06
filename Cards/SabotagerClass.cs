using ClassesManagerReborn;
using System.Collections;

namespace BPP.Cards
{
    class SabotagerClass : ClassHandler
    {
        internal static string name = "Sabo";

        public override IEnumerator Init()
        {
            CardInfo classCard = null;
            while (!(Sabotager.Card && Chained.Card && Culling.Card && Sluggish.Card && FakeCaliber.Card && Clumsy.Card)) yield return null;
            ClassesRegistry.Register(Sabotager.Card, CardType.Entry);
            ClassesRegistry.Register(Chained.Card, CardType.Card, Sabotager.Card);
            ClassesRegistry.Register(Culling.Card, CardType.Card, Sabotager.Card);
            ClassesRegistry.Register(Sluggish.Card, CardType.Card, Sabotager.Card);
            ClassesRegistry.Register(FakeCaliber.Card, CardType.Card, Sabotager.Card);
            ClassesRegistry.Register(Clumsy.Card, CardType.Card, Sabotager.Card);
        }
    }
}