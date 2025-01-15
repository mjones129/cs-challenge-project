string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//create an array of orders separated by commas
string[] orders = orderStream.Split(',');

//for each of the orders in the stream count the number of characters
foreach (string order in orders)
{
    // Console.WriteLine(order.Length);
    //if order length is greater than 4, append "- Error" to the order
    if (order.Length > 4)
    {
        Console.WriteLine(order + " - Error");
    }
    // if order length is less than 4, append "- Error to the order
    else if (order.Length < 4)
    {
        Console.WriteLine(order + " - Error");
    }
    // output the order
    else
    {
        Console.WriteLine(order);
    }
}