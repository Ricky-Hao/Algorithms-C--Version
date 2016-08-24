using System;
using System.IO;

namespace Program
{
    public class BinarySearch
    {
        public static int rank(int key,int[] a)
        {
            //必须是有序数组
            int lo=0;
            int hi=a.Length-1;
            while(lo<=hi)
            {
                //被查找的键要么不存在，要么必然存在于a[l0..hi]之中
                int mid=lo+(hi-lo)/2;
                if(key<a[mid]) hi=mid-1;
                else if(key>a[mid]) lo=mid+1;
                else return mid;
            }
            return -1;
        }

        public static int Main(String[] args)
        {
            if(args.Length==0)
            {
                return -1;
            }

            else
            {
                if(File.Exists(".\\"+args[0]))
                {
                    
                    String[] s=File.ReadAllLines(args[0]);
                    int[] whitelist=new int[s.Length];
                    for(int i=0;i<s.Length;i++)
                    {
                        whitelist[i]=int.Parse(s[i]);
                    }
                    System.Array.Sort(whitelist);
                    var tmp=Console.ReadLine();
                    while(tmp!=null)
                    {
                        int key=int.Parse(tmp);
                        int a=0;
                        a=rank(key,whitelist);
                        Console.WriteLine(a);
                        tmp=Console.ReadLine();
                    }
                }
                return 0;
            }
        }
    }
}
