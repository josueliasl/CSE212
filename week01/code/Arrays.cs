public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // PLAN:
        // 1.- Create a double array named multiples with the size of length
        // 2.- Begin a for loop starting at point 0 until length using variable called i
        // 3.- Multiply number for i+ 1 in order to not start with cero
        // 4.- Store the result of the previous calculous in multiples with array i
        // 5.- Once the loops is over return multiples

        double[] multiples = new double[length];
        for (var i = 0; i < length; ++i)
        {
                multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // PLAN
        // 1.- Create a variable called  startIndex to substract amount from the data count 
        // 2.- Create a list of int called endPart to get the range of data having startIndex and amount as parameters
        // 3.- Create a list of int called startPart to get the range from 0 to startIndex as parameters
        // 4.- Clear data list
        // 5.- Use AddRange to add endpart and startPart to data in their corresponding order
        var startIndex = data.Count - amount;
        List<int> endPart = data.GetRange(startIndex, amount);
        List<int> startPart = data.GetRange(0, startIndex);
        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);

    }
}
