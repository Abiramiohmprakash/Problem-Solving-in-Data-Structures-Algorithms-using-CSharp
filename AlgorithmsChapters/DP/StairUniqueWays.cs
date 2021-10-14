﻿using System;

public class StairUniqueWays
{
	public static int diffWaysBU(int n)
	{
		if (n <= 2)
		{
			return n;
		}

		int first = 1, second = 2;
		int temp = 0;

		for (int i = 3; i <= n; i++)
		{
			temp = first + second;
			first = second;
			second = temp;
		}
		return temp;
	}

	public static int diffWaysBU2(int n)
	{
		if (n < 2)
		{
			return n;
		}

		int[] ways = new int[n];
		ways[0] = 1;
		ways[1] = 2;

		for (int i = 2; i < n; i++)
		{
			ways[i] = ways[i - 1] + ways[i - 2];
		}

		return ways[n - 1];
	}

	public static void Main(string[] args)
	{
		Console.WriteLine("Unique way to reach top:: " + diffWaysBU(4));
		Console.WriteLine("Unique way to reach top:: " + diffWaysBU2(4));
	}
}
/*
Unique way to reach top:: 5
Unique way to reach top:: 5
*/