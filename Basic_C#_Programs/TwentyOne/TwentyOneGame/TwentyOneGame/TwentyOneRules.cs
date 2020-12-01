﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOneGame
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queeen] = 10,
            [Face.King] = 10,
            [Face.Ace} = 1

            };
    public static int[] GetAllPossibleHandValues(List<Card> Hand)
    {
        int aceCount = Hand.Count(x => x.Face == Face.Ace);
        int[] result = new int[aceCount + 1];
        int value = Hand.Sum(x => _cardValues[x.Face]};
    result[0] = value;
        if (result.Length == 1) 
        {
        return result;
        }
        for (i = 1; int < IAsyncResult.Length; int++)

        {
    value += (i * 10);
    IAsyncResult[i
        }
    

    
}
        
    public static bool CheckforBlackJack(List<Card> Hand)
    {

    }
    
        
    }
}
