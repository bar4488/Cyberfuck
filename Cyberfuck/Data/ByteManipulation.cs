﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cyberfuck.Data
{
    public static class ByteManipulation
    {
        public static byte[] WrapWithInt(byte[] msgContent, int number)
        {
            byte[] numberBytes = BitConverter.GetBytes(number);
            return ConcatByteArrays(numberBytes, msgContent);
        }

        public static byte[] ConcatByteArrays(params byte[][] bytesArray)
        {
            int length = 0;
            for (int i = 0; i < bytesArray.Length; i++)
            {
                length += bytesArray[i].Length;
            }
            byte[] finalBytes = new byte[length];
            int offset = 0;
            for (int i = 0; i < bytesArray.Length; i++)
            {
                Buffer.BlockCopy(bytesArray[i], 0, finalBytes, offset, bytesArray[i].Length);
                offset += bytesArray[i].Length;
            }
            return finalBytes;
        }

        public static int[] ConvertBytesToInts(byte[] arr)
        {
            int[] result = new int[arr.Length / sizeof(int)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = BitConverter.ToInt32(arr, i * sizeof(int));
            }
            return result;
        }
    }
}