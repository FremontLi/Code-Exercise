using System;
public class Prime
{
	public static void Main(string[] args)
	{
		Console.WriteLine("您需要搜索0至多少之间的素数？");
		int N=int.Parse(Console.ReadLine());
		bool []a=new bool[N+1];
		for(int i=2;i<=N;i++) a[i]=true;//初始化
		for(int i=2;i<N;i++)
		{
			if(a[i]) //如果这个数还没有被标记为素数
				for(int j=i*2;j<=N;j+=i)//把每一个i的倍数都划掉
					a[j]=false;//标记为false，素数
		}
		for(int i=2;i<=N;i++)
			if(a[i]) Console.Write(i+" ");
	}
}
