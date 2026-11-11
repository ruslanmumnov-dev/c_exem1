// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for(int i=0; i<n; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine()); 
// }
// int cnt=0;

// for(int i=0; i<n; i++)
// {
//     int sum = 0;
//     for(int j=0; j<n; j++)
//     {
//         if (arr [i] == arr [j]  )
//         sum++;
//     }
//     if (cnt < sum)
//     {
//         cnt=sum;
//     }
// }
// System.Console.WriteLine(cnt);

// task 2

// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for(int i=0; i<n; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine()); 
// }
// int cnt=0;
// for(int i=0; i<arr.Length/2; i++)
// {
//     if(arr[i] == arr[(n-1) - i])
//     {
//         cnt ++;
       
//     }
    
// }
// if (cnt > 0)
// {
//     System.Console.WriteLine("True");
// }
// else
// {
//     System.Console.WriteLine("False");
// }

// task 3



// string abc = Console.ReadLine();
// for (int i=0; i<abc.Length; i++)
// {
//     if(Array[i]==)
// }



// task 5
// int n = Convert.ToInt32(Console.ReadLine());
// int [ ] arr = new int [n];
// for(int i=0; i<n; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine()); 
// }
// int maxx=0;
// for(int i=0; i<arr.Length; i++)
// {
//     if (maxx < arr[i])
//     {
//         maxx=arr[i];
//     }
// }
// System.Console.WriteLine(maxx);

// // task 6

// int n = Convert.ToInt32(Console.ReadLine());
// int number( int n)
// {
//     if (n < 10)
//     {
//         return 1;
//     }
    
// }/////////////////////////////////////////////


// task 7
// System.Console.Write("a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Multiply(ref a ,ref b);
// void Multiply(ref int a, ref int b)
// {
//     System.Console.WriteLine($"a = {a*2}");
//     System.Console.WriteLine($"a = {b*2}");
// }

// int n = Convert.ToInt32(Console.Readline());
// int [] arr = new int [n];

// int CountEvenNumbers(int[] arr)
// {
        
// }

// task 8

//  int n = Convert.ToInt32(Console.ReadLine());
//  int [] arr = new int [n]; 
//  for(int i=0; i<arr.Length; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine()); 
    
// }
// int cnt =0;
// for(int i=0; i<arr.Length; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);


// task 9
//  int n = Convert.ToInt32(Console.ReadLine());
// int [ ] arr = new int [n];
// int cnt=0;
// int c=0;
// for(int i=0; i<n; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine()); 
//     cnt+=arr[i];
//     c++;
// }
// int answer=0;
// for(int i=0; i<arr.Length; i++)
// {
//     if (cnt / c > arr[i])
//     {
//         answer++;
//     }
// }
// System.Console.WriteLine(answer);



// task 10

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(adadho(n));
// int adadho(int n)
// {
//     if (n ==0)
//     {
//         return n;
//     } 
//     return adadho(n-1);
// }