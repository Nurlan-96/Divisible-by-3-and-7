bool Number(int n)
{
    if ((n % 3 == 0) && (n % 7 == 0))
    return true;
    else return false;
}
Console.WriteLine(Number(21));