using Microsoft.AspNetCore.Mvc;

namespace Day3ArraysAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ArrayController : ControllerBase
{
    int[] myNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    [HttpGet]
    [Route("Even")]

    public int[] EvenNum()
    {
        // we are Prefilling this array with 0
        //Then we will add even numbers into our 'EvenNumbers' Array.
        int[] EvenNumbers = new int[myNum.Length];

        for (int i = 0; i < myNum.Length; i++)
        {
            if (myNum[i] % 2 == 0)
            {
                //The number is Even
                //Add the Even numbers to 'EvenNumbers' Array.
                EvenNumbers[i] = myNum[i];
            }
        }
        return EvenNumbers;
    }

[HttpGet]
[Route("EvenLists")]

public List<int> GetEvenNumbersByList()
{
    List<int> EvenList = new List<int>();

for (int i = 0; i < myNum.Length; i++)
{
    if (myNum[i] % 2 == 0)
    {
        EvenList.Add(myNum[i]);
    }
} return EvenList;
}

}