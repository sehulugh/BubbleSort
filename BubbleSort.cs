static void BubbleSort(int[] arr)
        {        
            //convert to list cos its easier to play with
            List<int> arL = arr.ToList();
            //make sorted a copy of the list so we use in our while loop
            List<int> SoretedarL = arr.ToList();
            SoretedarL.Sort();

            //get the lenght of the list
            int L = arL.Count;

            //The IdenticalLists Fn compares the lists to see if its all sorted
            while (IdenticalLists(arL, SoretedarL) == false)
            {
                //the For Loop loops from the last to the first int
                for (int i = L - 1; i > 0; i--)
                {
                    //and checks stating with the 2nd to last to see if it is grater than the last int
                    if ((arL[i - 1]) > (arL[i]))
                    {
                        //if yes we hold it in a temp variable t
                        int t = arL[i - 1];
                        //then remove it from the list
                        arL.RemoveRange(i - 1, 1);
                        //then insert it two postions to the right
                        arL.Insert((i), t);
                        //run a for each loop and output the list then go to the next iteration
                        foreach (int a in arL)
                        {
                            Console.Write($"{a} ");
                        }
                        Console.Write("\n");
                    }

                }
                
            }

            Console.ReadLine();
        }

        static bool IdenticalLists(List<int> L1, List<int> L2)
        {

            if (L1.Count() != L2.Count())
            {
                return false;
            }
            else
            {

                for (int i = 0;i< L1.Count; i++)
                {
                   if (L1[i] != L2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
        
