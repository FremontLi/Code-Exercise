using System;
class jiaogu
{
	public static void Main(string[] args)
	{
		Console.WriteLine("请输入一个数字");
		int a=int.Parse(Console.ReadLine());
		//任何一个数字都可以经过这两个公式变成1，角谷猜想
		while(a!=1)
		{
			Console.Write(" "+a);
			if(a%2==1) //如果a是奇数
				a=a*3+1;
			else a/=2;//如果a是偶数
		}
		Console.WriteLine(" "+a);
	}


}