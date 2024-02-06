namespace app;

public class MultyPrefixAndSuffixArray
{
    //Идея - сохранять произведение префикса и суффикса. Уменьшать суффикс и увеличивать префикс с каждой итерацией
    //Оказалась не очень выгодной, если в массиве много нулей.
    public int[] ProductExceptSelf(int[] nums)
    {
        
        int prefixMulty = 1;
        int suffixMulty = nums.Skip(1).Aggregate((x, y) => x * y);
        int[] result = new int[nums.Length];

        for (int i = 0; i < result.Length - 1; i++)
        {
            result[i] = prefixMulty * suffixMulty;

            prefixMulty *= nums[i];
            if (nums[i + 1] != 0)
            {
                suffixMulty /= nums[i + 1];
            } 
            else if(nums.Length < i + 2){
                //Узкое место
                suffixMulty = nums.Skip(i + 2).Aggregate((x, y) => x * y);
            }
        }

        result[result.Length - 1] = prefixMulty;

        return result;
    }
    //Скорость O(2*n) = O(n)
    public int[] RigthAnfLeftWay(int[] nums) {
        int rigth = 1;
        int left = 1;
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = left;
            left *= nums[i];
        }

        for(int i = nums.Length - 1; i >= 0; i--) 
        {
            result[i] *= rigth;
            rigth *= nums[i];
        }

        return result;
    }
}
