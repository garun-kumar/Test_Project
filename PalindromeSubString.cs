using System;
					
public class Program
{
	public static void Main()
	{
		string str = "ABCDDCBAA";
		string result = "";
		bool t = new bool();
		int i,j,k,l;
		
		for(k=0;k<str.Length-1;k++)
		{
			for(l=str.Length-1;l>k;l--)
			{
				if(str[k] == str[l])
				{	
					int startIndex = k;
					int endIndex = l-k+1;
					result = str.Substring(startIndex,endIndex);
					
					for(i=0,j=result.Length-1;i<result.Length-1/2;i++,j--)
					{
						if(result[i] != result[j]) 
						{
							t = false;
							break;
						}
						else
							t = true;
					}
					if(t)
						Console.WriteLine("Palindrome {0}",result);
				}
				
			}
			
		}		
		if(!t)
			Console.WriteLine("No Palindrome subString exists in the given String.");
		
	}
}