// // W1D2
// // ClassTask1


// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// int maxx = int.MinValue;
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i<a; i++)
// {   
//     if(maxx < arr[i])
//     {
//         maxx = arr[i];
//     }
// }
// Console.WriteLine(maxx);



// // Task2
// double sum = 0;
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// for(int i=0; i<=b; i++)
// {
//     sum+=Math.Pow(a,i);
// }
// Console.WriteLine(sum);

// // Task3
// int sum = 0;
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[a];

// for(int i=0; i<a; i++)
// {
// arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i=0; i<a; i++)
// {
//     sum+=arr[i];
// }
// Console.WriteLine($"Sum: {sum}");

// //Task 4
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];
// bool fo = false;
// for(int i=0; i<a - 1; i++)
// {
//     if((arr[i] > 0 && arr[i+1]>0) || (arr[i] <0 && arr[i + 1] < 0))
//     {
//         fo = true;
//         break;
//     }
// }
// if (fo)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }

// //Task 5
// int a;
// a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// Array.Sort(arr);

// for (int i = 0; i < a - 1; i++)
// {
  
//     if (arr[i] == arr[i + 1])
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }


// // Hom task
//// task 1

// double sum = Convert.ToDouble(Console.ReadLine());

// if (sum < 100)
// {
//     sum = sum + (sum * 0.05);
// }
// else if (sum <= 200)
// {
//     sum = sum + (sum * 0.07);
// }
// else
// {
//     sum = sum + (sum * 0.10);
// }
// Console.WriteLine(sum);

// // Task 2

// int a;
// a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];
// int pow =1 ;
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i=0; i<a; i++)
// {
//     pow*=arr[i];
// }
// Console.Write(pow);

// task 3
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

// int maxx = int.MinValue;
// int id = 0;

// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < a; i++)
// {
//     if (maxx < arr[i])
//     {
//         maxx = arr[i];
//         id = i;
//     }
// }

// Console.WriteLine(id);

// // Task 4

// int a;
// a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

// for(int i=0; i<a; i++)
// {
//  arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// Array.Sort(arr);

// for(int i=0; i<a-1; i++)
// {
//     if ((i == 0 || arr[i] != arr[i - 1]) && (i == a - 1 || arr[i] != arr[i + 1]))
//     {
//         Console.WriteLine($"{arr[i]} ");
//     }
// }

// // task 5

// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

// int maxx = int.MaxValue;
// int id = 0;

// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < a; i++)
// {
//     if (maxx > arr[i])
//     {
//         maxx = arr[i];
//         id = i;
//     }
// }
// Console.WriteLine(id);

// //Task 6
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new  int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for(int i = 1; i<a-1; i++)
// {
//     if(arr[i] >arr[i-1] && arr[i] > arr[i + 1])
//     {
//     cnt++;    
//     }
// }
// Console.WriteLine(cnt);

// // task 7
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = a - 2; i >= 0; i--)
// {
//     if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i] < 0 && arr[i + 1] < 0))
//     {
//         Console.WriteLine($"{arr[i]} {arr[i + 1]}");
//         break;
//     }
// }

// // task 8
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0;i<a;i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0;i<a; i++)
// {
//     if (arr[i]%2!= 0)
//     {
//         Console.Write($"{i} ");
//     }
// }

// //Task 9
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int b = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i=b; i<=n; i++)
// {
//     if (arr[i]%2!=0)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// // Task 10
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

// for(int i=0;i<a;i++)
// {
//     arr[i] =Convert.ToInt32(Console.ReadLine());
// }

// for (int i =0;i<a;i++)
// {
//     if (arr[i]%2!=0)
//     {
//         Console.Write($"{arr[i]*arr[i]}");
//     }
// }