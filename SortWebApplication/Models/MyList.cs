namespace SortWebApplication.Models
{
    public class MyList
    {
        private int[] items;

        private int size = 0;        

        public MyList()
        {
            items = new int[0];
        }   
        
        public int Count()
        {
            return size;
        }

        private void IncreaseSize()
        {
            int newCount = size * 2;

            if (size == 0)
            {
                newCount = 4;
            }

            var newArray = new int[newCount];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public void Add(int item)
        {
            if (size == items.Length)
            {
                IncreaseSize();
            }

            items[size] = item;
            size++;
        }

        public void Remove()
        {
            if (size == 0)
            {
                throw new Exception("Массив пустой.");
            }
            size--;
        }

        public void Sort()
        {
            for (int i = size - 1; i > 0; i--)
            {
                int maxIndex = i;

                for (int j = 0; j < i; j++)
                {
                    if (items[j] > items[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
               
                if (maxIndex != i)
                {                    
                    int temp = items[maxIndex];
                    items[maxIndex] = items[i];
                    items[i] = temp;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += items[i] + " ";
            }

            return result;
        }

    }
}
