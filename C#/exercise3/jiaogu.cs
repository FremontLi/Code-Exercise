using System;
class jiaogu
{
	public static void Main(string[] args)
	{
		Console.WriteLine("������һ������");
		int a=int.Parse(Console.ReadLine());
		//�κ�һ�����ֶ����Ծ�����������ʽ���1���ǹȲ���
		while(a!=1)
		{
			Console.Write(" "+a);
			if(a%2==1) //���a������
				a=a*3+1;
			else a/=2;//���a��ż��
		}
		Console.WriteLine(" "+a);
	}


}