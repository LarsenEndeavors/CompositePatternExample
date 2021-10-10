using System;
using System.Collections.Generic;
using CompositePatternExample.Objects;

namespace CompositePatternExample
{
    internal static class CompositePatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Christopher Okhravi YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/10
         */
        
        private static void Main()
        {
            // The main part of the composite pattern is there is a an object that contains other objects that inherit
            // from the same interface, this allows for the program to treat them the same and get different results,
            // in this case the pattern is utilized to walk a tree of IComposite objects that call ToHtml() recursively
            var leafOne = new Leaf("Adventure");
            var leafTwo = new Leaf("Time");
            var leafThree = new Leaf("Bacon");
            var leafFour = new Leaf("Pancakes");

            var leafListOne = new List<IComposite> { leafOne, leafTwo };
            var leafListTwo = new List<IComposite> { leafThree, leafFour };

            var nodeOne = new Node("Show Title", leafListOne);
            var nodeTwo = new Node("Show Food!", leafListTwo);

            Console.WriteLine("nodeOne.ToHtml():\n" + nodeOne.ToHtml());
            Console.WriteLine("nodeTwo.ToHtml():\n" + nodeTwo.ToHtml());

            var nodeList = new List<IComposite> { nodeOne, nodeTwo };
            var fullComposite = new Node("Full List:", nodeList);

            Console.WriteLine(fullComposite.ToHtml());
        }
    }
}