using System;
public class Prime
{
	public static void Main(string[] args)
	{
		Console.WriteLine("����Ҫ����0������֮���������");
		int N=int.Parse(Console.ReadLine());
		bool []a=new bool[N+1];
		for(int i=2;i<=N;i++) a[i]=true;//��ʼ��
		for(int i=2;i<N;i++)
		{
			if(a[i]) //����������û�б����Ϊ����
				for(int j=i*2;j<=N;j+=i)//��ÿһ��i�ı���������
					a[j]=false;//���Ϊfalse������
		}
		for(int i=2;i<=N;i++)
			if(a[i]) Console.Write(i+" ");
	}
}