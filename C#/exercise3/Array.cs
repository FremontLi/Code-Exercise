using System;
class Array
{
	public static void Main(string[] args)
	{
		///* 一个由 5 个整型数组组成的交错数组 */
		int[][] a=new int[][]{new int[]{0,0},new int[]{1,2},
			new int[]{2,4},new int[]{3,6},new int[]{4,8}};
		int i,j;

		///* 输出数组中每个元素的值 */
		for(i=0;i<5;i++)
		{
			for(j=0;j<2;j++)
			{
				Console.WriteLine("a[{0}][{1}]={2}",i,j,a[i][j]);
			}
		}
		Console.ReadKey();
	}

}