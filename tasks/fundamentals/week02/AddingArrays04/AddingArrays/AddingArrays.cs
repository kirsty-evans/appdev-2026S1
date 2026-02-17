using System.Buffers;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;

namespace AddingArrays;

public class AddingArrays
{

    public static int[] Join(int[] arrayA, int[] arrayB) {

        //initialise new array

        int newArrayLength = arrayA.Length + arrayB.Length;
        int[] newArray = new int[newArrayLength];

        for (int i = 0; i < arrayA.Length; i++)
        {
            newArray[i] = arrayA[i];
        }

        for (int i = 0; i < arrayB.Length; i++)
        {
            newArray[i + arrayA.Length] = arrayB[i];
        }

        return newArray;
    }

}
