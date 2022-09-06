Console.Write("Введите размерность матрицы NxN:");  
            int n = int.Parse(Console.ReadLine());  
            int[, ] a = new int[n, n];  
            int printValue = 1;  
            int c1 = 0, c2 = n - 1;  
            while (printValue <= n * n)  
            {  
                //Движение вправо 
                for (int i = c1; i <= c2; i++)  
                    a[c1, i] = printValue++;  
                //Движение вниз
                for (int j = c1 + 1; j <= c2; j++)  
                    a[j, c2] = printValue++;  
                //Движение влево 
                for (int i = c2 - 1; i >= c1; i--)  
                    a[c2, i] = printValue++;  
                //Движение вверх  
                for (int j = c2 - 1; j >= c1 + 1; j--)  
                    a[j, c1] = printValue++;  
                c1++;  
                c2--;  
            }  
            for (int i = 0; i < n; i++)  
            {  
                for (int j = 0; j < n; j++)  
                {  
                    Console.Write("{0, 4}", a[i, j]);  
                }  
                Console.WriteLine();  
            }  